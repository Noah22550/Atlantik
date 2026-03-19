using MySql.Data.MySqlClient;
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
                MySqlDataReader JeuEnr = cmd.ExecuteReader();

                int y = 10;
                //int compteur = 0;

                while (JeuEnr.Read())
                {
                    string lettre = JeuEnr["LETTRECATEGORIE"].ToString();
                    string libelle = JeuEnr["LIBELLE"].ToString();


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

                JeuEnr.Close();
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
        private bool ValiderGroupBox()
        {
            bool toutValide = true;
            var regex = new Regex("^[0-9]+$");

            foreach (Control c in gbxboat.Controls)
            {
                if (c is TextBox tbx)
                {
                    if (tbx.Text == null || tbx.Text == "" || tbx.Text == "")
                    {
                        tbx.BackColor = Color.LightCoral;
                        errorProvider3.SetError(tbx, "Champ obligatoire");
                        toutValide = false;
                    }
                    else if (!regex.IsMatch(tbx.Text))
                    {
                        tbx.BackColor = Color.LightCoral;
                        errorProvider3.SetError(tbx, "Chiffres uniquement");
                        toutValide = false;
                    }
                    else
                    {
                        tbx.BackColor = Color.White;
                        errorProvider3.SetError(tbx, "");
                    }
                }
            }

            return toutValide;
        }
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var regex = new Regex("^[0-9]+$");

            if (tbx.Text == null || tbx.Text == "" || tbx.Text == "")
            {
                tbx.BackColor = Color.LightCoral;
                errorProvider3.SetError(tbx, "Champ obligatoire");
            }
            else if (!regex.IsMatch(tbx.Text))
            {
                tbx.BackColor = Color.LightCoral;
                errorProvider3.SetError(tbx, "Chiffres uniquement");
            }
            else
            {
                tbx.BackColor = Color.White;
                errorProvider3.SetError(tbx, "");
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
            var regex = new Regex("^[a-zA-Zéèêëçàâôùûïî ]+$");

            // Vérification du nom du bateau
            if (string.IsNullOrWhiteSpace(tbxAddBoat.Text))
            {
                errorProvider3.SetError(tbxAddBoat, "Le nom du bateau est obligatoire");
                return;
            }
            else if (!regex.IsMatch(tbxAddBoat.Text.Trim()))
            {
                errorProvider3.SetError(tbxAddBoat, "Caractères uniquement");
                return;
            }
            else
            {
                errorProvider3.SetError(tbxAddBoat, "");
            }

            // Vérification des textbox du groupbox
            if (!ValiderGroupBox())
            {
                MessageBox.Show("Veuillez corriger les erreurs avant d'ajouter un bateau.");
                return;
            }

            string CHAINECONNEXION = "Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;";
            MySqlConnection maCo = new MySqlConnection(CHAINECONNEXION);

            try
            {
                maCo.Open();

                string nombateau = tbxAddBoat.Text.Trim();
                string requêteinsbateau = "INSERT INTO bateau(nom) VALUES (@nombateau)";
                MySqlCommand maCdeinsbateau = new MySqlCommand(requêteinsbateau, maCo);
                maCdeinsbateau.Parameters.AddWithValue("@nombateau", nombateau);
                maCdeinsbateau.ExecuteNonQuery();

                int nobateau = (int)maCdeinsbateau.LastInsertedId;

                foreach (Control c in gbxboat.Controls)
                {
                    if (c is TextBox tbx)
                    {
                        string letcat = tbx.Tag.ToString();
                        int capamax = int.Parse(tbx.Text);

                        string requête = "INSERT INTO contenir(lettrecategorie, nobateau, capacitemax) VALUES (@letcat, @nobateau, @capacitemax)";
                        MySqlCommand maCde = new MySqlCommand(requête, maCo);
                        maCde.Parameters.AddWithValue("@letcat", letcat);
                        maCde.Parameters.AddWithValue("@nobateau", nobateau);
                        maCde.Parameters.AddWithValue("@capacitemax", capamax);
                        maCde.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Nouveau bateau ajouté !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                maCo.Close();
            }
        }
        

        private void tbxAddBoat_Validating(object sender, CancelEventArgs e)
        {
        }


        private void gbxboat_Validating(object sender, CancelEventArgs e)
        {
          
        }
    }
}



