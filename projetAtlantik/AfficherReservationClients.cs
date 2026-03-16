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

        }

        private void lvAfficherRes_SelectedIndexChanged(object sender, EventArgs e)
        {


            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            gbxAfficher.Controls.Clear();
            string noRes = lvAfficherRes.SelectedItems[0].Text;
            try
            {
                maCnx.Open();
                string req = "SELECT * from enregistrer e " +
                            "inner join type t on e.NOTYPE = t.NOTYPE " +
                            "inner join reservation r on  e.NORESERVATION = r.NORESERVATION " +
                            "where t.LETTRECATEGORIE= e.LETTRECATEGORIE and e.NOTYPE = t.NOTYPE " +
                            "and e.NORESERVATION = @noRes";

                MySqlCommand cmd = new MySqlCommand(req, maCnx);
                cmd.Parameters.AddWithValue("@noRes", noRes);
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                double montant = 0;

                while (reader.Read())
                {
                    // Affichage dynamique de chaque catégorie
                    Label lbl = new Label();
                    lbl.Text = reader["LIBELLE"].ToString() + ": " + reader["QUANTITERESERVEE"].ToString();
                    lbl.Location = new Point(15, 25 * i);
                    lbl.AutoSize = true;
                    gbxAfficher.Controls.Add(lbl);

                        montant = Convert.ToDouble(reader["MONTANTTOTAL"]);
                    i++;
                }

                // Montant total
                Label lblMontant = new Label();
                lblMontant.Text = "Montant total: " + montant + "€";
                lblMontant.Location = new Point(15, 25 * i);
                lblMontant.AutoSize = true;
                gbxAfficher.Controls.Add(lblMontant);
                i++;

                // Mode de paiement
                Label lblReg = new Label();
                lblReg.Text = "Réglé par Carte Bancaire" ;
                lblReg.Location = new Point(15, 25 * i);
                lblReg.AutoSize = true;
                gbxAfficher.Controls.Add(lblReg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                maCnx.Close();
            }
        }



        private void gbxAfficher_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvAfficherRes.FullRowSelect = true;
            lvAfficherRes.GridLines = true;
            lvAfficherRes.Items.Clear();
            lvAfficherRes.Columns.Clear();
            lvAfficherRes.View = View.Details;
            lvAfficherRes.Columns.Add("N° Reservation", 100);
            lvAfficherRes.Columns.Add("Liaison", 150);
            lvAfficherRes.Columns.Add("N° Traversée", 80);
            lvAfficherRes.Columns.Add("Date Départ", 120);

            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requête = "select NORESERVATION, reservation.NOTRAVERSEE, DATEHEURE from reservation inner join traversee on reservation.NOTRAVERSEE = traversee.NOTRAVERSEE inner join liaison on traversee.NOLIAISON = liaison.NOLIAISON inner join client on reservation.NOCLIENT = client.NOCLIENT where client.noclient = 1";

                var maCde = new MySqlCommand(requête, maCnx);


                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    string noreservation = jeuEnr["NORESERVATION"].ToString();
                    string notraversee = jeuEnr["NOTRAVERSEE"].ToString();
                    string liaison = GetLiaison(notraversee);
                    string dateheure = ((DateTime)jeuEnr["DATEHEURE"]).ToString("dd/MM/yyyy à HH:mm");

                    ListViewItem position = new ListViewItem(noreservation);
                    position.SubItems.Add(liaison);
                    position.SubItems.Add(notraversee);
                    position.SubItems.Add(dateheure);
                    lvAfficherRes.Items.Add(position);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte

                }
            }
        }
        private string GetLiaison(string noTraversee)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;

            try
            {
                maCnx.Open();
                string requete = "select p1.nom as 'nomport_depart', p2.nom as 'nomport_arrivee', li.noliaison from liaison li inner join port p1 on li.NOPORT_DEPART = p1.noport inner join port p2 on li.NOPORT_ARRIVEE = p2.noport inner join traversee on traversee.NOLIAISON = li.NOLIAISON where traversee.notraversee = @notraversee";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noTraversee", noTraversee);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Liaison p = new Liaison((string)jeuEnr["nomport_depart"], (string)jeuEnr["nomport_arrivee"], (int)jeuEnr["noliaison"]);
                    return p.ToString();
                }
                return "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
                return "";
            }
            finally
            {
                    maCnx.Close();
            }
        }
        private void AfficherReservationClients_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            maCnx.Open();
            try
            {
                string requête = "select * from client";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Client c = new Client((int)jeuEnr["noclient"], (string)jeuEnr["nom"], (string)jeuEnr["prenom"]);
                    comboBox1.Items.Add(c);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                maCnx.Close(); 


            }
        }
    }
}
