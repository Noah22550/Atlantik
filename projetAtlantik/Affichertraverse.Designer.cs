namespace projetAtlantik
{
    partial class Affichertraverse
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
            this.lvTraverse = new System.Windows.Forms.ListView();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.cbxLiaison = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.dateafficher = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblsecteur = new System.Windows.Forms.Label();
            this.lblDispo = new System.Windows.Forms.Label();
            this.lblTraverse = new System.Windows.Forms.Label();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvTraverse
            // 
            this.lvTraverse.HideSelection = false;
            this.lvTraverse.Location = new System.Drawing.Point(169, 213);
            this.lvTraverse.Name = "lvTraverse";
            this.lvTraverse.Size = new System.Drawing.Size(619, 225);
            this.lvTraverse.TabIndex = 0;
            this.lvTraverse.UseCompatibleStateImageBehavior = false;
            this.lvTraverse.SelectedIndexChanged += new System.EventHandler(this.lvTraverse_SelectedIndexChanged);
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(12, 50);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 225);
            this.lbxSecteur.TabIndex = 1;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // cbxLiaison
            // 
            this.cbxLiaison.FormattingEnabled = true;
            this.cbxLiaison.Location = new System.Drawing.Point(12, 340);
            this.cbxLiaison.Name = "cbxLiaison";
            this.cbxLiaison.Size = new System.Drawing.Size(121, 21);
            this.cbxLiaison.TabIndex = 2;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(273, 126);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(233, 23);
            this.btnAfficher.TabIndex = 3;
            this.btnAfficher.Text = "Afficher les traversées";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // dateafficher
            // 
            this.dateafficher.CustomFormat = "yyyy-MM-dd";
            this.dateafficher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateafficher.Location = new System.Drawing.Point(505, 50);
            this.dateafficher.Name = "dateafficher";
            this.dateafficher.Size = new System.Drawing.Size(200, 20);
            this.dateafficher.TabIndex = 4;
            this.dateafficher.Value = new System.DateTime(2021, 3, 10, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(451, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblsecteur
            // 
            this.lblsecteur.AutoSize = true;
            this.lblsecteur.Location = new System.Drawing.Point(12, 25);
            this.lblsecteur.Name = "lblsecteur";
            this.lblsecteur.Size = new System.Drawing.Size(49, 13);
            this.lblsecteur.TabIndex = 6;
            this.lblsecteur.Text = "Secteurs";
            // 
            // lblDispo
            // 
            this.lblDispo.AutoSize = true;
            this.lblDispo.Location = new System.Drawing.Point(451, 197);
            this.lblDispo.Name = "lblDispo";
            this.lblDispo.Size = new System.Drawing.Size(154, 13);
            this.lblDispo.TabIndex = 7;
            this.lblDispo.Text = "Places disponible par catégorie";
            // 
            // lblTraverse
            // 
            this.lblTraverse.AutoSize = true;
            this.lblTraverse.Location = new System.Drawing.Point(166, 197);
            this.lblTraverse.Name = "lblTraverse";
            this.lblTraverse.Size = new System.Drawing.Size(55, 13);
            this.lblTraverse.TabIndex = 8;
            this.lblTraverse.Text = "Traversée";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(12, 308);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(40, 13);
            this.lblLiaison.TabIndex = 9;
            this.lblLiaison.Text = "Liaison";
            // 
            // Affichertraverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblTraverse);
            this.Controls.Add(this.lblDispo);
            this.Controls.Add(this.lblsecteur);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateafficher);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.cbxLiaison);
            this.Controls.Add(this.lbxSecteur);
            this.Controls.Add(this.lvTraverse);
            this.Name = "Affichertraverse";
            this.Text = "Affichertraverse";
            this.Load += new System.EventHandler(this.Affichertraverse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTraverse;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.ComboBox cbxLiaison;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DateTimePicker dateafficher;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblsecteur;
        private System.Windows.Forms.Label lblDispo;
        private System.Windows.Forms.Label lblTraverse;
        private System.Windows.Forms.Label lblLiaison;
    }
}