using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class AfficherReservationClients : Form
    {
        public AfficherReservationClients()
        {
            InitializeComponent();
            lvAfficherRes.View = View.Details;
            lvAfficherRes.GridLines = true;
            lvAfficherRes.FullRowSelect = true;

            lvAfficherRes.Columns.Add("Reservation", 120);
            lvAfficherRes.Columns.Add("Liaison", 120);
            lvAfficherRes.Columns.Add("Traversée", 120);
            lvAfficherRes.Columns.Add("Date départ", 150);
        }

        private void lvAfficherRes_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");

            try
            {
                int noReservation = Convert.ToInt32(lvAfficherRes.SelectedItems[0].Text);

                MaCo.Open();

                string req = "SELECT c.libelle, e.quantitereservee " +
                             "FROM enregistrer e " +
                             "JOIN categorie c ON e.lettrecategorie = c.lettrecategorie " +
                             "WHERE e.noreservation = @noReservation";

                MySqlCommand cmd = new MySqlCommand(req, MaCo);
                cmd.Parameters.AddWithValue("@noReservation", noReservation);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string categorie = reader["libelle"].ToString();
                    int quantite = Convert.ToInt32(reader["quantitereservee"]);

                    if (categorie.Contains("Adulte"))
                        lblAdulte.Text = quantite.ToString();

                    if (categorie.Contains("Junior"))
                        lblJunior.Text = quantite.ToString();

                    if (categorie.Contains("Enfant"))
                        lblEnfant.Text = quantite.ToString();

                    if (categorie.Contains("Voiture"))
                        lblVoiture.Text = quantite.ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MaCo.Close();
            }
        }

        private void gbxAfficher_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");

            try
            {
                lvAfficherRes.Items.Clear();

                Client c = (Client)comboBox1.SelectedItem;
                int noClient = c.GetNoClient();

                MaCo.Open();

                string req = "SELECT noReservation, t.noTraversee, dateHeureDepart " +
                             "FROM reservation r " +
                             "JOIN traversee t ON r.noTraversee = t.noTraversee " +
                             "WHERE r.noClient = @noClient";

                MySqlCommand cmd = new MySqlCommand(req, MaCo);
                cmd.Parameters.AddWithValue("@noClient", noClient);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem ligne = new ListViewItem(reader["noReservation"].ToString());

                    ligne.SubItems.Add(reader["noTraversee"].ToString());
                    ligne.SubItems.Add(Convert.ToDateTime(reader["dateHeureDepart"]).ToString());

                    lvAfficherRes.Items.Add(ligne);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MaCo.Close();
            }
        }

        private void AfficherReservationClients_Load(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");

            try
            {
                MaCo.Open();

                string req = "SELECT noClient, nom, prenom FROM client";
                MySqlCommand cmd = new MySqlCommand(req, MaCo);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Client c = new Client(
                        Convert.ToInt32(reader["noClient"]),
                        reader["nom"].ToString(),
                        reader["prenom"].ToString()
                    );

                    comboBox1.Items.Add(c);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MaCo.Close();
            }
        }
    }
}
