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
        // Vérifier que les champs ne sont pas vides
        if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text))
        {
            labelMsg.Text = "L'un des champs est vide !";
            labelMsg.ForeColor = Color.Red;
            return; // arrêter l'exécution
        }

        string path = "contact.csv";
        bool fileJustCreated = false; // pour savoir si on a créé le fichier

        try
        {
            // Vérifier si le fichier existe
            if (!File.Exists(path))
            {
                // Créer le fichier et ajouter les en-têtes
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Name,Phone");
                    sw.WriteLine($"{txtName.Text},{txtPhone.Text}");
                }
                fileJustCreated = true;
            }
            else
            {
                // Ajouter les nouvelles données
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"{txtName.Text},{txtPhone.Text}");
                }
            }

            // Mettre à jour le labelMsg pour informer l'utilisateur
            if (fileJustCreated)
            {
                labelMsg.Text = "Fichier créé et contact ajouté !";
            }
            else
            {
                labelMsg.Text = "Contact ajouté au fichier existant !";
            }
            labelMsg.ForeColor = Color.Green;

            // Optionnel : effacer les champs pour le prochain contact
            txtName.Text = "";
            txtPhone.Text = "";
        }
        catch (Exception ex)
        {
            labelMsg.Text = "Erreur lors de l'écriture du fichier : " + ex.Message;
            labelMsg.ForeColor = Color.Red;
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
