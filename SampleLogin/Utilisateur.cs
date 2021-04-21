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
    public partial class Utilisateur : Form
    {
        public String StrNomUtilisateur = "";
        public String StrPrenomtilisateur = "";
        public Utilisateur()
        {
            InitializeComponent();
              
        }
        public Utilisateur(String IdUtilisateur)
        {
            InitializeComponent();
            tbID.Text = IdUtilisateur;
            //Ici il faut une requete utilisateur pour récupérer toutes les infos de l'utilsateur
            //On valorise les textbox
        }
        private void Utilisateur_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.StrNomUtilisateur = Tbnom.Text;
            this.StrPrenomtilisateur = tbprenom.Text;
            ///On n'oublie pas de mettre à jour la bdd
            this.DialogResult = DialogResult.OK;//Modale est validée par OK

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;//Modale est validée par aannuler
        }
    }
}
