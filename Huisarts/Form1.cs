using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Huisarts_nieuwepatient;

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
            //lblPagina.Text = "Pagina " + pagina + " van " + aantalPaginas + " (" + totaal + " patiënten)";
            //btnVorige.Enabled = pagina > 1;
            //btnVolgende.Enabled = pagina < aantalPaginas;
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
            f.ShowDialog();
            if (f.ShowDialog() == DialogResult.OK)
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
        }
    }
}
