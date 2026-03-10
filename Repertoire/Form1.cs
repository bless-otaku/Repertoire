namespace Repertoire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMsg.Text = "Veuillez remplir les champs";
            labelName.Text = "Nom";
            labelPhone.Text = "Phone Number";
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                labelMsg.Text = "l'un de champ est vide";
                labelMsg.ForeColor = Color.Red;
            }
            else
            {
                labelMsg.Text = "";
                string path = "contact.txt";
                if (! File.Exists(path)) // ca verifie si le fichier n'existe pas 
                {
                    // Alors nous creons un nouveau fichier
                } else
                {
                    // ajouter le nouvelles donnees aux fichier 
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
