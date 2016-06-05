namespace _12_WFA_KursTakipSistemi
{
    partial class ogrenciListesi
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
            this.lstwListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öğrenciGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstwListe
            // 
            this.lstwListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstwListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstwListe.FullRowSelect = true;
            this.lstwListe.Location = new System.Drawing.Point(0, 0);
            this.lstwListe.Name = "lstwListe";
            this.lstwListe.Size = new System.Drawing.Size(633, 346);
            this.lstwListe.TabIndex = 0;
            this.lstwListe.UseCompatibleStateImageBehavior = false;
            this.lstwListe.View = System.Windows.Forms.View.Details;
            this.lstwListe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstwListe_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD SOYAD";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TC KİMLİK";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EĞİTİM PROGRAMI";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DOĞUM TARİHİ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADRES";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciGörüntüleToolStripMenuItem,
            this.öğrenciSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // öğrenciGörüntüleToolStripMenuItem
            // 
            this.öğrenciGörüntüleToolStripMenuItem.Name = "öğrenciGörüntüleToolStripMenuItem";
            this.öğrenciGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.öğrenciGörüntüleToolStripMenuItem.Text = "Öğrenci Görüntüle";
            // 
            // öğrenciSilToolStripMenuItem
            // 
            this.öğrenciSilToolStripMenuItem.Name = "öğrenciSilToolStripMenuItem";
            this.öğrenciSilToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.öğrenciSilToolStripMenuItem.Text = "Öğrenci Sil";
            this.öğrenciSilToolStripMenuItem.Click += new System.EventHandler(this.öğrenciSilToolStripMenuItem_Click);
            // 
            // ogrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 346);
            this.Controls.Add(this.lstwListe);
            this.Name = "ogrenciListesi";
            this.Text = "Tüm Öğrenci Listesi";
            this.Load += new System.EventHandler(this.ogrenciListesi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstwListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSilToolStripMenuItem;
    }
}