namespace _12_WFA_KursTakipSistemi
{
    partial class bolumAtama
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
            this.cmbBolumler = new System.Windows.Forms.ComboBox();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.btnAta = new System.Windows.Forms.Button();
            this.lstwListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbBolumler
            // 
            this.cmbBolumler.FormattingEnabled = true;
            this.cmbBolumler.Location = new System.Drawing.Point(24, 33);
            this.cmbBolumler.Name = "cmbBolumler";
            this.cmbBolumler.Size = new System.Drawing.Size(631, 21);
            this.cmbBolumler.TabIndex = 0;
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(24, 65);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(631, 21);
            this.cmbOgrenciler.TabIndex = 0;
            // 
            // btnAta
            // 
            this.btnAta.Location = new System.Drawing.Point(516, 94);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(138, 34);
            this.btnAta.TabIndex = 1;
            this.btnAta.Text = "ÖĞRENCİ ATA";
            this.btnAta.UseVisualStyleBackColor = true;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);
            // 
            // lstwListe
            // 
            this.lstwListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstwListe.Location = new System.Drawing.Point(24, 135);
            this.lstwListe.Name = "lstwListe";
            this.lstwListe.Size = new System.Drawing.Size(630, 170);
            this.lstwListe.TabIndex = 2;
            this.lstwListe.UseCompatibleStateImageBehavior = false;
            this.lstwListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğrenci Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bölüm Adı";
            // 
            // bolumAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 312);
            this.Controls.Add(this.lstwListe);
            this.Controls.Add(this.btnAta);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.cmbBolumler);
            this.Name = "bolumAtama";
            this.Text = "Öğrenciye Bölüm Atama İşlemleri";
            this.Load += new System.EventHandler(this.bolumAtama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBolumler;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.Button btnAta;
        private System.Windows.Forms.ListView lstwListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}