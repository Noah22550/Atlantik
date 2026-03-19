using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
                string requetePeriode = "SELECT * FROM periode";
                MySqlCommand Cmdperiode = new MySqlCommand(requetePeriode, MaCo);
                MySqlDataReader JeuEnrPeriode = Cmdperiode.ExecuteReader();
                while (JeuEnrPeriode.Read())
                {
                    int NoPeriode = Convert.ToInt32(JeuEnrPeriode["noperiode"]);
                    datedebut = JeuEnrPeriode["DATEDEBUT"].ToString();
                    datefin = JeuEnrPeriode["DATEFIN"].ToString() ;
                    Periode nPeriode = new Periode(datedebut, datefin,NoPeriode );
                    cmbPeriode.Items.Add(nPeriode);

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
                MySqlDataReader JeuEnrSecteur = cmdSecteur.ExecuteReader();

                while (JeuEnrSecteur.Read())
                {

                    Secteur secteur = new Secteur((int)JeuEnrSecteur["nosecteur"], JeuEnrSecteur["nom"].ToString());
                    lbxSecteur.Items.Add(secteur);
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
            //AFFICHAGE DYNAMIQUE
            try
            {
                MaCo.Open();
                string requete = "SELECT notype, libelle, lettrecategorie FROM type";
                MySqlCommand cmd = new MySqlCommand(requete, MaCo);
                MySqlDataReader JeuEnr = cmd.ExecuteReader();

                int y = 20;

                while (JeuEnr.Read())
                {
                    int noType = Convert.ToInt32(JeuEnr["notype"]);
                    string libelle = JeuEnr["libelle"].ToString();
                    string lettre = JeuEnr["lettrecategorie"].ToString();
                    Type lblType = new Type(lettre, noType, libelle);
                    // Label pour notype
                    Label lblNoType = new Label();
                    lblNoType.Text = lettre + noType.ToString()+ " - "  + libelle;
                    lblNoType.Location = new Point(10, y);
                    //lblNoType.AutoSize = true;

                    TextBox txt = new TextBox();
                    txt.Location = new Point(200, y - 3);
                    txt.Tag = lblType.GetNoType() + ":" + lblType.GetLettre();
                    txt.Width = 100;

                    // Ajout dans le GroupBox
                    gbxTarifs.Controls.Add(lblNoType);
                    gbxTarifs.Controls.Add(txt);
                    txt.Validating += gbxTarifs_TextChanged;

                    y += 30;
                }

                JeuEnr.Close();
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

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            if(cmbPeriode.SelectedItem == null || cmbLiaison.SelectedItem == null )
            {
                MessageBox.Show("Veuillez sélectionner une période et une liaison (infos manquante).");
                return;
            }else
            {
                object nPeriode = ((Periode)cmbPeriode.SelectedItem).GetNoPeriode();
                object nliaison = ((Liaison)cmbLiaison.SelectedItem).GetNoLiaison();
                try
                {
                    MaCo.Open();

                    foreach (Control c in gbxTarifs.Controls)
                    {
                        if (c is TextBox tbx)
                        {

                            string tab = tbx.Tag.ToString();
                            string[] infos = tab.Split(':');

                            int notype = int.Parse(infos[0]);
                            string lettre = infos[1];
                            double tarif = int.Parse(tbx.Text);

                            string Requete = "INSERT INTO tarifer(NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) VALUES(@nperiode, @lettrecate, @notype, @noliaison, @tarif)";

                            MySqlCommand maCde = new MySqlCommand(Requete, MaCo);

                            maCde.Parameters.AddWithValue("@nperiode", nPeriode);
                            maCde.Parameters.AddWithValue("@lettrecate", lettre);
                            maCde.Parameters.AddWithValue("@notype", notype);
                            maCde.Parameters.AddWithValue("@noliaison", nliaison);
                            maCde.Parameters.AddWithValue("@tarif", tarif);

                            maCde.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Tarifs ajouté");
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
                MySqlDataReader JeuEnr = maCde.ExecuteReader();
                cmbLiaison.Items.Clear();
                while (JeuEnr.Read())
                {
                    int NoLiaison = Convert.ToInt32(JeuEnr["noliaison"]);
                    NomDepart = JeuEnr["NOM"].ToString();
                    NomArrivee = JeuEnr["pNOM"].ToString();


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

        private void cbxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjoutTarifLiaisonPeriode_Load(object sender, EventArgs e)
        {

        }

        private void gbxTarifs_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void gbxTarifs_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.Red;
                btnadd.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.White;
                btnadd.Enabled = true;
            }
        }
    }
}

