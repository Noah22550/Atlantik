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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unSecteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjoutSecteur secteur = new AjoutSecteur();

            secteur.ShowDialog();
        }

        private void mmPort_Click(object sender, EventArgs e)
        {
            AjoutPort port = new AjoutPort();
            port.ShowDialog();
        }

        private void mmliaison_Click(object sender, EventArgs e)
        {
            AjoutLiaison liaison = new AjoutLiaison();
            liaison.ShowDialog();
        }

        private void mmAddBoat_Click(object sender, EventArgs e)
        {
            AjoutBateau bateau = new AjoutBateau();
            bateau.ShowDialog();               
        }

        private void mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutTarifLiaisonPeriode ajoutTarifLiaisonPeriode = new AjoutTarifLiaisonPeriode();
            ajoutTarifLiaisonPeriode.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mmModifierBateau_Click(object sender, EventArgs e)
        {
            ModifBateaucs modifBateaucs = new ModifBateaucs();
            modifBateaucs.ShowDialog();
        }

        private void mmtraverse_Click(object sender, EventArgs e)
        {
            AjoutTraversé traverse = new AjoutTraversé();
            traverse.ShowDialog();
        }

        private void mmAfficherTraverse_Click(object sender, EventArgs e)
        {
            Affichertraverse traverse = new Affichertraverse();
            traverse.ShowDialog();
        }

        private void mmDetailReservClients_Click(object sender, EventArgs e)
        {
            AfficherReservationClients afficherReservationClients = new AfficherReservationClients();
            afficherReservationClients.ShowDialog();
        }
    }
}
