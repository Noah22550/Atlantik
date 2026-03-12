using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace projetAtlantik
{
    
    public partial class Affichertraverse : Form
    {
        public int GetQuantiteEnregistree(int noTraverse, string lettrecategorie)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                int res;
                MaCo.Open();
                string requeteEnregistrer = "select sum(e.QUANTITERESERVEE) from reservation r " +
                    "INNER JOIN enregistrer e on r.NORESERVATION = e.NORESERVATION " +
                    "where e.LETTRECATEGORIE = @lettrecat and r.NOTRAVERSEE = @notrav;";
                MySqlCommand MaCde = new MySqlCommand(requeteEnregistrer, MaCo);
                MaCde.Parameters.AddWithValue("@lettrecat", lettrecategorie);
                MaCde.Parameters.AddWithValue("@notrav", noTraverse);
                MySqlDataReader readerEnregistrement = MaCde.ExecuteReader();
                res = Convert.ToInt32(readerEnregistrement.Read());
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return -1;
            }
            finally
            {
                MaCo.Close();
            }
            
        }
        public int GetCapaciteMax(int noTraverse, string lettrecategorie)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                int res;
                MaCo.Open();
                string requeteCapamax = "SELECT CAPACITEMAX from traversee t " +
                    "INNER JOIN bateau b ON b.NOBATEAU = t.NOBATEAU INNER JOIN contenir c ON c.NOBATEAU = t.NOBATEAU " +
                    "where t.notraversee = @numtrav and c.lettrecategorie = @lettrecat;";
                MySqlCommand MaCde = new MySqlCommand(requeteCapamax, MaCo);
                MaCde.Parameters.AddWithValue("@lettrecat", lettrecategorie);
                MaCde.Parameters.AddWithValue("@notrav", noTraverse);
                MySqlDataReader readerCpamax = MaCde.ExecuteReader();
                res = Convert.ToInt32(MaCde.ExecuteReader());
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return -1;
            }
            finally
            {
                MaCo.Close();
            }
        }
        public List<object> GetCategorie(string lettrecategorie, string libelle)
        {
            List<object> list = new List<object>();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                MaCo.Open();
                string requeteCapamax = "SELECT * FROM categorie";
                MySqlCommand MaCde = new MySqlCommand(requeteCapamax, MaCo);
                MySqlDataReader readerCpamax = MaCde.ExecuteReader();
                while (readerCpamax.Read())
                {
                    Categorie c = new Categorie((string)readerCpamax["LETTRECATEGORIE"], (string)readerCpamax["LIBELLE"]);
                    list.Add(c);
                    
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return list;
            }
            finally
            {
                MaCo.Close();
            }
        }
        public List<object> GetLesTraverseesBateaux(int noliaison, string datetraversee)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);
            List<object> list = new List<object>();
            try
            {
                maCo.Open();
                int res;
                string requete = "SELECT notraversee, nom, dateheuredepart " +
                                 "FROM traversee t " +
                                 "INNER JOIN bateau b ON t.nobateau = b.nobateau " +
                                 "WHERE noliaison = @noliaison AND DATE(dateheuredepart) = @date";

                MySqlCommand maCde = new MySqlCommand(requete, maCo);
                maCde.Parameters.AddWithValue("@noliaison", noliaison);
                maCde.Parameters.AddWithValue("@date", datetraversee);
                MySqlDataReader reader = maCde.ExecuteReader();

                while (reader.Read())
                {
                    Traversees T = new Traversees((int)reader["NOTRAVERSE"], (int)reader["NOBATEAU"], (DateTime)reader["DATEHEUREDEPART"]);
                    list.Add(T);
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }
            finally
            {
                maCo.Close();
            }
        }

        public Affichertraverse()
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
        }

        private void Affichertraverse_Load(object sender, EventArgs e)
        {
            lvTraverse.View = View.Details; // Mode d'affichage

            lvTraverse.GridLines = true; // on affichera la grille
            lvTraverse.FullRowSelect = true; // Mode de sélection : ligne
            lvTraverse.Columns.Add("N° ", 70); // 100 = largeur colonne
            lvTraverse.Columns.Add("Heure", 100);
            lvTraverse.Columns.Add("Bateau", 100);
            lvTraverse.Columns.Add("A Passager", 120);
            lvTraverse.Columns.Add("B Véh.in.2m", 120);
            lvTraverse.Columns.Add("C Véh.sup.2m", 120);
           
        }

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                MaCo.Open();
                int nosecteur = ((Secteur)lbxSecteur.SelectedItem).GetNosecteur();
                string NomDepart, NomArrivee;
                string requete = "SELECT  noliaison, p.NOM, po.NOM As \"pNOM\" From liaison l inner join port p ON ( l.noport_depart = p.NOPORT) inner join port po ON ( l.NOPORT_ARRIVEE = po.NOPORT) Where nosecteur = @nomsecteurs;";
                MySqlCommand maCde = new MySqlCommand(requete, MaCo);
                maCde.Parameters.AddWithValue("@nomsecteurs", nosecteur);
                MySqlDataReader reader = maCde.ExecuteReader();
                cbxLiaison.Items.Clear();
                while (reader.Read())
                {
                    int NoLiaison = Convert.ToInt32(reader["noliaison"]);
                    NomDepart = reader["NOM"].ToString();
                    NomArrivee = reader["pNOM"].ToString();
                    Liaison Liaison = new Liaison(NomDepart, NomArrivee, NoLiaison);
                    cbxLiaison.Items.Add(Liaison);
                }
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

        private void lvTraverse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            //Secteur secteur = lbxSecteur ;
            //// CATEGORIE ////

            try
            {
                MaCo.Open();

                string requete = "SELECT * FROM categorie";
                MySqlCommand maCde = new MySqlCommand(requete, MaCo);

                MySqlDataReader readerSecteur = maCde.ExecuteReader();
                /*le pb commence ici */while (readerSecteur.Read())
                {
                    Categorie cat = new Categorie((string)readerSecteur["LETTRECATEGORIE"], (string)readerSecteur["LIBELLE"]) ;
                }
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

                lvTraverse.Items.Clear();

                int noLiaison = ((Liaison)cbxLiaison.SelectedItem).GetNoLiaison();
                DateTime date = dateafficher.Value;

                string requete = "SELECT t.NOTRAVERSEE, t.DATEHEUREDEPART, b.NOM " +
                                 "FROM traversee t " +
                                 "INNER JOIN bateau b ON b.NOBATEAU = t.NOBATEAU " +
                                 "WHERE t.NOLIAISON = @noliaison " +
                                 "AND DATE(t.DATEHEUREDEPART) = @date";

                MySqlCommand cmd = new MySqlCommand(requete, MaCo);

                cmd.Parameters.AddWithValue("@noliaison", noLiaison);
                cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int numtrav = Convert.ToInt32(reader["NOTRAVERSEE"]);
                    DateTime heure = Convert.ToDateTime(reader["DATEHEUREDEPART"]);
                    string bateau = reader["NOM"].ToString();
                    foreach (Traversees lestrav in )
                    {
                         = GetCapaciteMax(numtrav, ) - GetQuantiteEnregistree(numtrav, );
                    }

                    ListViewItem item = new ListViewItem(tabItem);
                    lvTraverse.Items.Add(item);
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