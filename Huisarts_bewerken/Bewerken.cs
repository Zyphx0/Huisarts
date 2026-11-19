namespace Huisarts_bewerken
{
    public partial class Bewerken : Form
    {
        public Bewerken()
        {
            InitializeComponent();
        }
        public int PatientId;
        public string Voornaam, Achternaam, Adres, Huisnummer, Postcode, Plaats, Telefoon;
        public bool Verwijderen = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ToonPatient(int id, string voornaam, string achternaam, string adres,
                        string huisnummer, string postcode, string plaats, string telefoon)
        {
            PatientId = id;
            Idlbl.Text = "ID: " + id;
            txtVoornaam.Text = voornaam;
            txtAchternaam.Text = achternaam;
            txtAdres.Text = adres;
            txtHuisnummer.Text = huisnummer;
            txtPostcode.Text = postcode;
            txtPlaats.Text = plaats;
            txtTelefoon.Text = telefoon;
        }
        private void Opslaanbtn_Click(object sender, EventArgs e)
        {
            if (txtVoornaam.Text.Trim() == "" || txtAchternaam.Text.Trim() == "" ||
                txtAdres.Text.Trim() == "" || txtHuisnummer.Text.Trim() == "" ||
                txtPostcode.Text.Trim() == "" || txtPlaats.Text.Trim() == "" ||
                txtTelefoon.Text.Trim() == "")
            {
                MessageBox.Show("Vul alle velden in.");
                return;
            }

            Voornaam = txtVoornaam.Text.Trim();
            Achternaam = txtAchternaam.Text.Trim();
            Adres = txtAdres.Text.Trim();
            Huisnummer = txtHuisnummer.Text.Trim();
            Postcode = txtPostcode.Text.Trim();
            Plaats = txtPlaats.Text.Trim();
            Telefoon = txtTelefoon.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }
        private void verwijderen_Click(object sender, EventArgs e)
        {
            DialogResult antwoord = MessageBox.Show(
                "Weet je zeker dat je deze patiënt wilt verwijderen?\nDit kan niet ongedaan worden gemaakt.",
                "Patiënt verwijderen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (antwoord == DialogResult.Yes)
            {
                Verwijderen = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            // Bij Nee blijf je gewoon in het bewerkscherm
        }
        private void anullerbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
