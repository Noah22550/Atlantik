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
    public partial class AjoutTarifLiaisonPeriode : Form
    {
        public AjoutTarifLiaisonPeriode()
        {
            InitializeComponent();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                MaCo.Open();


                string requeteSecteur = "SELECT nosecteur, nom FROM secteur";
                MySqlCommand cmdSecteur = new MySqlCommand(requeteSecteur, MaCo);
                MySqlDataReader readerSecteur = cmdSecteur.ExecuteReader();

                while (readerSecteur.Read())
                {

                    Secteur secteur = new Secteur((int)readerSecteur["nosecteur"], readerSecteur["nom"].ToString());
                    lbxSecteur.Items.Add(secteur);
                }

                readerSecteur.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                MaCo.Close();

            }

            try
            {
                MaCo.Open();
                string requete = "SELECT notype, libelle, lettrecategorie FROM type";
                MySqlCommand cmd = new MySqlCommand(requete, MaCo);
                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 20;

                while (reader.Read())
                {
                    int noType = Convert.ToInt32(reader["notype"]);
                    string libelle = reader["libelle"].ToString();
                    string lettre = reader["lettrecategorie"].ToString();

                    // Label pour notype
                    Label lblNoType = new Label();
                    lblNoType.Text = noType.ToString();
                    lblNoType.Location = new Point(10, y);
                    lblNoType.AutoSize = true;

                    // Label pour libelle
                    Label lblLibelle = new Label();
                    lblLibelle.Text = libelle;
                    lblLibelle.Location = new Point(50, y);
                    lblLibelle.AutoSize = true;

                    // Label pour lettre catégorie
                    Label lblLettre = new Label();
                    lblLettre.Text = lettre;
                    lblLettre.Location = new Point(20, y);
                    lblLettre.AutoSize = true;

                    TextBox txt = new TextBox();
                    txt.Location = new Point(200, y - 3);
                    txt.Width = 100;

                    // Ajout dans le GroupBox
                    gbxTarifs.Controls.Add(lblLettre);
                    gbxTarifs.Controls.Add(lblNoType);
                    gbxTarifs.Controls.Add(lblLibelle);
                    gbxTarifs.Controls.Add(txt);

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

        private void gbxTarifs_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
