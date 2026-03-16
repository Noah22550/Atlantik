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
    public partial class AjoutSecteur : Form
    {
        public AjoutSecteur()
        {
            InitializeComponent();
        }

        private void tbxadd_TextChanged(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî]*$");
            var resultatTest = objetRegEx.Match(tbxadd.Text);

            if (!resultatTest.Success)
            {
                tbxadd.BackColor = Color.Red;
            }
            else
            {
                tbxadd.BackColor = Color.White;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            MySqlConnection maCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            object nomSecteur = tbxadd.Text;
            try
            {
                maCo.Open();
                if (tbxadd.BackColor == Color.Red)
                {
                    MessageBox.Show("Saisie incorrecte");
                    return;
                }
                else
                {
                    string requete = "INSERT INTO secteur(nom) VALUES (@nom)";
                    MySqlCommand maCde = new MySqlCommand(requete, maCo);
                    maCde.Parameters.AddWithValue("@nom", nomSecteur);
                    int nb = maCde.ExecuteNonQuery();
                    MessageBox.Show("Secteur ajouté !");
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

        private void lbladd_Click(object sender, EventArgs e)
        {

        }

        private void AjoutSecteur_Load(object sender, EventArgs e)
        {

        }

        private void tbxadd_Validating(object sender, CancelEventArgs e)
        {
            // sender = objet sur lequel l'évènement a été déclenché (ici tbxNote)

            // particulièrement utile avec collection de Controls.



            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var résultatTest = objetRegEx.Match(tbxadd.Text);
            if (!résultatTest.Success)
            {
                // KO : Fond de la zone de saisie passe en rouge
                tbxadd.BackColor = Color.Red;
                e.Cancel = true;
                errorProvider1.SetError(tbxadd, "Saisir des charactère  !! ");
            }
            else
            {
                // OK : Fond de la zone de saisie passe en vert
                tbxadd.BackColor = Color.Green;
                errorProvider1.Clear();
            }
        }
    }
}
