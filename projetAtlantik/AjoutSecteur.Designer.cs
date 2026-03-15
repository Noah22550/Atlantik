namespace projetAtlantik
{
    partial class AjoutSecteur
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
            this.btnadd = new System.Windows.Forms.Button();
            this.tbxadd = new System.Windows.Forms.TextBox();
            this.lbladd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(281, 125);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tbxadd
            // 
            this.tbxadd.Location = new System.Drawing.Point(96, 125);
            this.tbxadd.Name = "tbxadd";
            this.tbxadd.Size = new System.Drawing.Size(179, 20);
            this.tbxadd.TabIndex = 1;
            this.tbxadd.TextChanged += new System.EventHandler(this.tbxadd_TextChanged);
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(93, 98);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(88, 13);
            this.lbladd.TabIndex = 2;
            this.lbladd.Text = "Nom du secteur :";
            this.lbladd.Click += new System.EventHandler(this.lbladd_Click);
            // 
            // AjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 310);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.tbxadd);
            this.Controls.Add(this.btnadd);
            this.Name = "AjoutSecteur";
            this.Text = "AjoutSecteur";
            this.Load += new System.EventHandler(this.AjoutSecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox tbxadd;
        private System.Windows.Forms.Label lbladd;
    }
}