using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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

        private void gbxIdentifiant_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");

            try
            {
                maCnx.Open();

                string site = ((TextBox)gbxIdentifiant.Controls["tbxSite"]).Text;
                string rang = ((TextBox)gbxIdentifiant.Controls["tbxRang"]).Text;
                string identifiant = ((TextBox)gbxIdentifiant.Controls["tbxIdentifiant"]).Text;
                string cle = ((TextBox)gbxIdentifiant.Controls["tbxCle"]).Text;

                string requete = "UPDATE parametres SET SITE_PB=@site, RANG_PB=@rang, IDENTIFIANT_PB=@id, CLEHMAC_PB=@cle WHERE NOIDENTIFIANT=1";

                MySqlCommand cmd = new MySqlCommand(requete, maCnx);
                cmd.Parameters.AddWithValue("@site", site);
                cmd.Parameters.AddWithValue("@rang", rang);
                cmd.Parameters.AddWithValue("@id", identifiant);
                cmd.Parameters.AddWithValue("@cle", cle);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Modification enregistrée");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                maCnx.Close();
            }
        }

        private void ModifParamètre_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader readerParam = null;

            try
            {
                Label lblSite, lblRang, lblIdentifiant, lblCléHMAC;
                TextBox tbxSite, tbxRang, tbxIdentifiant, tbxCléHMAC;
                int i = 2;

                maCnx.Open();
                string requete = "SELECT * FROM parametres";
                MySqlCommand maCde = new MySqlCommand(requete, maCnx);
                readerParam = maCde.ExecuteReader();

                while (readerParam.Read())
                {
                    string site = readerParam["SITE_PB"].ToString();
                    string rang = readerParam["RANG_PB"].ToString();
                    string identifiant = readerParam["IDENTIFIANT_PB"].ToString();
                    string cleHMAC = readerParam["CLEHMAC_PB"].ToString();

                    lblSite = new Label();
                    lblSite.Text = "Site :";
                    lblSite.Location = new Point(15, 25 * i);
                    gbxIdentifiant.Controls.Add(lblSite);

                    tbxSite = new TextBox();
                    tbxSite.Name = "tbxSite";
                    tbxSite.Text = site;
                    tbxSite.Location = new Point(150, 25 * i);
                    gbxIdentifiant.Controls.Add(tbxSite);

                    i++;

                    lblRang = new Label();
                    lblRang.Text = "Rang :";
                    lblRang.Location = new Point(15, 25 * i);
                    gbxIdentifiant.Controls.Add(lblRang);

                    tbxRang = new TextBox();
                    tbxRang.Name = "tbxRang";
                    tbxRang.Text = rang;
                    tbxRang.Location = new Point(150, 25 * i);
                    gbxIdentifiant.Controls.Add(tbxRang);

                    i++;

                    lblIdentifiant = new Label();
                    lblIdentifiant.Text = "Identifiant :";
                    lblIdentifiant.Location = new Point(15, 25 * i);
                    gbxIdentifiant.Controls.Add(lblIdentifiant);

                    tbxIdentifiant = new TextBox();
                    tbxIdentifiant.Name = "tbxIdentifiant";
                    tbxIdentifiant.Text = identifiant;
                    tbxIdentifiant.Location = new Point(150, 25 * i);
                    gbxIdentifiant.Controls.Add(tbxIdentifiant);

                    i++;

                    lblCléHMAC = new Label();
                    lblCléHMAC.Text = "Clé HMAC :";
                    lblCléHMAC.Location = new Point(15, 25 * i);
                    gbxIdentifiant.Controls.Add(lblCléHMAC);

                    tbxCléHMAC = new TextBox();
                    tbxCléHMAC.Name = "tbxCle";
                    tbxCléHMAC.Text = cleHMAC;
                    tbxCléHMAC.Location = new Point(150, 25 * i);
                    gbxIdentifiant.Controls.Add(tbxCléHMAC);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
            }
            finally
            {
                readerParam.Close();
                maCnx.Close();
            }
        }
    }
}
