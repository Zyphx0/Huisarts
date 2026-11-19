using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Huisarts_nieuwepatient;
using Huisarts_Notatie;
using Huisarts_bewerken;

namespace Huisarts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DatabaseConnect connect = new DatabaseConnect();
        int pagia = 1;
        int maxperpagina = 25;
        int aantalpaginas = 4;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtZoek.Text = "Zoek op achternaam";
            txtZoek.ForeColor = Color.LightGray;
            LaadPatienten();
        }
        private void LaadPatienten()
        {
            string zoek = txtZoek.Text;
            if (zoek == "Zoek op achternaam")
            {
                zoek = "";
            }
            zoek = MySqlHelper.EscapeString(zoek);

            // 1. Tellen hoeveel patiënten er zijn
            DataTable dt = connect.ExecuteQuery(
                "SELECT COUNT(*) FROM patient_info WHERE Acternaam LIKE '%" + zoek + "%'");
            int totaal = 0;
            if (dt.Rows.Count > 0)
            {
                totaal = Convert.ToInt32(dt.Rows[0][0]);
            }

            aantalpaginas = (int)Math.Ceiling(totaal / (double)maxperpagina);
            if (aantalpaginas == 0)
            {
                aantalpaginas = 1;
            }

            // 2. Alleen de 25 patiënten van deze pagina ophalen
            int offset = (pagia - 1) * maxperpagina;
            Patienten_dtg.DataSource = connect.ExecuteQuery(
                "SELECT Id, voornaam, Acternaam, Adres, Huisnummer, Postcode, Plaats, telefoonnummer " +
                "FROM patient_info " +
                "WHERE Acternaam LIKE '%" + zoek + "%' " +
                //"ORDER BY Id DESC " +
                "LIMIT " + maxperpagina + " OFFSET " + offset);

            // 3. Label en knoppen bijwerken
            label2.Text = "Pagina " + pagia + " van " + aantalpaginas + " (" + totaal + " patiënten)";
            terugbtn.Enabled = pagia > 1;
            volgbtn.Enabled = pagia < aantalpaginas;
        }

        private void txtZoek_Enter(object sender, EventArgs e)
        {
            if (txtZoek.Text == "Zoek op achternaam")
            {
                txtZoek.Text = "";
                txtZoek.ForeColor = Color.Black;
            }
        }

        private void txtZoek_Leave(object sender, EventArgs e)
        {
            if (txtZoek.Text == "")
            {
                txtZoek.Text = "Zoek op achternaam";
                txtZoek.ForeColor = Color.LightGray;
            }
        }

        private void Zoekbtn_Click(object sender, EventArgs e)
        {
            string zoek = txtZoek.Text.ToLower();
            LaadPatienten();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNieuwePatient f = new FormNieuwePatient();

            f.FormClosed += (s, args) =>
            {
                if (f.DialogResult == DialogResult.OK)
                {
                    string voornaam = f.Voornaam.Replace("'", "''");
                    string achternaam = f.Achternaam.Replace("'", "''");
                    string adres = f.Adres.Replace("'", "''");
                    string huisnummer = f.Huisnummer.Replace("'", "''");
                    string postcode = f.Postcode.Replace("'", "''");
                    string plaats = f.Plaats.Replace("'", "''");
                    string telefoon = f.Telefoon.Replace("'", "''");

                    connect.ExecuteQuery(
                        $"INSERT INTO patient_info (voornaam, Acternaam, Adres, Huisnummer, Postcode, Plaats, telefoonnummer) " +
                        $"VALUES ('{voornaam}', '{achternaam}', '{adres}', '{huisnummer}', '{postcode}', '{plaats}', '{telefoon}')");

                    pagia = 1;
                    LaadPatienten();
                }
            };
            f.Show();
        }

        private void notatiebtn_Click(object sender, EventArgs e)
        {
            if (Patienten_dtg.CurrentRow == null)
            {
                MessageBox.Show("Selecteer eerst een patiënt.");
                return;
            }

            DataGridViewRow rij = Patienten_dtg.CurrentRow;

            int id = Convert.ToInt32(rij.Cells["Id"].Value);
            string naam = rij.Cells["voornaam"].Value + " " + rij.Cells["Acternaam"].Value;
            string adres = rij.Cells["Adres"].Value + " " + rij.Cells["Huisnummer"].Value;
            string postcode = rij.Cells["Postcode"].Value + " " + rij.Cells["Plaats"].Value;
            string telefoon = rij.Cells["telefoonnummer"].Value.ToString();

            // De notitie staat niet in de tabel, dus even apart ophalen
            DataTable dt = connect.ExecuteQuery("SELECT Note FROM patient_info WHERE Id = " + id);
            string notitie = dt.Rows[0]["Note"].ToString();

            Notietie f = new Notietie(id, naam, adres, postcode, telefoon, notitie);

            f.FormClosed += (s, args) =>
            {
                if (f.DialogResult == DialogResult.OK)
                {
                    string nieuw = f.Notitie.Replace("'", "''");
                    connect.ExecuteQuery("UPDATE patient_info SET Note = '" + nieuw + "' WHERE Id = " + id);
                }
            };

            f.Show();
        }

        private void Bewerkenbtn_Click(object sender, EventArgs e)
        {
            if (Patienten_dtg.CurrentRow == null)
            {
                MessageBox.Show("Selecteer eerst een patiënt.");
                return;
            }

            DataGridViewRow rij = Patienten_dtg.CurrentRow;
            int id = Convert.ToInt32(rij.Cells["Id"].Value);

            Bewerken f = new Bewerken();
            f.ToonPatient(
                id,
                rij.Cells["voornaam"].Value.ToString(),
                rij.Cells["Acternaam"].Value.ToString(),
                rij.Cells["Adres"].Value.ToString(),
                rij.Cells["Huisnummer"].Value.ToString(),
                rij.Cells["Postcode"].Value.ToString(),
                rij.Cells["Plaats"].Value.ToString(),
                rij.Cells["telefoonnummer"].Value.ToString());

            f.FormClosed += (s, args) =>
            {
                if (f.DialogResult != DialogResult.OK) return;

                if (f.Verwijderen)
                {
                    connect.ExecuteQuery("DELETE FROM patient_info WHERE Id = " + id);
                }
                else
                {
                    string voornaam = f.Voornaam.Replace("'", "''");
                    string achternaam = f.Achternaam.Replace("'", "''");
                    string adres = f.Adres.Replace("'", "''");
                    string huisnummer = f.Huisnummer.Replace("'", "''");
                    string postcode = f.Postcode.Replace("'", "''");
                    string plaats = f.Plaats.Replace("'", "''");
                    string telefoon = f.Telefoon.Replace("'", "''");

                    connect.ExecuteQuery(
                        "UPDATE patient_info SET voornaam = '" + voornaam + "', Acternaam = '" + achternaam +
                        "', Adres = '" + adres + "', Huisnummer = '" + huisnummer +
                        "', Postcode = '" + postcode + "', Plaats = '" + plaats +
                        "', telefoonnummer = '" + telefoon + "' WHERE Id = " + id);
                }
                LaadPatienten();
            };

            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clears the datagrid vieuw
            LaadPatienten();
        }

        private void terugbtn_Click(object sender, EventArgs e)
        {
            pagia--;
            LaadPatienten();
        }

        private void volgbtn_Click(object sender, EventArgs e)
        {
            pagia++;
            LaadPatienten();
        }
    }
}