namespace Huisarts_Notatie
{
    public partial class Notietie : Form
    {
        public Notietie()
        {
            InitializeComponent();
        }
        public string Notitie;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Notietie(int id, string naam, string adres, string postcode, string telefoon, string notitie)
        {
            InitializeComponent();

            IDlbl.Text = id.ToString();
            Voornaamlbl.Text = naam;
            adreslbl.Text = adres;
            Poscodelbl.Text = postcode;
            Tellbl.Text = telefoon;
            richTextBox1.Text = notitie;
        }

        private void Opslaanbtn_Click(object sender, EventArgs e) 
        {
            Notitie = richTextBox1.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void terugbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
