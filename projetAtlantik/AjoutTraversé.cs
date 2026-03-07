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
    public partial class AjoutTraversé : Form
    {
        public AjoutTraversé()
        {
            InitializeComponent();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                MaCo.Open();
                string nom;
                int noBateau;
                string requeteBateau = "SELECT * FROM bateau";
                MySqlCommand CmdBateau = new MySqlCommand(requeteBateau, MaCo);
                MySqlDataReader readerBateau = CmdBateau.ExecuteReader();
                while (readerBateau.Read())
                {
                    noBateau = Convert.ToInt32(readerBateau["NOBATEAU"]);
                    nom = readerBateau["NOM"].ToString();
                    Bateau nomb = new Bateau(nom, noBateau);
                    cmbBateau.Items.Add(nomb);

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

        private void cmbLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnaddtraverse_Click(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");

            try
            {
                int noLiaison = ((Liaison)cmbLiaison.SelectedItem).GetNoLiaison();
                int nobateau = ((Bateau)cmbBateau.SelectedItem).GetNoBateau();

                MaCo.Open();
                string requete = "INSERT INTO traversee( NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE) VALUES ( @noliaison, @nobateau, @datehD, @datehA)";
                MySqlCommand maCde = new MySqlCommand(requete, MaCo);
                maCde.Parameters.AddWithValue("@noliaison", noLiaison);
                maCde.Parameters.AddWithValue("@nobateau", nobateau);
                maCde.Parameters.AddWithValue("@datehD", dateDepart.Value.Date);
                maCde.Parameters.AddWithValue("@datehA", dateArrivee.Value.Date);
                int nb = maCde.ExecuteNonQuery();
                MessageBox.Show("Traversé ajouté !!");

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

        private void dateDepart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateArrivee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bateau b = (Bateau)cmbBateau.SelectedItem;
            int noBateau = b.GetNoBateau();

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=");

            try
            {
                MaCo.Open();

                string requete = "SELECT lettrecategorie FROM contenir WHERE nobateau = @bateau";

                MySqlCommand cmd = new MySqlCommand(requete, MaCo);
                cmd.Parameters.AddWithValue("@bateau", noBateau);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string lettre = reader["lettrecategorie"].ToString();
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
