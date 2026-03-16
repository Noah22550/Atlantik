namespace projetAtlantik
{
    partial class AjoutTraversé
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
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblbateau = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.btnaddtraverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateDepart
            // 
            this.dateDepart.Location = new System.Drawing.Point(425, 254);
            this.dateDepart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(200, 22);
            this.dateDepart.TabIndex = 0;
            this.dateDepart.ValueChanged += new System.EventHandler(this.dateDepart_ValueChanged);
            this.dateDepart.Validating += new System.ComponentModel.CancelEventHandler(this.dateDepart_Validating);
            // 
            // dateArrivee
            // 
            this.dateArrivee.Location = new System.Drawing.Point(425, 282);
            this.dateArrivee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(200, 22);
            this.dateArrivee.TabIndex = 1;
            this.dateArrivee.Value = new System.DateTime(2026, 3, 7, 14, 0, 4, 0);
            this.dateArrivee.ValueChanged += new System.EventHandler(this.dateArrivee_ValueChanged);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(12, 327);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(50, 16);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison";
            // 
            // lblbateau
            // 
            this.lblbateau.AutoSize = true;
            this.lblbateau.Location = new System.Drawing.Point(399, 39);
            this.lblbateau.Name = "lblbateau";
            this.lblbateau.Size = new System.Drawing.Size(82, 16);
            this.lblbateau.TabIndex = 4;
            this.lblbateau.Text = "Nom Bateau";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(12, 25);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(53, 16);
            this.lblSecteur.TabIndex = 5;
            this.lblSecteur.Text = "Secteur";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Location = new System.Drawing.Point(251, 288);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(124, 16);
            this.lblArrivee.TabIndex = 6;
            this.lblArrivee.Text = "Date et heure arrivé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date et heure de départ ";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 16;
            this.lbxSecteur.Location = new System.Drawing.Point(12, 44);
            this.lbxSecteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(135, 260);
            this.lbxSecteur.TabIndex = 8;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(15, 361);
            this.cmbLiaison.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(132, 24);
            this.cmbLiaison.TabIndex = 9;
            this.cmbLiaison.SelectedIndexChanged += new System.EventHandler(this.cmbLiaison_SelectedIndexChanged);
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(496, 36);
            this.cmbBateau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(132, 24);
            this.cmbBateau.TabIndex = 10;
            this.cmbBateau.SelectedIndexChanged += new System.EventHandler(this.cmbBateau_SelectedIndexChanged);
            // 
            // btnaddtraverse
            // 
            this.btnaddtraverse.Location = new System.Drawing.Point(372, 362);
            this.btnaddtraverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddtraverse.Name = "btnaddtraverse";
            this.btnaddtraverse.Size = new System.Drawing.Size(107, 23);
            this.btnaddtraverse.TabIndex = 11;
            this.btnaddtraverse.Text = "Ajouter !";
            this.btnaddtraverse.UseVisualStyleBackColor = true;
            this.btnaddtraverse.Click += new System.EventHandler(this.btnaddtraverse_Click);
            // 
            // AjoutTraversé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaddtraverse);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lbxSecteur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lblbateau);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.dateDepart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjoutTraversé";
            this.Text = "AjoutTraversé";
            this.Load += new System.EventHandler(this.AjoutTraversé_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblbateau;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Button btnaddtraverse;
    }
}