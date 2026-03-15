namespace projetAtlantik
{
    partial class AfficherReservationClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAfficherRes = new System.Windows.Forms.ListView();
            this.gbxAfficher = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblAdulte = new System.Windows.Forms.Label();
            this.lblCarte = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVoiture = new System.Windows.Forms.Label();
            this.lblEnfant = new System.Windows.Forms.Label();
            this.lblJunior = new System.Windows.Forms.Label();
            this.gbxAfficher.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAfficherRes
            // 
            this.lvAfficherRes.HideSelection = false;
            this.lvAfficherRes.Location = new System.Drawing.Point(244, 33);
            this.lvAfficherRes.Name = "lvAfficherRes";
            this.lvAfficherRes.Size = new System.Drawing.Size(528, 122);
            this.lvAfficherRes.TabIndex = 0;
            this.lvAfficherRes.UseCompatibleStateImageBehavior = false;
            this.lvAfficherRes.SelectedIndexChanged += new System.EventHandler(this.lvAfficherRes_SelectedIndexChanged);
            // 
            // gbxAfficher
            // 
            this.gbxAfficher.Controls.Add(this.lblJunior);
            this.gbxAfficher.Controls.Add(this.lblEnfant);
            this.gbxAfficher.Controls.Add(this.lblVoiture);
            this.gbxAfficher.Controls.Add(this.lblTotal);
            this.gbxAfficher.Controls.Add(this.lblCarte);
            this.gbxAfficher.Controls.Add(this.lblAdulte);
            this.gbxAfficher.Location = new System.Drawing.Point(244, 209);
            this.gbxAfficher.Name = "gbxAfficher";
            this.gbxAfficher.Size = new System.Drawing.Size(528, 229);
            this.gbxAfficher.TabIndex = 1;
            this.gbxAfficher.TabStop = false;
            this.gbxAfficher.Text = "Réservation";
            this.gbxAfficher.Enter += new System.EventHandler(this.gbxAfficher_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(27, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(68, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "nom, prenom";
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Location = new System.Drawing.Point(18, 30);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(46, 13);
            this.lblAdulte.TabIndex = 4;
            this.lblAdulte.Text = "Adulte : ";
            // 
            // lblCarte
            // 
            this.lblCarte.AutoSize = true;
            this.lblCarte.Location = new System.Drawing.Point(18, 193);
            this.lblCarte.Name = "lblCarte";
            this.lblCarte.Size = new System.Drawing.Size(124, 13);
            this.lblCarte.TabIndex = 5;
            this.lblCarte.Text = "Réglé par carte bancaire";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(18, 153);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Montant total : ";
            // 
            // lblVoiture
            // 
            this.lblVoiture.AutoSize = true;
            this.lblVoiture.Location = new System.Drawing.Point(18, 125);
            this.lblVoiture.Name = "lblVoiture";
            this.lblVoiture.Size = new System.Drawing.Size(103, 13);
            this.lblVoiture.TabIndex = 7;
            this.lblVoiture.Text = "Voiture long inf 5m : ";
            // 
            // lblEnfant
            // 
            this.lblEnfant.AutoSize = true;
            this.lblEnfant.Location = new System.Drawing.Point(18, 91);
            this.lblEnfant.Name = "lblEnfant";
            this.lblEnfant.Size = new System.Drawing.Size(109, 13);
            this.lblEnfant.TabIndex = 8;
            this.lblEnfant.Text = "Enfant de 0 à 7 ans : ";
            // 
            // lblJunior
            // 
            this.lblJunior.AutoSize = true;
            this.lblJunior.Location = new System.Drawing.Point(18, 58);
            this.lblJunior.Name = "lblJunior";
            this.lblJunior.Size = new System.Drawing.Size(97, 13);
            this.lblJunior.TabIndex = 9;
            this.lblJunior.Text = "Junior 8 à 18 ans : ";
            // 
            // AfficherReservationClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbxAfficher);
            this.Controls.Add(this.lvAfficherRes);
            this.Name = "AfficherReservationClients";
            this.Text = "AfficherReservationClients";
            this.Load += new System.EventHandler(this.AfficherReservationClients_Load);
            this.gbxAfficher.ResumeLayout(false);
            this.gbxAfficher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAfficherRes;
        private System.Windows.Forms.GroupBox gbxAfficher;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblAdulte;
        private System.Windows.Forms.Label lblJunior;
        private System.Windows.Forms.Label lblEnfant;
        private System.Windows.Forms.Label lblVoiture;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCarte;
    }
}