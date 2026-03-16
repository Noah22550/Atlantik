namespace projetAtlantik
{
    partial class AjoutTarifLiaisonPeriode
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
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblsecteur = new System.Windows.Forms.Label();
            this.cbxLiaison = new System.Windows.Forms.ComboBox();
            this.gbxTarifs = new System.Windows.Forms.GroupBox();
            this.cbxPeriode = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 16;
            this.lbxSecteur.Location = new System.Drawing.Point(45, 42);
            this.lbxSecteur.Margin = new System.Windows.Forms.Padding(4);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(159, 404);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblsecteur
            // 
            this.lblsecteur.AutoSize = true;
            this.lblsecteur.Location = new System.Drawing.Point(41, 22);
            this.lblsecteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsecteur.Name = "lblsecteur";
            this.lblsecteur.Size = new System.Drawing.Size(69, 16);
            this.lblsecteur.TabIndex = 1;
            this.lblsecteur.Text = "Secteurs : ";
            // 
            // cbxLiaison
            // 
            this.cbxLiaison.FormattingEnabled = true;
            this.cbxLiaison.Location = new System.Drawing.Point(132, 466);
            this.cbxLiaison.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLiaison.Name = "cbxLiaison";
            this.cbxLiaison.Size = new System.Drawing.Size(160, 24);
            this.cbxLiaison.TabIndex = 2;
            this.cbxLiaison.SelectedIndexChanged += new System.EventHandler(this.cbxLiaison_SelectedIndexChanged);
            // 
            // gbxTarifs
            // 
            this.gbxTarifs.Location = new System.Drawing.Point(563, 22);
            this.gbxTarifs.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTarifs.Name = "gbxTarifs";
            this.gbxTarifs.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTarifs.Size = new System.Drawing.Size(472, 390);
            this.gbxTarifs.TabIndex = 3;
            this.gbxTarifs.TabStop = false;
            this.gbxTarifs.Text = "Tarifs";
            this.gbxTarifs.TextChanged += new System.EventHandler(this.gbxTarifs_TextChanged);
            this.gbxTarifs.Enter += new System.EventHandler(this.gbxTarifs_Enter);
            this.gbxTarifs.Validating += new System.ComponentModel.CancelEventHandler(this.gbxTarifs_Validating);
            // 
            // cbxPeriode
            // 
            this.cbxPeriode.FormattingEnabled = true;
            this.cbxPeriode.Location = new System.Drawing.Point(380, 466);
            this.cbxPeriode.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPeriode.Name = "cbxPeriode";
            this.cbxPeriode.Size = new System.Drawing.Size(459, 24);
            this.cbxPeriode.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(848, 466);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(187, 28);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(41, 466);
            this.lblLiaison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(50, 16);
            this.lblLiaison.TabIndex = 6;
            this.lblLiaison.Text = "Liaison";
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(315, 473);
            this.lblPeriode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(55, 16);
            this.lblPeriode.TabIndex = 7;
            this.lblPeriode.Text = "Periode";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AjoutTarifLiaisonPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbxPeriode);
            this.Controls.Add(this.gbxTarifs);
            this.Controls.Add(this.cbxLiaison);
            this.Controls.Add(this.lblsecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjoutTarifLiaisonPeriode";
            this.Text = "AjoutTarifLiaisonPeriode";
            this.Load += new System.EventHandler(this.AjoutTarifLiaisonPeriode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblsecteur;
        private System.Windows.Forms.ComboBox cbxLiaison;
        private System.Windows.Forms.GroupBox gbxTarifs;
        private System.Windows.Forms.ComboBox cbxPeriode;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}