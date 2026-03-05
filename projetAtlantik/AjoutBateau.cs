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
    public partial class AjoutBateau : Form
    {
        public AjoutBateau()
        {
            InitializeComponent();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            //AFFICHAGE DYNAMIQUE
            try
            {
                MaCo.Open();
                string requete = "SELECT * FROM categorie";
                MySqlCommand cmd = new MySqlCommand(requete, MaCo);
                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 20;

                while (reader.Read())
                {
                    string lettre = reader["LETTRECATEGORIE"].ToString();
                    string libelle = reader["LIBELLE"].ToString();
                    // Label pour notype
                    Label lblNoType = new Label();
                    lblNoType.Text = lettre.ToString() + " - " + libelle;
                    lblNoType.Location = new Point(10, y);
                    //lblNoType.AutoSize = true;

                    TextBox txt = new TextBox();
                    txt.Location = new Point(200, y - 3);
                    //txt.Tag = lblType.GetNoType() + ":" + lblType.GetLettre();
                    txt.Width = 100;

                    // Ajout dans le GroupBox
                    groupBox1_Enter.Controls.Add(lblNoType);
                    groupBox1_Enter.Controls.Add(txt);

                    y += 30;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                MaCo.Close();
            }
        }

        private void tbxAddBoat_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
