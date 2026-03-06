namespace projetAtlantik
{
    partial class ModifBateaucs
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
            this.lblmodif = new System.Windows.Forms.Label();
            this.cmbmodifbateau = new System.Windows.Forms.ComboBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.gbxmodifbateau = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblmodif
            // 
            this.lblmodif.AutoSize = true;
            this.lblmodif.Location = new System.Drawing.Point(27, 48);
            this.lblmodif.Name = "lblmodif";
            this.lblmodif.Size = new System.Drawing.Size(99, 16);
            this.lblmodif.TabIndex = 1;
            this.lblmodif.Text = "Nom du bateau";
            // 
            // cmbmodifbateau
            // 
            this.cmbmodifbateau.FormattingEnabled = true;
            this.cmbmodifbateau.Location = new System.Drawing.Point(169, 48);
            this.cmbmodifbateau.Name = "cmbmodifbateau";
            this.cmbmodifbateau.Size = new System.Drawing.Size(121, 24);
            this.cmbmodifbateau.TabIndex = 2;
            this.cmbmodifbateau.SelectedIndexChanged += new System.EventHandler(this.cmbmodifbateau_SelectedIndexChanged);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(169, 268);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(124, 33);
            this.btnmodifier.TabIndex = 3;
            this.btnmodifier.Text = "Modifier !";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // gbxmodifbateau
            // 
            this.gbxmodifbateau.Location = new System.Drawing.Point(296, 48);
            this.gbxmodifbateau.Name = "gbxmodifbateau";
            this.gbxmodifbateau.Size = new System.Drawing.Size(449, 265);
            this.gbxmodifbateau.TabIndex = 4;
            this.gbxmodifbateau.TabStop = false;
            this.gbxmodifbateau.Text = "Capcité maximales";
            this.gbxmodifbateau.Enter += new System.EventHandler(this.gbxmodifbateau_Enter);
            // 
            // ModifBateaucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 366);
            this.Controls.Add(this.gbxmodifbateau);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.cmbmodifbateau);
            this.Controls.Add(this.lblmodif);
            this.Name = "ModifBateaucs";
            this.Text = "ModifBateaucs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmodif;
        private System.Windows.Forms.ComboBox cmbmodifbateau;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.GroupBox gbxmodifbateau;
    }
}