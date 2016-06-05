namespace _12_WFA_KursTakipSistemi
{
    partial class bolumTanimlari
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
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.lstBolumler = new System.Windows.Forms.ListBox();
            this.btnBolumSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(335, 78);
            this.btnBolumEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(177, 32);
            this.btnBolumEkle.TabIndex = 0;
            this.btnBolumEkle.Text = "BÖLÜM EKLE";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(16, 46);
            this.txtBolumAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(495, 23);
            this.txtBolumAdi.TabIndex = 1;
            this.txtBolumAdi.TextChanged += new System.EventHandler(this.txtBolumAdi_TextChanged);
            // 
            // lstBolumler
            // 
            this.lstBolumler.FormattingEnabled = true;
            this.lstBolumler.ItemHeight = 16;
            this.lstBolumler.Location = new System.Drawing.Point(2, 118);
            this.lstBolumler.Margin = new System.Windows.Forms.Padding(4);
            this.lstBolumler.Name = "lstBolumler";
            this.lstBolumler.Size = new System.Drawing.Size(510, 132);
            this.lstBolumler.TabIndex = 2;
            // 
            // btnBolumSil
            // 
            this.btnBolumSil.Location = new System.Drawing.Point(335, 258);
            this.btnBolumSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnBolumSil.Name = "btnBolumSil";
            this.btnBolumSil.Size = new System.Drawing.Size(177, 32);
            this.btnBolumSil.TabIndex = 0;
            this.btnBolumSil.Text = "BÖLÜM SİL";
            this.btnBolumSil.UseVisualStyleBackColor = true;
            this.btnBolumSil.Click += new System.EventHandler(this.btnBolumSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bir Bölüm Adı Giriniz...";
            // 
            // bolumTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBolumler);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.btnBolumSil);
            this.Controls.Add(this.btnBolumEkle);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bolumTanimlari";
            this.Text = "Bölüm Tanımlama Formu";
            this.Load += new System.EventHandler(this.bolumTanimlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.ListBox lstBolumler;
        private System.Windows.Forms.Button btnBolumSil;
        private System.Windows.Forms.Label label1;
    }
}