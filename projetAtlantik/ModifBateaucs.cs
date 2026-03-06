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
                string requeteBateau = "SELECT * FROM bateau";
                MySqlCommand CmdBateau = new MySqlCommand(requeteBateau, MaCo);
                MySqlDataReader readerPeriode = CmdBateau.ExecuteReader();
                while (readerPeriode.Read())
                {
                    nom = readerPeriode["NOM"].ToString();
                    Bateau nomb = new Bateau(nom);
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

        }

        private void cmbmodifbateau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxmodifbateau_Enter(object sender, EventArgs e)
        {

        }
    }
}
