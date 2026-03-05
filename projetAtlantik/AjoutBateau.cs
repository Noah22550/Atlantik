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

                string requete = "SELECT c.LETTRECATEGORIE, c.LIBELLE, co.CAPACITEMAX\r\nFROM categorie c\r\nINNER JOIN contenir co ON c.LETTRECATEGORIE = co.LETTRECATEGORIE";
                MySqlCommand cmd = new MySqlCommand(requete, MaCo);
                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 10;
                int compteur = 0;

                while (reader.Read() && compteur < 3)
                {
                    string lettre = reader["LETTRECATEGORIE"].ToString();
                    string libelle = reader["LIBELLE"].ToString();
                    int capaciteMax = Convert.ToInt32(reader["CAPACITEMAX"]);

                    // Label
                    Label lblBoat = new Label();
                    lblBoat.Text = lettre + " - " + libelle;
                    lblBoat.Location = new Point(10, y);

                    // TextBox
                    TextBox txt = new TextBox();
                    txt.Location = new Point(200, y - 3);
                    txt.Tag = lettre + ";" + libelle + ";" + capaciteMax; ;
                    txt.Width = 100;

                    gbxboat.Controls.Add(lblBoat);
                    gbxboat.Controls.Add(txt);

                   y += 30;
                    compteur++;
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
                foreach (Control c in gbxboat.Controls)
                {
                    if (c is TextBox tbx2)
                    {
                        tab = (tbx2.Tag).ToString();
                        tab.Split(';');

                        string libelle = tab[0].ToString();
                        string lettre = tab[2].ToString();
                        int capaciteMax = int.Parse(tab[4].ToString());
                        string nomboat = tbxAddBoat.Text;
                        MaCo.Open();
                        string requete = "INSERT INTO Bateau(NOLIAISON, NOM) VALUES (@nom)";
                        MySqlCommand maCde = new MySqlCommand(requete, MaCo);
                        MySqlDataReader reader = maCde.ExecuteReader();
                        string requete2 = "INSERT INTO contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES(@lettre, @nobateau, @capamax)";

                        MySqlCommand maCde2 = new MySqlCommand(requete2, MaCo);
                        MySqlDataReader reader2 = maCde2.ExecuteReader();

                        maCde2.Parameters.AddWithValue("@libelle", libelle);
                        maCde2.Parameters.AddWithValue("@lettre", lettre);
                        maCde2.Parameters.AddWithValue("@capamax", capaciteMax);
                        maCde.Parameters.AddWithValue("@nom", nomboat);
                        int nb = maCde.ExecuteNonQuery();
                        MessageBox.Show("Bateau ajouté !");
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
    }
}
