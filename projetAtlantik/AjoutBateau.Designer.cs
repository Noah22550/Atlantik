namespace projetAtlantik
{
    partial class AjoutBateau
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
            this.lblAddBoat = new System.Windows.Forms.Label();
            this.tbxAddBoat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblAddBoat
            // 
            this.lblAddBoat.AutoSize = true;
            this.lblAddBoat.Location = new System.Drawing.Point(24, 38);
            this.lblAddBoat.Name = "lblAddBoat";
            this.lblAddBoat.Size = new System.Drawing.Size(80, 13);
            this.lblAddBoat.TabIndex = 0;
            this.lblAddBoat.Text = "Nom du bateau";
            // 
            // tbxAddBoat
            // 
            this.tbxAddBoat.Location = new System.Drawing.Point(122, 35);
            this.tbxAddBoat.Name = "tbxAddBoat";
            this.tbxAddBoat.Size = new System.Drawing.Size(145, 20);
            this.tbxAddBoat.TabIndex = 1;
            this.tbxAddBoat.TextChanged += new System.EventHandler(this.tbxAddBoat_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(367, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bateau";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxAddBoat);
            this.Controls.Add(this.lblAddBoat);
            this.Name = "AjoutBateau";
            this.Text = "Ajout d\'un bateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBoat;
        private System.Windows.Forms.TextBox tbxAddBoat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}