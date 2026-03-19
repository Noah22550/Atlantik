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
            MySqlConnection maCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                maCo.Open();

                string requetePort = "SELECT noport, nom FROM port";
                MySqlCommand cmdPort = new MySqlCommand(requetePort, maCo);
                MySqlDataReader jeuEnrPort = cmdPort.ExecuteReader();

                while (jeuEnrPort.Read())
                {
                    Port port = new Port((int)jeuEnrPort["noport"], jeuEnrPort["nom"].ToString());
                    cmbdepart.Items.Add(port);
                    cmbArrive.Items.Add(port);
                }

                jeuEnrPort.Close();

                string requeteSecteur = "SELECT nosecteur, nom FROM secteur";
                MySqlCommand cmdSecteur = new MySqlCommand(requeteSecteur, maCo);
                MySqlDataReader jeuEnrSecteur = cmdSecteur.ExecuteReader();

                while (jeuEnrSecteur.Read())
                {
                    Secteur secteur = new Secteur((int)jeuEnrSecteur["nosecteur"], jeuEnrSecteur["nom"].ToString());
                    lbxliaison.Items.Add(secteur);
                }

                jeuEnrSecteur.Close();
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

        private void AjoutLiaison_Load(object sender, EventArgs e)
        {
        }

        private void btnAddLiaison_Click(object sender, EventArgs e)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

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
                        return;
                    }

                    string requete = "INSERT INTO liaison(noport_depart, nosecteur, noport_arrivee, distance) " +
                                     "VALUES (@noport_depart, @nosecteur, @noport_arrivee, @distance)";
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
            var regex = new Regex("^[0-9]*$");
            var resultatTest = regex.Match(tbxAddDIstance.Text);

            if (!resultatTest.Success)
            {
                tbxAddDIstance.BackColor = Color.Red;
                e.Cancel = true;
                errorProvider1.SetError(tbxAddDIstance, "Saisir des nombres !");
            }
            else
            {
                tbxAddDIstance.BackColor = Color.Green;
                errorProvider1.Clear();
            }
        }
    }
}