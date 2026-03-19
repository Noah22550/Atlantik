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
            this.components = new System.ComponentModel.Container();
            this.lblAddBoat = new System.Windows.Forms.Label();
            this.tbxAddBoat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxboat = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddBoat
            // 
            this.lblAddBoat.AutoSize = true;
            this.lblAddBoat.Location = new System.Drawing.Point(32, 47);
            this.lblAddBoat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBoat.Name = "lblAddBoat";
            this.lblAddBoat.Size = new System.Drawing.Size(99, 16);
            this.lblAddBoat.TabIndex = 0;
            this.lblAddBoat.Text = "Nom du bateau";
            // 
            // tbxAddBoat
            // 
            this.tbxAddBoat.Location = new System.Drawing.Point(163, 43);
            this.tbxAddBoat.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddBoat.Name = "tbxAddBoat";
            this.tbxAddBoat.Size = new System.Drawing.Size(192, 22);
            this.tbxAddBoat.TabIndex = 1;
            this.tbxAddBoat.TextChanged += new System.EventHandler(this.tbxAddBoat_TextChanged);
            this.tbxAddBoat.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAddBoat_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 316);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxboat
            // 
            this.gbxboat.Location = new System.Drawing.Point(455, 43);
            this.gbxboat.Margin = new System.Windows.Forms.Padding(4);
            this.gbxboat.Name = "gbxboat";
            this.gbxboat.Padding = new System.Windows.Forms.Padding(4);
            this.gbxboat.Size = new System.Drawing.Size(371, 302);
            this.gbxboat.TabIndex = 3;
            this.gbxboat.TabStop = false;
            this.gbxboat.Text = "groupBox1";
            this.gbxboat.TextChanged += new System.EventHandler(this.tbxAddBoat_TextChanged);
            this.gbxboat.Enter += new System.EventHandler(this.gbxboat_Enter);
            this.gbxboat.Validating += new System.ComponentModel.CancelEventHandler(this.gbxboat_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // AjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 492);
            this.Controls.Add(this.gbxboat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxAddBoat);
            this.Controls.Add(this.lblAddBoat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjoutBateau";
            this.Text = "Ajout d\'un bateau";
            this.Load += new System.EventHandler(this.AjoutBateau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBoat;
        private System.Windows.Forms.TextBox tbxAddBoat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxboat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}