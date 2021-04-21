using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleLogin
{
    public partial class Admin : Form
    {
        public Admin(String NiveauUtilisateur, String UserName)
        {
            InitializeComponent();
            labelUsername.Text = UserName;
         
            //On remplit la liste des utilisateurs, à lier avec la Table Users
            if (dataGridUsers.Columns.Count == 0)
            {
                dataGridUsers.Columns.Add("id", "id");//Nom colonne,titre
                dataGridUsers.Columns.Add("prenom", "Prénom");//Nom colonne,titre
                dataGridUsers.Columns.Add("nom", "Nom");//Nom colonne,titre
            }
            //MaDataGrid.Rows.Add(tbPrenom.Text, tbNom.Text);
            dataGridUsers.Rows.Add("128", "Giscard", "Nasalan");
            dataGridUsers.Rows.Add("256", "Aurélien", "Sanchez");
            dataGridUsers.Columns["id"].Visible = false;
        }

        private void New()
        {
            //On interroge la base et ensuite on rafraichit la liste des utilisateurs
            //1 on vide la liste courante
            //dataGridUsers.ClearSelection();
            //2 REquete SQL
            //On remplit de nouveau la liste
            MessageBox.Show("Il faut frafrîchir la liste à cet endroit");
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Utilisateur MonFormUtilisateur = new Utilisateur();//instancier le form de login

            MonFormUtilisateur.ShowDialog();//pour ouvrir le formulaire comme une modale
            if (MonFormUtilisateur.DialogResult == DialogResult.OK)//l'utilisateur a été enregistré
            {
                MonFormUtilisateur.Close();
                dataGridUsers.Rows.Add(MonFormUtilisateur.StrPrenomtilisateur, MonFormUtilisateur.StrNomUtilisateur);
            }
            else
                MonFormUtilisateur.Close();
        }

        private void button4_Click(object sender, EventArgs e) //Suppression des utilisateurs
        {
            foreach (DataGridViewRow row in dataGridUsers.SelectedRows)
            {
                dataGridUsers.Rows.RemoveAt(row.Index);
                //on n'oublie pas de supprimer dans la bdd
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridUsers.SelectedRows)
            {
              string idDemande= dataGridUsers.Rows[row.Index].Cells[0].Value.ToString();
                Utilisateur MonFormUtilisateur = new Utilisateur(idDemande);//instancier le form de login
                     MonFormUtilisateur.ShowDialog();//pour ouvrir le formulaire comme une modale
                if (MonFormUtilisateur.DialogResult == DialogResult.OK)//l'utilisateur a été enregistré
                {//il va falloir rafraichir la liste
                    MonFormUtilisateur.Close();
                    Refresh();
                   }
                else
                    MonFormUtilisateur.Close();

            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
