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
    public partial class AjoutPort : Form
    {
        public AjoutPort()
        {
            InitializeComponent();
        }

        private void btnaddport_Click(object sender, EventArgs e)
        {
            MySqlConnection maCo;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;";
            maCo = new MySqlConnection(CHAINECONNEXION);
            object nomPort = textBox1.Text;
            try
            {
                maCo.Open();

                string requete = "INSERT INTO port(nom) VALUES (@nom)";
                MySqlCommand maCde = new MySqlCommand(requete, maCo);
                maCde.Parameters.AddWithValue("@nom", nomPort);
                int nb = maCde.ExecuteNonQuery();
                MessageBox.Show("Port ajouté !");
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

        }
    }
}
