namespace Huisarts_nieuwepatient
{
    public partial class FormNieuwePatient : Form
    {
        public string Voornaam { get { return textBox1.Text.Trim(); } }
        public string Achternaam { get { return textBox2.Text.Trim(); } }
        public string Adres { get { return textBox3.Text.Trim(); } }
        public string Huisnummer { get { return textBox4.Text.Trim(); } }
        public string Postcode { get { return textBox5.Text.Trim(); } }
        public string Plaats { get { return textBox6.Text.Trim(); } }
        public string Telefoon { get { return textBox7.Text.Trim(); } }

        public FormNieuwePatient()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (Voornaam == "" || Achternaam == "" || Adres == "" || Huisnummer == "" ||
                Postcode == "" || Plaats == "" || Telefoon == "")
            {
                MessageBox.Show("Vul alle velden in.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
