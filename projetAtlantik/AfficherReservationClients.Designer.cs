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
            this.SuspendLayout();
            // 
            // lvAfficherRes
            // 
            this.lvAfficherRes.HideSelection = false;
            this.lvAfficherRes.Location = new System.Drawing.Point(353, 203);
            this.lvAfficherRes.Name = "lvAfficherRes";
            this.lvAfficherRes.Size = new System.Drawing.Size(435, 235);
            this.lvAfficherRes.TabIndex = 0;
            this.lvAfficherRes.UseCompatibleStateImageBehavior = false;
            this.lvAfficherRes.SelectedIndexChanged += new System.EventHandler(this.lvAfficherRes_SelectedIndexChanged);
            // 
            // gbxAfficher
            // 
            this.gbxAfficher.Location = new System.Drawing.Point(348, 12);
            this.gbxAfficher.Name = "gbxAfficher";
            this.gbxAfficher.Size = new System.Drawing.Size(440, 126);
            this.gbxAfficher.TabIndex = 1;
            this.gbxAfficher.TabStop = false;
            this.gbxAfficher.Text = "groupBox1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAfficherRes;
        private System.Windows.Forms.GroupBox gbxAfficher;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblname;
    }
}