using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    txt.Validating += gbxmodifbateau_TextChanged;
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
                    cmbmodifbateau.Items.Add(nomb);

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
            Bateau b = (Bateau)cmbmodifbateau.SelectedItem;
            int noBateau = b.GetNoBateau();

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=");

            try
            {
                MaCo.Open();

                foreach (Control c in gbxmodifbateau.Controls)
                {
                    if (c is TextBox tbx)
                    {
                        string lettre = tbx.Tag.ToString();
                        int capaciteMax = int.Parse(tbx.Text);

                        string requete = "UPDATE contenir SET capacitemax = @capacite WHERE nobateau = @bateau AND lettrecategorie = @lettre";

                        MySqlCommand cmd = new MySqlCommand(requete, MaCo);

                        cmd.Parameters.AddWithValue("@capacite", capaciteMax);
                        cmd.Parameters.AddWithValue("@bateau", noBateau);
                        cmd.Parameters.AddWithValue("@lettre", lettre);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Bateau modifié !");
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

        private void cmbmodifbateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bateau b = (Bateau)cmbmodifbateau.SelectedItem;
            int noBateau = b.GetNoBateau();

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=");

            try
            {
                MaCo.Open();

                string requete = "SELECT lettrecategorie, capacitemax FROM contenir WHERE nobateau = @bateau";

                MySqlCommand cmd = new MySqlCommand(requete, MaCo);
                cmd.Parameters.AddWithValue("@bateau", noBateau);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string lettre = reader["lettrecategorie"].ToString();
                    string capacite = reader["capacitemax"].ToString();

                    foreach (Control c in gbxmodifbateau.Controls)
                    {
                        if (c is TextBox tbx)
                        {
                            if (tbx.Tag.ToString() == lettre)
                            {
                                tbx.Text = capacite;
                            }
                        }
                    }
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

        private void gbxmodifbateau_Enter(object sender, EventArgs e)
        {

        }

        private void ModifBateaucs_Load(object sender, EventArgs e)
        {

        }

        private void gbxmodifbateau_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex("^[0-9]*$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.Red;
                btnmodifier.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.White;
                btnmodifier.Enabled = true;
            }
        }
    }
}
