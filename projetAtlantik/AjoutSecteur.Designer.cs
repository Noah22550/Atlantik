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
            this.components = new System.ComponentModel.Container();
            this.btnadd = new System.Windows.Forms.Button();
            this.tbxAjoutSecteur = new System.Windows.Forms.TextBox();
            this.lbladd = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(375, 154);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tbxAjoutSecteur
            // 
            this.tbxAjoutSecteur.Location = new System.Drawing.Point(128, 154);
            this.tbxAjoutSecteur.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAjoutSecteur.Name = "tbxAjoutSecteur";
            this.tbxAjoutSecteur.Size = new System.Drawing.Size(237, 22);
            this.tbxAjoutSecteur.TabIndex = 1;
            this.tbxAjoutSecteur.TextChanged += new System.EventHandler(this.tbxadd_TextChanged);
            this.tbxAjoutSecteur.Validating += new System.ComponentModel.CancelEventHandler(this.tbxadd_Validating);
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(124, 121);
            this.lbladd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(107, 16);
            this.lbladd.TabIndex = 2;
            this.lbladd.Text = "Nom du secteur :";
            this.lbladd.Click += new System.EventHandler(this.lbladd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 382);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.tbxAjoutSecteur);
            this.Controls.Add(this.btnadd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjoutSecteur";
            this.Text = "AjoutSecteur";
            this.Load += new System.EventHandler(this.AjoutSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox tbxAjoutSecteur;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}