using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetAtlantik
{
    public partial class AjoutPort : Form
    {
        public AjoutPort()
        {
            InitializeComponent();
        }

        private void btnaddport_Click(object sender, EventArgs e)
        {
            MySqlConnection maCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            object nomPort = tbxAjoutPort.Text;
            try
            {
                maCo.Open();

               
                if (tbxAjoutPort == null )
                {
                    MessageBox.Show("Veuillez remplir le champ du nom du port ");
                }
                else
                {
                    string requete = "INSERT INTO port(nom) VALUES (@nom)";
                    MySqlCommand maCde = new MySqlCommand(requete, maCo);
                    maCde.Parameters.AddWithValue("@nom", nomPort);
                    int nb = maCde.ExecuteNonQuery();
                    MessageBox.Show("Port ajouté !");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                maCo.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxAjoutPort.Text);

            if (!resultatTest.Success)
            {
                tbxAjoutPort.BackColor = Color.Red;
            }
            else
            {
                tbxAjoutPort.BackColor = Color.White;
            }

        }
        

        private void AjoutPort_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var résultatTest = objetRegEx.Match(tbxAjoutPort.Text);
            if (!résultatTest.Success)
            {
                // KO : Fond de la zone de saisie passe en rouge
                tbxAjoutPort.BackColor = Color.Red;
                e.Cancel = true;
                errorProvider1.SetError(tbxAjoutPort, "Saisir des charactère  !! ");
            }
            else
            {
                // OK : Fond de la zone de saisie passe en vert
                tbxAjoutPort.BackColor = Color.Green;
                errorProvider1.Clear();
            }
        }
    }
}
