using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                MaCo.Open();
                string requeteEnregistrer = "select sum(e.QUANTITERESERVEE) from reservation r " +
                    "INNER JOIN enregistrer e on r.NORESERVATION = e.NORESERVATION " +
                    "where e.LETTRECATEGORIE = @lettrecat and r.NOTRAVERSEE = @notrav;";
                MySqlCommand MaCde = new MySqlCommand(requeteEnregistrer, MaCo);
                MaCde.Parameters.AddWithValue("@lettrecat", lettrecategorie);
                MaCde.Parameters.AddWithValue("@notrav", noTraverse);
                MySqlDataReader readerEnregistrement = MaCde.ExecuteReader();
                return GetQuantiteEnregistree(noTraverse, lettrecategorie);

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
                MaCo.Open();
                string requeteCapamax = "SELECT CAPACITEMAX from traversee t " +
                    "INNER JOIN bateau b ON b.NOBATEAU = t.NOBATEAU INNER JOIN contenir c ON c.NOBATEAU = t.NOBATEAU " +
                    "where t.notraversee = @numtrav and c.lettrecategorie = @lettrecat;";
                MySqlCommand MaCde = new MySqlCommand(requeteCapamax, MaCo);
                MaCde.Parameters.AddWithValue("@lettrecat", lettrecategorie);
                MaCde.Parameters.AddWithValue("@notrav", noTraverse);
                MySqlDataReader readerCpamax = MaCde.ExecuteReader();
                return GetCapaciteMax(noTraverse, lettrecategorie);
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
        private List<Traversees> GetLesTraverseesBateaux(int noliaison, string datetraversee)
        {
            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            List<Traversees> lestraversees = new List<Traversees>();

            try
            {
                maCo.Open();

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
                    int notraverse = (int)reader["notraversee"];
                    string nom = reader["nom"].ToString();
                    DateTime dateheuredepart = (DateTime)reader["dateheuredepart"];

                    Traversees trav = new Traversees(notraverse, nom, dateheuredepart.ToString());

                    lestraversees.Add(trav);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }

            return lestraversees;
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

            try
            {
                MaCo.Open();

                lvTraverse.Items.Clear();

                int noLiaison = ((Liaison)cbxLiaison.SelectedItem).GetNoLiaison();
                DateTime date = dateafficher.Value;

                List<Traversees> lesTrav = GetLesTraverseesBateaux(noLiaison, date.ToString("yyyy-MM-dd"));

                string requete = "SELECT NOTRAVERSEE, DATEHEUREDEPART, b.NOM " +
                                 "FROM traversee t " +
                                 "INNER JOIN bateau b ON b.NOBATEAU = t.NOBATEAU " +
                                 "WHERE NOLIAISON = @noliaison AND DATE(DATEHEUREDEPART) = @date";

                MySqlCommand cmd = new MySqlCommand(requete, MaCo);

                cmd.Parameters.AddWithValue("@noliaison", noLiaison);
                cmd.Parameters.AddWithValue("@date", date);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int numtrav = (int)reader["NOTRAVERSEE"];
                    DateTime heure = (DateTime)reader["DATEHEUREDEPART"];
                    string bateau = reader["NOM"].ToString();

                    int A = GetQuantiteEnregistree(numtrav, "A");
                    int B = GetQuantiteEnregistree(numtrav, "B");
                    int C = GetQuantiteEnregistree(numtrav, "C");

                    ListViewItem ligne = new ListViewItem(numtrav.ToString());

                    ligne.SubItems.Add(heure.ToString("HH:mm"));
                    ligne.SubItems.Add(bateau);
                    ligne.SubItems.Add(A.ToString());
                    ligne.SubItems.Add(B.ToString());
                    ligne.SubItems.Add(C.ToString());

                    lvTraverse.Items.Add(ligne);
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
    }
}
