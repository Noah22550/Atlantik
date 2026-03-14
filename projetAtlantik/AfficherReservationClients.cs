using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class AfficherReservationClients : Form
    {
        public AfficherReservationClients()
        {
            InitializeComponent();
        }

        private void lvAfficherRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAfficherRes.SelectedItems.Count == 0)
                return;

            int noReservation = Convert.ToInt32(lvAfficherRes.SelectedItems[0].SubItems[0].Text);

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            MaCo.Open();

            string requete =
            "SELECT LETTRECATEGORIE, QUANTITERESERVEE " +
            "FROM enregistrer " +
            "WHERE NORESERVATION = @nores";

            MySqlCommand cmd = new MySqlCommand(requete, MaCo);
            cmd.Parameters.AddWithValue("@nores", noReservation);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string cat = reader["LETTRECATEGORIE"].ToString();
                int qte = Convert.ToInt32(reader["QUANTITERESERVEE"]);

                if (cat == "A")
                    lblA.Text = qte.ToString();

                if (cat == "B")
                    lblB.Text = qte.ToString();

                if (cat == "C")
                    lblC.Text = qte.ToString();
            }

            reader.Close();
            MaCo.Close();
        }

        private void gbxAfficher_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvAfficherRes.Items.Clear();

            int noClient = ((Client)comboBox1.SelectedItem).GetNoClient();

            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            MaCo.Open();

            string requete =
            "SELECT r.NORESERVATION, l.NOLIAISON, t.NOTRAVERSEE, t.DATEHEUREDEPART " +
            "FROM reservation r " +
            "INNER JOIN traversee t ON r.NOTRAVERSEE = t.NOTRAVERSEE " +
            "INNER JOIN liaison l ON t.NOLIAISON = l.NOLIAISON " +
            "WHERE r.NOCLIENT = @noclient";

            MySqlCommand cmd = new MySqlCommand(requete, MaCo);
            cmd.Parameters.AddWithValue("@noclient", noClient);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] ligne = new string[4];

                ligne[0] = reader["NORESERVATION"].ToString();
                ligne[1] = reader["NOLIAISON"].ToString();
                ligne[2] = reader["NOTRAVERSEE"].ToString();
                ligne[3] = Convert.ToDateTime(reader["DATEHEUREDEPART"]).ToString();

                ListViewItem item = new ListViewItem(ligne);
                lvAfficherRes.Items.Add(item);
            }

            reader.Close();
            MaCo.Close();
        }

        private void AfficherReservationClients_Load(object sender, EventArgs e)
        {
            MySqlConnection MaCo = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=atlantik;Uid=root;Pwd=;");
            MaCo.Open();

            string requete = "SELECT NOCLIENT, NOM, PRENOM FROM client";
            MySqlCommand cmd = new MySqlCommand(requete, MaCo);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Client c = new Client(
                    (int)reader["NOCLIENT"],
                    reader["NOM"].ToString(),
                    reader["PRENOM"].ToString()
                );

                cbxClient.Items.Add(c);
            }

            reader.Close();
            MaCo.Close();
        }
    }
}
