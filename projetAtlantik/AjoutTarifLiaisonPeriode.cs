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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace projetAtlantik
{
    public partial class AjoutTarifLiaisonPeriode : Form
    {
        public AjoutTarifLiaisonPeriode()
        {
            InitializeComponent();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            //AFFICHAGE PERIODE
            try
            {
                MaCo.Open();
                string datedebut, datefin;
                string requetePeriode = "SELECT DATEDEBUT, DATEFIN FROM periode";
                MySqlCommand Cmdperiode = new MySqlCommand(requetePeriode, MaCo);
                MySqlDataReader readerPeriode = Cmdperiode.ExecuteReader();
                while (readerPeriode.Read())
                {
                    datedebut = readerPeriode["DATEDEBUT"].ToString();
                    datefin = readerPeriode["DATEFIN"].ToString() ;
                    Periode nPeriode = new Periode(datedebut, datefin);
                    cbxPeriode.Items.Add(nPeriode);

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

            //AFFICHAGE LISTBOX SECTEUR
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
            //AFFICHAGE DYNAMIQUE
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
                    Type lblType = new Type(lettre, noType, libelle);
                    // Label pour notype
                    Label lblNoType = new Label();
                    lblNoType.Text = lblType.ToString();
                    lblNoType.Location = new Point(10, y);
                    lblNoType.AutoSize = true;

                    TextBox txt = new TextBox();
                    txt.Location = new Point(200, y - 3);
                    txt.Tag = noType + ":" + lettre;
                    txt.Width = 100;

                    // Ajout dans le GroupBox
                    gbxTarifs.Controls.Add(lblNoType);
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
            //AFFICHAGE COMBOBOX
            
        }

        private void gbxTarifs_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            try
            {
                MaCo.Open();
                int nosecteur = ((Secteur)lbxSecteur.SelectedItem).GetNosecteur();
                string NomDepart, NomArrivee;
                string requete = "SELECT p.NOM, po.NOM As \"pNOM\" From liaison l inner join port p ON ( l.noport_depart = p.NOPORT) inner join port po ON ( l.NOPORT_ARRIVEE = po.NOPORT) Where nosecteur = @nomsecteurs;";
                MySqlCommand maCde = new MySqlCommand(requete, MaCo);
                maCde.Parameters.AddWithValue("@nomsecteurs", nosecteur);
                MySqlDataReader reader = maCde.ExecuteReader();
                cbxLiaison.Items.Clear();
                while (reader.Read())
                {
                    NomDepart = reader["NOM"].ToString();
                    NomArrivee = reader["pNOM"].ToString();
                    Liaison Liaison = new Liaison(NomDepart, NomArrivee);
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

        private void cbxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
