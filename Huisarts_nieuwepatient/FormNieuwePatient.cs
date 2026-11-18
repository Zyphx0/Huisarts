namespace Huisarts_nieuwepatient
{
    public partial class FormNieuwePatient : Form
    {
        public string Voornaam, Achternaam, Adres, Huisnummer, Postcode, Plaats, Telefoon;

        public FormNieuwePatient()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
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

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
