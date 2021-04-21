using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace SampleLogin
{

    public partial class Login : Form
    {

        string _connectionString = "server=127.0.0.1; user id = root; persistsecurityinfo=True; database=ppeVilliers";

        public String StrLevel = "Inconnu";
        public String NomUtilisateur = "Inconnu";
        public Login()
        {

            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("UN CHAMP EST VIDE !!!!");
                return;
            }

            try
            {

                string idu = "";
                string username = "";
                string pass = "";
                string role = "";

                MySqlConnection conn = new MySqlConnection(_connectionString);

                conn.Open();

                username = textBox1.Text;
                pass = textBox2.Text;

                string sql = $"SELECT idu, username, role FROM users WHERE username = '{username}' AND pass = '{pass}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        idu = rdr[0].ToString();
                        username = rdr[1].ToString();
                        role = rdr[2].ToString();

                        if (role == "1")
                        {
                            StrLevel = role;
                            NomUtilisateur = username;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Vous n'avez pas la permissons d'accéder !");
                        }

                    }
                }
                else MessageBox.Show("Identifiants incorrects");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e) // bouton annuler
        {
            this.DialogResult = DialogResult.Cancel; // Modale est validée par Annuler
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
