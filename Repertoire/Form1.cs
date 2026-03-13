using System.Diagnostics;

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

            // Configurer le ListView
            listViewContacts.View = View.Details;
            listViewContacts.Columns.Add("Nom", 150);
            listViewContacts.Columns.Add("Téléphone", 150);

            // Charger les contacts existants
            LoadContactsToListView();
        }

        private void LoadContactsToListView()
        {
            string path = "contact.csv";

            listViewContacts.Items.Clear(); // vider l'ancien contenu

            if (!File.Exists(path))
                return; // rien à afficher si le fichier n'existe pas

            string[] lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++) // on saute la première ligne (en-tête)
            {
                string[] parts = lines[i].Split(',');

                if (parts.Length >= 2) // Nom et Téléphone
                {
                    ListViewItem item = new ListViewItem(parts[0]);  // Nom
                    item.SubItems.Add(parts[1]);                     // Téléphone
                    listViewContacts.Items.Add(item);
                }
            }
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
                // Après avoir ajouté le contact au CSV
                LoadContactsToListView();
            }
            catch (Exception ex)
            {
                labelMsg.Text = "Erreur lors de l'écriture du fichier : " + ex.Message;
                labelMsg.ForeColor = Color.Red;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //verifier si un element est bien selectionne dans le listview
            if (listViewContacts.SelectedItems.Count > 0) {
                // Supprimer du ListView
                foreach (ListViewItem item in listViewContacts.SelectedItems) {
                    listViewContacts.Items.Remove(item);
                }

                List<string> lignes = new List<string>();

                // Ajouter l'en-tête du CSV
                lignes.Add("Name,Phone");

                // Reconstruire le fichier CSV
                foreach (ListViewItem item in listViewContacts.Items)
                {
                    string ligne = item.Text + "," + item.SubItems[1].Text;
                    lignes.Add(ligne);
                }

                    File.WriteAllLines("contact.csv", lignes);

                    MessageBox.Show("Contact supprimé !");
            } else {
                MessageBox.Show("Veuillez sélectionner un contact à supprimer.");
            }                    
        }
    }
}            
        
    

