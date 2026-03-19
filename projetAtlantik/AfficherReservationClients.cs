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
            if (lvAfficherRes.SelectedItems.Count != 0)
            {
                MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                gbxAfficher.Controls.Clear();
                int noRes = Convert.ToInt32(lvAfficherRes.SelectedItems[0].Text);
                try
                {
                    maCnx.Open();
                    int i = 0;

                    // les prestations depuis enregistrer
                    string reqPrestations = "SELECT e.QUANTITERESERVEE, t.LIBELLE " +
                                            "FROM enregistrer e " +
                                            "INNER JOIN type t ON e.NOTYPE = t.NOTYPE AND e.LETTRECATEGORIE = t.LETTRECATEGORIE " +
                                            "WHERE e.NORESERVATION = @noRes";

                    MySqlCommand cmdPrestations = new MySqlCommand(reqPrestations, maCnx);
                    cmdPrestations.Parameters.AddWithValue("@noRes", noRes);
                    MySqlDataReader jeuEnr = cmdPrestations.ExecuteReader();

                    while (jeuEnr.Read())
                    {
                        // Label libellé (colonne gauche)
                        Label lblLibelle = new Label();
                        lblLibelle.Text = jeuEnr["LIBELLE"].ToString().Trim();
                        lblLibelle.Location = new Point(15, 20 + 25 * i);
                        lblLibelle.Width = 160;
                        gbxAfficher.Controls.Add(lblLibelle);

                        // Label valeur (colonne droite)
                        Label lblValeur = new Label();
                        lblValeur.Text = ": " + jeuEnr["QUANTITERESERVEE"].ToString();
                        lblValeur.Location = new Point(180, 20 + 25 * i);
                        lblValeur.AutoSize = true;
                        gbxAfficher.Controls.Add(lblValeur);

                        i++;
                    }

                    jeuEnr.Close();

                    // Requête 2 : montant et mode de règlement depuis reservation 
                    string reqReservation = "SELECT MONTANTTOTAL, MODEREGLEMENT " +
                                            "FROM reservation " +
                                            "WHERE NORESERVATION = @noRes";

                    MySqlCommand cmdReservation = new MySqlCommand(reqReservation, maCnx);
                    cmdReservation.Parameters.AddWithValue("@noRes", noRes);
                    MySqlDataReader jeuEnr2 = cmdReservation.ExecuteReader();

                    double montant = 0;
                    string modereglement = "";

                    if (jeuEnr2.Read())
                    {
                        if (jeuEnr2["MONTANTTOTAL"] != DBNull.Value)
                        {
                            montant = Convert.ToDouble(jeuEnr2["MONTANTTOTAL"]);
                        }
                        if (jeuEnr2["MODEREGLEMENT"] != DBNull.Value)
                        {
                            modereglement = jeuEnr2["MODEREGLEMENT"].ToString().Trim();
                        }
                    }

                    jeuEnr2.Close();

                    // Montant total (libellé gauche)
                    Label lblMontantLibelle = new Label();
                    lblMontantLibelle.Text = "Montant total";
                    lblMontantLibelle.Location = new Point(15, 20 + 25 * i);
                    lblMontantLibelle.Width = 160;
                    gbxAfficher.Controls.Add(lblMontantLibelle);

                    // Montant total (valeur droite)
                    Label lblMontantValeur = new Label();
                    lblMontantValeur.Text = ": " + montant.ToString() + " euros";
                    lblMontantValeur.Location = new Point(180, 20 + 25 * i);
                    lblMontantValeur.AutoSize = true;
                    gbxAfficher.Controls.Add(lblMontantValeur);
                    i++;

                    // Mode de règlement
                    Label lblReglement = new Label();
                    lblReglement.Text = "Réglé par Carte bancaire " + modereglement;
                    lblReglement.Location = new Point(15, 20 + 25 * i);
                    lblReglement.AutoSize = true;
                    gbxAfficher.Controls.Add(lblReglement);
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
        }

        private void gbxAfficher_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvAfficherRes.FullRowSelect = true;
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
                Client clientSelectionne = (Client)comboBox1.SelectedItem;
                int noClient = clientSelectionne.GetNoClient();

                maCnx.Open();
                string requête = "SELECT r.NORESERVATION, r.NOTRAVERSEE, t.DATEHEUREDEPART " +
                                 "FROM reservation r " +
                                 "INNER JOIN traversee t ON r.NOTRAVERSEE = t.NOTRAVERSEE " +
                                 "INNER JOIN liaison li ON t.NOLIAISON = li.NOLIAISON " +
                                 "WHERE r.NOCLIENT = @noclient";

                MySqlCommand maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noclient", noClient);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    string noreservation = jeuEnr["NORESERVATION"].ToString();
                    string notraversee = jeuEnr["NOTRAVERSEE"].ToString();
                    string liaison = GetLiaison(notraversee);
                    string dateheure = ((DateTime)jeuEnr["DATEHEUREDEPART"]).ToString("dd/MM/yyyy à HH:mm");

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
                if (jeuEnr != null)
                {
                    jeuEnr.Close();
                }
                maCnx.Close();
            }
        }

        private string GetLiaison(string noTraversee)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;

            try
            {
                maCnx.Open();
                string requete = "SELECT p1.nom AS nomport_depart, p2.nom AS nomport_arrivee, li.noliaison " +
                                 "FROM liaison li " +
                                 "INNER JOIN port p1 ON li.NOPORT_DEPART = p1.noport " +
                                 "INNER JOIN port p2 ON li.NOPORT_ARRIVEE = p2.noport " +
                                 "INNER JOIN traversee ON traversee.NOLIAISON = li.NOLIAISON " +
                                 "WHERE traversee.notraversee = @notraversee";

                MySqlCommand maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@notraversee", noTraversee);
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
                if (jeuEnr != null)
                {
                    jeuEnr.Close();
                }
                maCnx.Close();
            }
        }

        private void AfficherReservationClients_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requête = "SELECT * FROM client";
                MySqlCommand maCde = new MySqlCommand(requête, maCnx);
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
                if (jeuEnr != null)
                {
                    jeuEnr.Close();
                }
                maCnx.Close();
            }
        }
    }
}