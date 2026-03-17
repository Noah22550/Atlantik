namespace projetAtlantik
{
    partial class ModifParamètre
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
            this.lblmel = new System.Windows.Forms.Label();
            this.tbxMel = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.cbxProd = new System.Windows.Forms.CheckBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblHMAC = new System.Windows.Forms.Label();
            this.lblIdentifiants = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxIdentifiants = new System.Windows.Forms.TextBox();
            this.tbxHmax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblmel
            // 
            this.lblmel.AutoSize = true;
            this.lblmel.Location = new System.Drawing.Point(569, 518);
            this.lblmel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmel.Name = "lblmel";
            this.lblmel.Size = new System.Drawing.Size(62, 16);
            this.lblmel.TabIndex = 1;
            this.lblmel.Text = "Mél site : ";
            // 
            // tbxMel
            // 
            this.tbxMel.Location = new System.Drawing.Point(687, 518);
            this.tbxMel.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMel.Name = "tbxMel";
            this.tbxMel.Size = new System.Drawing.Size(225, 22);
            this.tbxMel.TabIndex = 2;
            this.tbxMel.TextChanged += new System.EventHandler(this.tbxMel_TextChanged);
            this.tbxMel.Validating += new System.ComponentModel.CancelEventHandler(this.tbxMel_Validating);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(573, 581);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(340, 28);
            this.btnModif.TabIndex = 3;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // cbxProd
            // 
            this.cbxProd.AutoSize = true;
            this.cbxProd.Location = new System.Drawing.Point(687, 475);
            this.cbxProd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(114, 20);
            this.cbxProd.TabIndex = 4;
            this.cbxProd.Text = "En production ";
            this.cbxProd.UseVisualStyleBackColor = true;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(97, 48);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(36, 16);
            this.lblSite.TabIndex = 5;
            this.lblSite.Text = "Site :";
            // 
            // lblHMAC
            // 
            this.lblHMAC.AutoSize = true;
            this.lblHMAC.Location = new System.Drawing.Point(97, 205);
            this.lblHMAC.Name = "lblHMAC";
            this.lblHMAC.Size = new System.Drawing.Size(78, 16);
            this.lblHMAC.TabIndex = 6;
            this.lblHMAC.Text = "Clé HMAC : ";
            // 
            // lblIdentifiants
            // 
            this.lblIdentifiants.AutoSize = true;
            this.lblIdentifiants.Location = new System.Drawing.Point(97, 146);
            this.lblIdentifiants.Name = "lblIdentifiants";
            this.lblIdentifiants.Size = new System.Drawing.Size(72, 16);
            this.lblIdentifiants.TabIndex = 7;
            this.lblIdentifiants.Text = "Identifiant : ";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(97, 97);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(49, 16);
            this.lblRang.TabIndex = 8;
            this.lblRang.Text = "Rang : ";
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(240, 48);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(175, 22);
            this.tbxSite.TabIndex = 9;
            this.tbxSite.TextChanged += new System.EventHandler(this.tbxSite_TextChanged);
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(240, 94);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(175, 22);
            this.tbxRang.TabIndex = 10;
            this.tbxRang.TextChanged += new System.EventHandler(this.tbxRang_TextChanged);
            // 
            // tbxIdentifiants
            // 
            this.tbxIdentifiants.Location = new System.Drawing.Point(240, 146);
            this.tbxIdentifiants.Name = "tbxIdentifiants";
            this.tbxIdentifiants.Size = new System.Drawing.Size(175, 22);
            this.tbxIdentifiants.TabIndex = 11;
            this.tbxIdentifiants.TextChanged += new System.EventHandler(this.tbxIdentifiants_TextChanged);
            // 
            // tbxHmax
            // 
            this.tbxHmax.Location = new System.Drawing.Point(240, 205);
            this.tbxHmax.Multiline = true;
            this.tbxHmax.Name = "tbxHmax";
            this.tbxHmax.Size = new System.Drawing.Size(193, 125);
            this.tbxHmax.TabIndex = 12;
            this.tbxHmax.TextChanged += new System.EventHandler(this.tbxHmax_TextChanged);
            // 
            // ModifParamètre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 670);
            this.Controls.Add(this.tbxHmax);
            this.Controls.Add(this.tbxIdentifiants);
            this.Controls.Add(this.tbxRang);
            this.Controls.Add(this.tbxSite);
            this.Controls.Add(this.lblRang);
            this.Controls.Add(this.lblIdentifiants);
            this.Controls.Add(this.lblHMAC);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.cbxProd);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.tbxMel);
            this.Controls.Add(this.lblmel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifParamètre";
            this.Text = "git ";
            this.Load += new System.EventHandler(this.ModifParamètre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmel;
        private System.Windows.Forms.TextBox tbxMel;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.CheckBox cbxProd;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblHMAC;
        private System.Windows.Forms.Label lblIdentifiants;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxIdentifiants;
        private System.Windows.Forms.TextBox tbxHmax;
    }
}