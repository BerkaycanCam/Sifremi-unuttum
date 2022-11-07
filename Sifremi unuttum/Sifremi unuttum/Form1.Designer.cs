
namespace Sifremi_unuttum
{
    partial class Form1
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
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblSifregir = new System.Windows.Forms.Label();
            this.tbxKullanıcıadi = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(50, 104);
            this.lblkullaniciadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(119, 23);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // lblSifregir
            // 
            this.lblSifregir.AutoSize = true;
            this.lblSifregir.Location = new System.Drawing.Point(109, 156);
            this.lblSifregir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifregir.Name = "lblSifregir";
            this.lblSifregir.Size = new System.Drawing.Size(53, 23);
            this.lblSifregir.TabIndex = 1;
            this.lblSifregir.Text = "Şifre:";
            // 
            // tbxKullanıcıadi
            // 
            this.tbxKullanıcıadi.Location = new System.Drawing.Point(179, 101);
            this.tbxKullanıcıadi.Name = "tbxKullanıcıadi";
            this.tbxKullanıcıadi.Size = new System.Drawing.Size(251, 30);
            this.tbxKullanıcıadi.TabIndex = 2;
            this.tbxKullanıcıadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(179, 153);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.PasswordChar = '*';
            this.tbxSifre.Size = new System.Drawing.Size(251, 30);
            this.tbxSifre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(303, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(465, 160);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxKullanıcıadi);
            this.Controls.Add(this.lblSifregir);
            this.Controls.Add(this.lblkullaniciadi);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "şifremiunuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label lblSifregir;
        private System.Windows.Forms.TextBox tbxKullanıcıadi;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

