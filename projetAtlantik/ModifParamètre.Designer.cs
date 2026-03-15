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
            this.gbxIdentifiant = new System.Windows.Forms.GroupBox();
            this.lblmel = new System.Windows.Forms.Label();
            this.tbxMel = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.cbxProd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // gbxIdentifiant
            // 
            this.gbxIdentifiant.Location = new System.Drawing.Point(12, 12);
            this.gbxIdentifiant.Name = "gbxIdentifiant";
            this.gbxIdentifiant.Size = new System.Drawing.Size(603, 358);
            this.gbxIdentifiant.TabIndex = 0;
            this.gbxIdentifiant.TabStop = false;
            this.gbxIdentifiant.Text = "Identifiants";
            this.gbxIdentifiant.Enter += new System.EventHandler(this.gbxIdentifiant_Enter);
            // 
            // lblmel
            // 
            this.lblmel.AutoSize = true;
            this.lblmel.Location = new System.Drawing.Point(427, 421);
            this.lblmel.Name = "lblmel";
            this.lblmel.Size = new System.Drawing.Size(52, 13);
            this.lblmel.TabIndex = 1;
            this.lblmel.Text = "Mél site : ";
            // 
            // tbxMel
            // 
            this.tbxMel.Location = new System.Drawing.Point(515, 421);
            this.tbxMel.Name = "tbxMel";
            this.tbxMel.Size = new System.Drawing.Size(170, 20);
            this.tbxMel.TabIndex = 2;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(430, 472);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(255, 23);
            this.btnModif.TabIndex = 3;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // cbxProd
            // 
            this.cbxProd.AutoSize = true;
            this.cbxProd.Location = new System.Drawing.Point(515, 386);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(95, 17);
            this.cbxProd.TabIndex = 4;
            this.cbxProd.Text = "En production ";
            this.cbxProd.UseVisualStyleBackColor = true;
            // 
            // ModifParamètre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.cbxProd);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.tbxMel);
            this.Controls.Add(this.lblmel);
            this.Controls.Add(this.gbxIdentifiant);
            this.Name = "ModifParamètre";
            this.Text = "ModifParamètre";
            this.Load += new System.EventHandler(this.ModifParamètre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIdentifiant;
        private System.Windows.Forms.Label lblmel;
        private System.Windows.Forms.TextBox tbxMel;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.CheckBox cbxProd;
    }
}