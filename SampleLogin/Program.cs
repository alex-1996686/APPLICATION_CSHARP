using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleLogin
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login MonFormLogin = new Login();//instancier le form de login
           
            MonFormLogin.ShowDialog();//pour ouvrir le formulaire comme une modale
            if (MonFormLogin.DialogResult == DialogResult.OK)//l'utilisateur peut se connecte
            {
                //On récupére les infos de l'utilisateur : ID, nom, niveau
                String NiveauUtilisateur = MonFormLogin.StrLevel;
                String LeNomutilisateur = MonFormLogin.NomUtilisateur;
                MonFormLogin.Close();//On ferme le login
                Application.Run(new Admin(NiveauUtilisateur,LeNomutilisateur));//Lancer l'écran métier
                //En foncton du niveau d'utilisateur, on ouvre un écran ou un autre
            }
            else
                MonFormLogin.Close();
            MessageBox.Show("Au revoir");
            }
        }
    }

