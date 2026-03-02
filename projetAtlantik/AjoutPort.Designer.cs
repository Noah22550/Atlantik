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
            this.btnaddport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddport
            // 
            this.btnaddport.Location = new System.Drawing.Point(243, 101);
            this.btnaddport.Name = "btnaddport";
            this.btnaddport.Size = new System.Drawing.Size(75, 23);
            this.btnaddport.TabIndex = 0;
            this.btnaddport.Text = "Ajouter";
            this.btnaddport.UseVisualStyleBackColor = true;
            this.btnaddport.Click += new System.EventHandler(this.btnaddport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(55, 88);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(65, 13);
            this.lblport.TabIndex = 2;
            this.lblport.Text = "Nom du port";
            // 
            // AjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 294);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnaddport);
            this.Name = "AjoutPort";
            this.Text = "AjoutPort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblport;
    }
}