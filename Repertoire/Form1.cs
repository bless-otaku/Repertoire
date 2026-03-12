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
                // Valider que les champs ne sont pas vides et ont une valeur valide
                labelMsg.Text = "l'un de champ est vide";
                labelMsg.ForeColor = Color.Blue;
            }
            else
            {
                labelMsg.Text = "";
                // Nous allons enregistrer les donnees dans un fichier csv
                string path = "contact.csv";
                // Verifier si le fichier existe ou pas
                if (! File.Exists(path)) // ca verifie si le fichier n'existe pas 
                {
                    // Alors nous creons un nouveau fichier
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine("Name,Phone"); // ecrire les en-tetes du fichier csv
                        sw.WriteLine($"{txtName.Text},{txtPhone.Text}"); // ecrire les donnees dans le fichier csv
                    }
                } else
                {                     // ajouter le nouvelles donnees aux fichier 
                    using (StreamWriter sw = new StreamWriter(path, true)) // le parametre true permet d'ajouter les nouvelles donnees a la fin du fichier au lieu de remplacer les anciennes donnees
                    {
                        sw.WriteLine($"{txtName.Text},{txtPhone.Text}"); // ecrire les donnees dans le fichier csv
                    }
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
