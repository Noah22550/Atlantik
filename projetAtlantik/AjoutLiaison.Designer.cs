namespace projetAtlantik
{
    partial class AjoutLiaison
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
            this.lbxliaison = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cmbdepart = new System.Windows.Forms.ComboBox();
            this.cmbArrive = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblsecteur = new System.Windows.Forms.Label();
            this.lblarrive = new System.Windows.Forms.Label();
            this.lbldepart = new System.Windows.Forms.Label();
            this.lbldistance = new System.Windows.Forms.Label();
            this.btnAddLiaison = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxliaison
            // 
            this.lbxliaison.FormattingEnabled = true;
            this.lbxliaison.ItemHeight = 16;
            this.lbxliaison.Location = new System.Drawing.Point(16, 52);
            this.lbxliaison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxliaison.Name = "lbxliaison";
            this.lbxliaison.Size = new System.Drawing.Size(159, 324);
            this.lbxliaison.TabIndex = 0;
            this.lbxliaison.SelectedIndexChanged += new System.EventHandler(this.lbxliaison_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(229, 74);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(20, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // cmbdepart
            // 
            this.cmbdepart.FormattingEnabled = true;
            this.cmbdepart.Location = new System.Drawing.Point(415, 74);
            this.cmbdepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbdepart.Name = "cmbdepart";
            this.cmbdepart.Size = new System.Drawing.Size(160, 24);
            this.cmbdepart.TabIndex = 2;
            this.cmbdepart.SelectedIndexChanged += new System.EventHandler(this.cmbdepart_SelectedIndexChanged);
            // 
            // cmbArrive
            // 
            this.cmbArrive.FormattingEnabled = true;
            this.cmbArrive.Location = new System.Drawing.Point(744, 74);
            this.cmbArrive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbArrive.Name = "cmbArrive";
            this.cmbArrive.Size = new System.Drawing.Size(160, 24);
            this.cmbArrive.TabIndex = 3;
            this.cmbArrive.SelectedIndexChanged += new System.EventHandler(this.cmbArrive_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(735, 329);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // lblsecteur
            // 
            this.lblsecteur.AutoSize = true;
            this.lblsecteur.Location = new System.Drawing.Point(16, 32);
            this.lblsecteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsecteur.Name = "lblsecteur";
            this.lblsecteur.Size = new System.Drawing.Size(59, 16);
            this.lblsecteur.TabIndex = 5;
            this.lblsecteur.Text = "Secteur ;";
            // 
            // lblarrive
            // 
            this.lblarrive.AutoSize = true;
            this.lblarrive.Location = new System.Drawing.Point(675, 78);
            this.lblarrive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarrive.Name = "lblarrive";
            this.lblarrive.Size = new System.Drawing.Size(56, 16);
            this.lblarrive.TabIndex = 6;
            this.lblarrive.Text = "Arrivée :";
            // 
            // lbldepart
            // 
            this.lbldepart.AutoSize = true;
            this.lbldepart.Location = new System.Drawing.Point(347, 78);
            this.lbldepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldepart.Name = "lbldepart";
            this.lbldepart.Size = new System.Drawing.Size(54, 16);
            this.lbldepart.TabIndex = 7;
            this.lbldepart.Text = "Depart :";
            // 
            // lbldistance
            // 
            this.lbldistance.AutoSize = true;
            this.lbldistance.Location = new System.Drawing.Point(637, 329);
            this.lbldistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldistance.Name = "lbldistance";
            this.lbldistance.Size = new System.Drawing.Size(66, 16);
            this.lbldistance.TabIndex = 8;
            this.lbldistance.Text = "Distance :";
            // 
            // btnAddLiaison
            // 
            this.btnAddLiaison.Location = new System.Drawing.Point(768, 423);
            this.btnAddLiaison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLiaison.Name = "btnAddLiaison";
            this.btnAddLiaison.Size = new System.Drawing.Size(100, 28);
            this.btnAddLiaison.TabIndex = 9;
            this.btnAddLiaison.Text = "Ajouter !";
            this.btnAddLiaison.UseVisualStyleBackColor = true;
            this.btnAddLiaison.Click += new System.EventHandler(this.btnAddLiaison_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AjoutLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAddLiaison);
            this.Controls.Add(this.lbldistance);
            this.Controls.Add(this.lbldepart);
            this.Controls.Add(this.lblarrive);
            this.Controls.Add(this.lblsecteur);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbArrive);
            this.Controls.Add(this.cmbdepart);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbxliaison);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AjoutLiaison";
            this.Text = "Ajout d\'une liaison";
            this.Load += new System.EventHandler(this.AjoutLiaison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxliaison;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cmbdepart;
        private System.Windows.Forms.ComboBox cmbArrive;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblsecteur;
        private System.Windows.Forms.Label lblarrive;
        private System.Windows.Forms.Label lbldepart;
        private System.Windows.Forms.Label lbldistance;
        private System.Windows.Forms.Button btnAddLiaison;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}