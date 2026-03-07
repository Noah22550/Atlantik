namespace projetAtlantik
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unSecteurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mmPort = new System.Windows.Forms.ToolStripMenuItem();
            this.mmliaison = new System.Windows.Forms.ToolStripMenuItem();
            this.mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAddBoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mmtraverse = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.lesParamètreDuSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAtlantik = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.unSecteurToolStripMenuItem,
            this.unPortToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(148, 76);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // unSecteurToolStripMenuItem
            // 
            this.unSecteurToolStripMenuItem.Name = "unSecteurToolStripMenuItem";
            this.unSecteurToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.unSecteurToolStripMenuItem.Text = "Un secteur";
            // 
            // unPortToolStripMenuItem
            // 
            this.unPortToolStripMenuItem.Name = "unPortToolStripMenuItem";
            this.unPortToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.unPortToolStripMenuItem.Text = "Un Port";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unSecteurToolStripMenuItem1,
            this.mmPort,
            this.mmliaison,
            this.mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem,
            this.mmAddBoat,
            this.mmtraverse});
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // unSecteurToolStripMenuItem1
            // 
            this.unSecteurToolStripMenuItem1.Name = "unSecteurToolStripMenuItem1";
            this.unSecteurToolStripMenuItem1.Size = new System.Drawing.Size(361, 26);
            this.unSecteurToolStripMenuItem1.Text = "Un secteur";
            this.unSecteurToolStripMenuItem1.Click += new System.EventHandler(this.unSecteurToolStripMenuItem1_Click);
            // 
            // mmPort
            // 
            this.mmPort.Name = "mmPort";
            this.mmPort.Size = new System.Drawing.Size(361, 26);
            this.mmPort.Text = "Un port";
            this.mmPort.Click += new System.EventHandler(this.mmPort_Click);
            // 
            // mmliaison
            // 
            this.mmliaison.Name = "mmliaison";
            this.mmliaison.Size = new System.Drawing.Size(361, 26);
            this.mmliaison.Text = "Une liaison";
            this.mmliaison.Click += new System.EventHandler(this.mmliaison_Click);
            // 
            // mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem
            // 
            this.mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem.Name = "mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem";
            this.mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem.Text = "Les tarifs pour une liasion et une période";
            this.mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem.Click += new System.EventHandler(this.mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem_Click);
            // 
            // mmAddBoat
            // 
            this.mmAddBoat.Name = "mmAddBoat";
            this.mmAddBoat.Size = new System.Drawing.Size(361, 26);
            this.mmAddBoat.Text = "Un bateau";
            this.mmAddBoat.Click += new System.EventHandler(this.mmAddBoat_Click);
            // 
            // mmtraverse
            // 
            this.mmtraverse.Name = "mmtraverse";
            this.mmtraverse.Size = new System.Drawing.Size(361, 26);
            this.mmtraverse.Text = "Une traversée";
            this.mmtraverse.Click += new System.EventHandler(this.mmtraverse_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmModifierBateau,
            this.lesParamètreDuSiteToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // mmModifierBateau
            // 
            this.mmModifierBateau.Name = "mmModifierBateau";
            this.mmModifierBateau.Size = new System.Drawing.Size(234, 26);
            this.mmModifierBateau.Text = "Un beateau";
            this.mmModifierBateau.Click += new System.EventHandler(this.mmModifierBateau_Click);
            // 
            // lesParamètreDuSiteToolStripMenuItem
            // 
            this.lesParamètreDuSiteToolStripMenuItem.Name = "lesParamètreDuSiteToolStripMenuItem";
            this.lesParamètreDuSiteToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.lesParamètreDuSiteToolStripMenuItem.Text = "Les paramètre du site";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem,
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem
            // 
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Name = "lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStri" +
    "pMenuItem";
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Size = new System.Drawing.Size(662, 26);
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gorie";
            // 
            // lesDétailDuneRéservationPourUnClientToolStripMenuItem
            // 
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem.Name = "lesDétailDuneRéservationPourUnClientToolStripMenuItem";
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem.Size = new System.Drawing.Size(662, 26);
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem.Text = "Les détail d\'une réservation pour un client";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // lblAtlantik
            // 
            this.lblAtlantik.AutoSize = true;
            this.lblAtlantik.Location = new System.Drawing.Point(463, 30);
            this.lblAtlantik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtlantik.Name = "lblAtlantik";
            this.lblAtlantik.Size = new System.Drawing.Size(127, 16);
            this.lblAtlantik.TabIndex = 4;
            this.lblAtlantik.Text = "bienvenue a Atlantik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblAtlantik);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unPortToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unSecteurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmPort;
        private System.Windows.Forms.ToolStripMenuItem mmliaison;
        private System.Windows.Forms.ToolStripMenuItem mmlesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmAddBoat;
        private System.Windows.Forms.ToolStripMenuItem mmtraverse;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem lesParamètreDuSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesDétailDuneRéservationPourUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label lblAtlantik;
    }
}

