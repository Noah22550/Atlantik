using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;";
            maCo = new MySqlConnection(CHAINECONNEXION);
            object nomSecteur = tbxadd.Text;
            try
            {
                maCo.Open();

                string requete = "INSERT INTO secteur(nom) VALUES (@nom)";
                MySqlCommand maCde = new MySqlCommand(requete, maCo);
                maCde.Parameters.AddWithValue("@nom", nomSecteur);
                int nb = maCde.ExecuteNonQuery();
                MessageBox.Show("Secteur ajouté !");
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
    }
}
