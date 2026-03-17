using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetAtlantik
{
    public partial class AjoutLiaison : Form
    {
        public AjoutLiaison()
        {
            InitializeComponent();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                MaCo.Open();

                string requetePort = "SELECT noport, nom FROM port";
                MySqlCommand cmdPort = new MySqlCommand(requetePort, MaCo);
                MySqlDataReader JeuEnrPort = cmdPort.ExecuteReader();

                while (JeuEnrPort.Read())
                {
                    Port port = new Port((int)JeuEnrPort["noport"], JeuEnrPort["nom"].ToString());
                    cmbdepart.Items.Add(port);
                    cmbArrive.Items.Add(port);
                }

                JeuEnrPort.Close();
               
                string requeteSecteur = "SELECT nosecteur, nom FROM secteur";
                MySqlCommand cmdSecteur = new MySqlCommand(requeteSecteur, MaCo);
                MySqlDataReader JeuEnrSecteur = cmdSecteur.ExecuteReader();

                while (JeuEnrSecteur.Read())
                {

                    Secteur secteur = new Secteur((int)JeuEnrSecteur["nosecteur"], JeuEnrSecteur["nom"].ToString());
                    lbxliaison.Items.Add(secteur);
                }

                JeuEnrSecteur.Close();
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

        private void AjoutLiaison_Load(object sender, EventArgs e)
        {
        }

        private void btnAddLiaison_Click(object sender, EventArgs e)
        {

            MySqlConnection maCo;
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;";
            maCo = new MySqlConnection(CHAINECONNEXION);
            if (cmbdepart.SelectedItem == null || cmbArrive.SelectedItem == null || lbxliaison.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un port de départ, d'arrivée et une liaison");
                return;
            }
            else
            {
                Secteur secteur = (Secteur)lbxliaison.SelectedItem;
                int idSecteur = secteur.GetNosecteur();
                Port depart = (Port)cmbdepart.SelectedItem;
                Port arrive = (Port)cmbArrive.SelectedItem;

                int idDepart = depart.GetNoport();
                int idArrive = arrive.GetNoport();

                int distance = int.Parse(tbxAddDIstance.Text);

                try
                {
                    maCo.Open();

                    if (depart == arrive)
                    {
                        MessageBox.Show("Impossible de créer une liaison avec le même port");
                    }
                    string requete = "INSERT INTO liaison(noport_depart, nosecteur, noport_arrivee, distance) VALUES (@noport_depart, @nosecteur, @noport_arrivee, @distance)";
                    MySqlCommand maCde = new MySqlCommand(requete, maCo);
                    maCde.Parameters.AddWithValue("@noport_depart", idDepart);
                    maCde.Parameters.AddWithValue("@nosecteur", idSecteur);
                    maCde.Parameters.AddWithValue("@noport_arrivee", idArrive);
                    maCde.Parameters.AddWithValue("@distance", distance);
                    maCde.ExecuteNonQuery();

                    MessageBox.Show("Liaison ajoutée !");
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

        }

        private void cmbdepart_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbArrive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxliaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*$");
            var résultatTest = objetRegEx.Match(tbxAddDIstance.Text);
            if (!résultatTest.Success)
            {
                tbxAddDIstance.BackColor = Color.Red;
                e.Cancel = true;
                errorProvider1.SetError(tbxAddDIstance, "Saisir des nombres !! ");
            }
            else
            {
                tbxAddDIstance.BackColor = Color.Green;
                errorProvider1.Clear();
            }
        }
    }
}
