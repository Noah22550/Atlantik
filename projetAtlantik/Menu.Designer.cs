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
            this.lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAddBoat = new System.Windows.Forms.ToolStripMenuItem();
            this.uneTraverséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBeateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.unSecteurToolStripMenuItem,
            this.unPortToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(131, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // unSecteurToolStripMenuItem
            // 
            this.unSecteurToolStripMenuItem.Name = "unSecteurToolStripMenuItem";
            this.unSecteurToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.unSecteurToolStripMenuItem.Text = "Un secteur";
            // 
            // unPortToolStripMenuItem
            // 
            this.unPortToolStripMenuItem.Name = "unPortToolStripMenuItem";
            this.unPortToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.unPortToolStripMenuItem.Text = "Un Port";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unSecteurToolStripMenuItem1,
            this.mmPort,
            this.mmliaison,
            this.lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem,
            this.mmAddBoat,
            this.uneTraverséToolStripMenuItem});
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // unSecteurToolStripMenuItem1
            // 
            this.unSecteurToolStripMenuItem1.Name = "unSecteurToolStripMenuItem1";
            this.unSecteurToolStripMenuItem1.Size = new System.Drawing.Size(287, 22);
            this.unSecteurToolStripMenuItem1.Text = "Un secteur";
            this.unSecteurToolStripMenuItem1.Click += new System.EventHandler(this.unSecteurToolStripMenuItem1_Click);
            // 
            // mmPort
            // 
            this.mmPort.Name = "mmPort";
            this.mmPort.Size = new System.Drawing.Size(287, 22);
            this.mmPort.Text = "Un port";
            this.mmPort.Click += new System.EventHandler(this.mmPort_Click);
            // 
            // mmliaison
            // 
            this.mmliaison.Name = "mmliaison";
            this.mmliaison.Size = new System.Drawing.Size(287, 22);
            this.mmliaison.Text = "Une liaison";
            this.mmliaison.Click += new System.EventHandler(this.mmliaison_Click);
            // 
            // lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem
            // 
            this.lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem.Name = "lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem";
            this.lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem.Text = "Les tarifs pour une liasion et une période";
            // 
            // mmAddBoat
            // 
            this.mmAddBoat.Name = "mmAddBoat";
            this.mmAddBoat.Size = new System.Drawing.Size(287, 22);
            this.mmAddBoat.Text = "Un bateau";
            this.mmAddBoat.Click += new System.EventHandler(this.mmAddBoat_Click);
            // 
            // uneTraverséToolStripMenuItem
            // 
            this.uneTraverséToolStripMenuItem.Name = "uneTraverséToolStripMenuItem";
            this.uneTraverséToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.uneTraverséToolStripMenuItem.Text = "Une traversée";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unBeateauToolStripMenuItem,
            this.lesParamètreDuSiteToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // unBeateauToolStripMenuItem
            // 
            this.unBeateauToolStripMenuItem.Name = "unBeateauToolStripMenuItem";
            this.unBeateauToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.unBeateauToolStripMenuItem.Text = "Un beateau";
            // 
            // lesParamètreDuSiteToolStripMenuItem
            // 
            this.lesParamètreDuSiteToolStripMenuItem.Name = "lesParamètreDuSiteToolStripMenuItem";
            this.lesParamètreDuSiteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.lesParamètreDuSiteToolStripMenuItem.Text = "Les paramètre du site";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem,
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem
            // 
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Name = "lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStri" +
    "pMenuItem";
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Size = new System.Drawing.Size(524, 22);
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gorie";
            // 
            // lesDétailDuneRéservationPourUnClientToolStripMenuItem
            // 
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem.Name = "lesDétailDuneRéservationPourUnClientToolStripMenuItem";
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem.Size = new System.Drawing.Size(524, 22);
            this.lesDétailDuneRéservationPourUnClientToolStripMenuItem.Text = "Les détail d\'une réservation pour un client";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // lblAtlantik
            // 
            this.lblAtlantik.AutoSize = true;
            this.lblAtlantik.Location = new System.Drawing.Point(347, 24);
            this.lblAtlantik.Name = "lblAtlantik";
            this.lblAtlantik.Size = new System.Drawing.Size(104, 13);
            this.lblAtlantik.TabIndex = 4;
            this.lblAtlantik.Text = "bienvenue a Atlantik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAtlantik);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Menu";
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
        private System.Windows.Forms.ToolStripMenuItem lesTarifsPourUneLiasionEtUnePériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmAddBoat;
        private System.Windows.Forms.ToolStripMenuItem uneTraverséToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBeateauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesParamètreDuSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesDétailDuneRéservationPourUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label lblAtlantik;
    }
}

