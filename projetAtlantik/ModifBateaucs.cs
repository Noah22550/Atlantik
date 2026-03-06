using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetAtlantik
{
    public partial class ModifBateaucs : Form
    {
        public ModifBateaucs()
        {
            InitializeComponent();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=");

            try
            {
                MaCo.Open();

                string requete = " SELECT * FROM  categorie";
                MySqlCommand cmd = new MySqlCommand(requete, MaCo);
                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                //int compteur = 0;

                while (reader.Read())
                {
                    string lettre = reader["LETTRECATEGORIE"].ToString();
                    string libelle = reader["LIBELLE"].ToString();

            
                    // Label
                    Label lblBoat = new Label();
                    lblBoat.Text = lettre + " - " + libelle;
                    lblBoat.Location = new Point(10, y);

                    // TextBox
                    TextBox txt = new TextBox();
                    txt.Location = new Point(200, y - 3);
                    txt.Tag = lettre;
                    txt.Width = 100;

                    gbxmodifbateau.Controls.Add(lblBoat);
                    gbxmodifbateau.Controls.Add(txt);

                    y += 30;
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
                    cmbmodifbateau.Items.Add(nom);

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

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            object NoBateau = ((Bateau)cmbmodifbateau.SelectedItem).GetNoBateau();
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            string tab;
            try
            {
                MaCo.Open();

                foreach (Control c in gbxmodifbateau.Controls)
                {
                    if (c is TextBox tbx)
                    {

                        tab = (tbx.Tag).ToString();

                        MaCo.Open();

                        string lettre = tab;
                        int capaciteMax = int.Parse((tbx.Text).ToString());
                        string Requete = "";

                        MySqlCommand maCde = new MySqlCommand(Requete, MaCo);

                        //maCde.Parameters.AddWithValue("@nperiode", nPeriode);
                        //maCde.Parameters.AddWithValue("@lettrecate", lettre);
                        //maCde.Parameters.AddWithValue("@notype", notype);
                        //maCde.Parameters.AddWithValue("@noliaison", nliaison);
                        //maCde.Parameters.AddWithValue("@tarif", tarif);
                        int nb = maCde.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bateau modifié !!!!!");
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

        private void cmbmodifbateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            int noBateau = 0;
            try
            {
                MaCo.Open();

                string requete = "SELECT * FROM  categorie WHERE NOBATEAU = @nobateau";
                MySqlCommand CmdBateau = new MySqlCommand(requete, MaCo);
                CmdBateau.Parameters.AddWithValue("@nobateau", noBateau);
                MySqlDataReader readerBateau = CmdBateau.ExecuteReader();
                
                while (readerBateau.Read())
                {
                    int NoBateau = ((Bateau)cmbmodifbateau.SelectedItem).GetNoBateau();
                    noBateau = Convert.ToInt32(readerBateau["NOBATEAU"]);
                        foreach (Control c in gbxmodifbateau.Controls)
                        {
                            if (c is TextBox tbx)
                            {
                                
                                string lettre = (tbx.Tag).ToString();
                                tbx.Text = readerBateau["CAPACITEMAX"].ToString();
                            }
                        }
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

        private void gbxmodifbateau_Enter(object sender, EventArgs e)
        {

        }

        private void ModifBateaucs_Load(object sender, EventArgs e)
        {

        }
    }
}
