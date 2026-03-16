namespace projetAtlantik
{
    partial class AjoutPort
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
            this.btnaddport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddport
            // 
            this.btnaddport.Location = new System.Drawing.Point(324, 124);
            this.btnaddport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaddport.Name = "btnaddport";
            this.btnaddport.Size = new System.Drawing.Size(100, 28);
            this.btnaddport.TabIndex = 0;
            this.btnaddport.Text = "Ajouter";
            this.btnaddport.UseVisualStyleBackColor = true;
            this.btnaddport.Click += new System.EventHandler(this.btnaddport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 128);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(73, 108);
            this.lblport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(80, 16);
            this.lblport.TabIndex = 2;
            this.lblport.Text = "Nom du port";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 362);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnaddport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AjoutPort";
            this.Text = "AjoutPort";
            this.Load += new System.EventHandler(this.AjoutPort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}