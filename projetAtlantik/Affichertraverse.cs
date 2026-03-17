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
        public int GetCapaciteMax(int noTraverse, string lettre)
        {
            int res = 0;

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            MaCo.Open();

            string requete =
            "SELECT c.CAPACITEMAX " +
            "FROM traversee t " +
            "INNER JOIN bateau b ON b.NOBATEAU = t.NOBATEAU " +
            "INNER JOIN contenir c ON c.NOBATEAU = b.NOBATEAU " +
            "WHERE t.NOTRAVERSEE = @notrav AND c.LETTRECATEGORIE = @lettre";

            MySqlCommand cmd = new MySqlCommand(requete, MaCo);

            cmd.Parameters.AddWithValue("@notrav", noTraverse);
            cmd.Parameters.AddWithValue("@lettre", lettre);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() && reader[0] != DBNull.Value)
                res = Convert.ToInt32(reader["CAPACITEMAX"]);

            reader.Close();
            MaCo.Close();

            return res;
        }
        public int GetQuantiteEnregistree(int noTraverse, string lettre)
        {
            int res = 0;

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            MaCo.Open();

            string requete =
            "SELECT SUM(e.QUANTITERESERVEE) " +
            "FROM reservation r " +
            "INNER JOIN enregistrer e ON r.NORESERVATION = e.NORESERVATION " +
            "WHERE r.NOTRAVERSEE = @notrav AND e.LETTRECATEGORIE = @lettre";

            MySqlCommand cmd = new MySqlCommand(requete, MaCo);

            cmd.Parameters.AddWithValue("@notrav", noTraverse);
            cmd.Parameters.AddWithValue("@lettre", lettre);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() && reader[0] != DBNull.Value)
            {
                res = Convert.ToInt32(reader[0]);
            }


            reader.Close();
            MaCo.Close();

            return res;
        }
        public List<Categorie> GetCategorie()
        {
            List<Categorie> list = new List<Categorie>();

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            MaCo.Open();

            string requete = "SELECT LETTRECATEGORIE, LIBELLE FROM categorie";
            MySqlCommand cmd = new MySqlCommand(requete, MaCo);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Categorie c = new Categorie(
                    reader["LETTRECATEGORIE"].ToString(),
                    reader["LIBELLE"].ToString()
                );

                list.Add(c);
            }

            reader.Close();
            MaCo.Close();

            return list;
        }

        public List<Traversees> GetLesTraverseesBateaux(int noliaison, DateTime date)
        {
            List<Traversees> list = new List<Traversees>();

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            MaCo.Open();

            string requete =
            "SELECT t.NOTRAVERSEE, t.DATEHEUREDEPART, b.NOM " +
            "FROM traversee t " +
            "INNER JOIN bateau b ON b.NOBATEAU = t.NOBATEAU " +
            "WHERE t.NOLIAISON = @noliaison AND DATE(t.DATEHEUREDEPART) = @date";

            MySqlCommand cmd = new MySqlCommand(requete, MaCo);

            cmd.Parameters.AddWithValue("@noliaison", noliaison);
            cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));

            MySqlDataReader JeuEnr = cmd.ExecuteReader();

            while (JeuEnr.Read())
            {
                Traversees t = new Traversees(Convert.ToInt32(JeuEnr["NOTRAVERSEE"]), JeuEnr["NOM"].ToString(), Convert.ToDateTime(JeuEnr["DATEHEUREDEPART"]));

                list.Add(t);
            }

            JeuEnr.Close();
            MaCo.Close();

            return list;
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
                string requete = "SELECT  noliaison, p.NOM, po.NOM As pNOM From liaison l inner join port p ON ( l.noport_depart = p.NOPORT) inner join port po ON ( l.NOPORT_ARRIVEE = po.NOPORT) Where nosecteur = @nomsecteurs;";
                MySqlCommand maCde = new MySqlCommand(requete, MaCo);
                maCde.Parameters.AddWithValue("@nomsecteurs", nosecteur);
                MySqlDataReader reader = maCde.ExecuteReader();
                cmbLiaison.Items.Clear();
                while (reader.Read())
                {
                    int NoLiaison = Convert.ToInt32(reader["noliaison"]);
                    NomDepart = reader["NOM"].ToString();
                    NomArrivee = reader["pNOM"].ToString();
                    Liaison Liaison = new Liaison(NomDepart, NomArrivee, NoLiaison);
                    cmbLiaison.Items.Add(Liaison);
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
            if(cmbLiaison.SelectedItem == null || lbxSecteur == null)
            {
                MessageBox.Show("Veuillez sélectionner une liaison, un secteur et une date valide....");

            }
            else
            {
                lvTraverse.Items.Clear();

                int noLiaison = ((Liaison)cmbLiaison.SelectedItem).GetNoLiaison();
                DateTime date = dateafficher.Value;

                List<Traversees> lesTraversees = GetLesTraverseesBateaux(noLiaison, date);
                List<Categorie> lesCategories = GetCategorie();

                foreach (Traversees trav in lesTraversees)
                {
                    string[] ligne = new string[6];

                    ligne[0] = trav.GetNoTraverse().ToString();
                    ligne[1] = trav.GetDateHeure().ToString("HH:mm");
                    ligne[2] = trav.GetNomBateau();

                    int i = 3;

                    foreach (Categorie cat in lesCategories)
                    {
                        int capacite = GetCapaciteMax(trav.GetNoTraverse(), cat.GetLettreCategorie());
                        int reserve = GetQuantiteEnregistree(trav.GetNoTraverse(), cat.GetLettreCategorie());

                        int dispo = capacite - reserve;

                        ligne[i] = dispo.ToString();
                        i++;
                    }

                    ListViewItem item = new ListViewItem(ligne);
                    lvTraverse.Items.Add(item);
                }
            }
           
        }
    }
}