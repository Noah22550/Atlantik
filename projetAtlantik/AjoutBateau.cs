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
//using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using TextBox = System.Windows.Forms.TextBox;

namespace projetAtlantik
{
    public partial class AjoutBateau : Form
    {
        public AjoutBateau()
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

                    gbxboat.Controls.Add(lblBoat);
                    gbxboat.Controls.Add(txt);

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
        }

        private void tbxAddBoat_TextChanged(object sender, EventArgs e)
        {

        }


        private void gbxboat_Enter(object sender, EventArgs e)
        {

        }

        private void AjoutBateau_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            string tab;
            try
            {
                string nomboat = tbxAddBoat.Text;
                MaCo.Open();
                string requete = "INSERT INTO Bateau(NOM) VALUES (@nom)";
                MySqlCommand maCde = new MySqlCommand(requete, MaCo);
                maCde.Parameters.AddWithValue("@nom", nomboat);
                int nb = maCde.ExecuteNonQuery();
                int nobateau = (int)maCde.LastInsertedId;
                MaCo.Close();


                foreach (Control c in gbxboat.Controls)
                {
                    if (c is TextBox tbx2)
                    {
                        tab = (tbx2.Tag).ToString();

                        MaCo.Open();
                        
                        string lettre = tab;
                        int capaciteMax = int.Parse((tbx2.Text).ToString());
                        
                        string requete2 = "INSERT INTO contenir VALUES(@lettre, @nobateau, @capamax)";

                        MySqlCommand maCde2 = new MySqlCommand(requete2, MaCo);
                        //int nb2 = maCde.ExecuteNonQuery();

                        maCde2.Parameters.AddWithValue("@lettre", lettre);
                        maCde2.Parameters.AddWithValue("@nobateau", nobateau);
                        maCde2.Parameters.AddWithValue("@capamax", capaciteMax);
                        
                        int nb2 = maCde.ExecuteNonQuery();
                        
                        MaCo.Close();
                    }
                }
                MessageBox.Show("Bateau ajouté !");
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
