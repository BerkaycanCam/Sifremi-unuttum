
namespace Sifremi_unuttum
{
    partial class Resetle
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gö = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxYeniSifre = new System.Windows.Forms.TextBox();
            this.tbxTekrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni şifre:";
            // 
            // Gö
            // 
            this.Gö.Location = new System.Drawing.Point(380, 116);
            this.Gö.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gö.Name = "Gö";
            this.Gö.Size = new System.Drawing.Size(106, 30);
            this.Gö.TabIndex = 6;
            this.Gö.Text = "Kaydet";
            this.Gö.UseVisualStyleBackColor = true;
            this.Gö.Click += new System.EventHandler(this.Gö_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre tekrar:";
            // 
            // tbxYeniSifre
            // 
            this.tbxYeniSifre.Location = new System.Drawing.Point(157, 73);
            this.tbxYeniSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxYeniSifre.Name = "tbxYeniSifre";
            this.tbxYeniSifre.PasswordChar = '*';
            this.tbxYeniSifre.Size = new System.Drawing.Size(200, 30);
            this.tbxYeniSifre.TabIndex = 8;
            // 
            // tbxTekrar
            // 
            this.tbxTekrar.Location = new System.Drawing.Point(157, 113);
            this.tbxTekrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTekrar.Name = "tbxTekrar";
            this.tbxTekrar.PasswordChar = '*';
            this.tbxTekrar.Size = new System.Drawing.Size(200, 30);
            this.tbxTekrar.TabIndex = 9;
            // 
            // Resetle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 583);
            this.Controls.Add(this.tbxTekrar);
            this.Controls.Add(this.tbxYeniSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gö);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Resetle";
            this.Text = "Resetle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gö;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxYeniSifre;
        private System.Windows.Forms.TextBox tbxTekrar;
    }
}