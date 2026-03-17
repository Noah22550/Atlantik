using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetAtlantik
{
    public partial class ModifParamètre : Form
    {
        public ModifParamètre()
        {
            InitializeComponent();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306");
            MySqlCommand maCde;

            try
            {
                maCnx.Open();
                string site = tbxSite.Text;
                string rang = tbxRang.Text;
                string identifiant = tbxIdentifiants.Text;
                string cleHMAC = tbxHmax.Text;
                string mel = tbxMel.Text;
                int enProduction = Convert.ToInt32(cbxProd.Checked);

                requete = "Update parametres set SITE_PB = @SITE_PB, RANG_PB = @RANG_PB, IDENTIFIANT_PB = @IDENTIFIANT_PB, CLEHMAC_PB = @CLEHMAC_PB, ENPRODUCTION = @ENPRODUCTION , MELSITE = @MELSITE";
                maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@SITE_PB", site);
                maCde.Parameters.AddWithValue("@RANG_PB", rang);
                maCde.Parameters.AddWithValue("@IDENTIFIANT_PB", identifiant);
                maCde.Parameters.AddWithValue("@CLEHMAC_PB", cleHMAC);
                maCde.Parameters.AddWithValue("@ENPRODUCTION", enProduction);
                maCde.Parameters.AddWithValue("@MELSITE", mel);
                maCde.ExecuteNonQuery();

                MessageBox.Show("modification réaliser avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCnx.Close();
            }
        }

        private void ModifParamètre_Load(object sender, EventArgs e)
        {
            string requete;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306");
            MySqlCommand maCde;

            try
            {
                maCnx.Open();

                requete = "Select * from parametres";
                maCde = new MySqlCommand(requete, maCnx);
                MySqlDataReader JeuEnr;
                JeuEnr = maCde.ExecuteReader();
                while (JeuEnr.Read())
                {
                    string site = JeuEnr["SITE_PB"].ToString();
                    string rang = JeuEnr["RANG_PB"].ToString();
                    string identifiant = JeuEnr["IDENTIFIANT_PB"].ToString();
                    string cleHMAC = JeuEnr["CLEHMAC_PB"].ToString();
                    int enProduction = Convert.ToInt32(JeuEnr["ENPRODUCTION"]);
                    string mel = JeuEnr["MELSITE"].ToString();

                    tbxSite.Text = site;
                    tbxRang.Text = rang;
                    tbxIdentifiants.Text = identifiant;
                    tbxHmax.Text = cleHMAC;
                    tbxMel.Text = mel;
                }
                JeuEnr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCnx.Close();
            }
        }

        private void tbxMel_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var objetRegEx = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            var resultatTest = objetRegEx.Match(tbx.Text);

            if (!resultatTest.Success)
            {
                tbx.BackColor = Color.Red;
                btnModif.Enabled = false;
            }
            else
            {
                tbx.BackColor = Color.White;
                btnModif.Enabled = true;
            }
        }

        private void tbxMel_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            var resultatTest = objetRegEx.Match(tbxMel.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Format incorrect");
                tbxMel.BackColor = Color.Red;
            }
        }

        private void tbxSite_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxRang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxIdentifiants_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxHmax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
