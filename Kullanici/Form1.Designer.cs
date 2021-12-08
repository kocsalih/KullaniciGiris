
namespace Kullanici
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
            this.lbnKullanici = new System.Windows.Forms.Label();
            this.lbnSifre = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnKullanici
            // 
            this.lbnKullanici.AutoSize = true;
            this.lbnKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbnKullanici.Location = new System.Drawing.Point(165, 79);
            this.lbnKullanici.Name = "lbnKullanici";
            this.lbnKullanici.Size = new System.Drawing.Size(94, 25);
            this.lbnKullanici.TabIndex = 0;
            this.lbnKullanici.Text = "Kullanici";
            this.lbnKullanici.Click += new System.EventHandler(this.lbnKullanici_Click);
            // 
            // lbnSifre
            // 
            this.lbnSifre.AutoSize = true;
            this.lbnSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbnSifre.Location = new System.Drawing.Point(165, 114);
            this.lbnSifre.Name = "lbnSifre";
            this.lbnSifre.Size = new System.Drawing.Size(57, 25);
            this.lbnSifre.TabIndex = 1;
            this.lbnSifre.Text = "Şifre";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(265, 79);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(112, 22);
            this.txtKullanici.TabIndex = 2;
            this.txtKullanici.TextChanged += new System.EventHandler(this.txtKullanici_TextChanged);
            this.txtKullanici.Enter += new System.EventHandler(this.txtKullanici_Enter);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSifre.Location = new System.Drawing.Point(265, 117);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(112, 23);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(170, 155);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(207, 33);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 315);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lbnSifre);
            this.Controls.Add(this.lbnKullanici);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnKullanici;
        private System.Windows.Forms.Label lbnSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
    }
}

