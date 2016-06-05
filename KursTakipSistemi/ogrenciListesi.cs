using _12_WFA_KursTakipSistemi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_WFA_KursTakipSistemi
{
    public partial class ogrenciListesi : Form
    {
        public ogrenciListesi()
        {
            InitializeComponent();
        }

        private void ogrenciListesi_Load(object sender, EventArgs e)
        {
            List<Student> gelenListe = Form1.listem;

            ListeyiDoldur(gelenListe);
        }

        private void ListeyiDoldur(List<Student> gelenListe)
        {
            lstwListe.Items.Clear();
            //bu listeyi listview'e dolduruyoruz.
            foreach (Student ogr in gelenListe)
            {
                //listviewitem her bir satırı ifade eder. bu satıra sırası ile sutunlar yani subitemlar eklenir.
                ListViewItem liv = new ListViewItem(ogr.adSoyad);
                liv.SubItems.Add(ogr.tcKimlik);
                liv.SubItems.Add(ogr.egitimProgrami);
                liv.SubItems.Add(ogr.dogumTarihi.ToShortDateString());
                liv.SubItems.Add(ogr.adres);

                liv.Tag = ogr;

                lstwListe.Items.Add(liv);
            }

            //listview baslıkları yeniden boyutlandırıldı.
            lstwListe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstwListe_MouseDown(object sender, MouseEventArgs e)
        {
            //listview üzerinde sağ tıklandığında aynı zamada tıklanan lokasyonda bir listviewitem var ise menu acılacak:
            if (e.Button==MouseButtons.Right && lstwListe.GetItemAt(e.X,e.Y)!=null)
            {
                //mouse ile tıklanan yerde contextMenuStrip'i göster:
                contextMenuStrip1.Show(lstwListe, e.X, e.Y);
            }
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            DialogResult gelenCevap=MessageBox.Show("Öğrenciyi silmek istediğinizden emin misiniz?", "Öğrenci Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gelenCevap==DialogResult.Yes)
            {
                //secilen ogrenci yakalanıp listeden siliniyor:
                Student secilenOgrenci = lstwListe.SelectedItems[0].Tag as Student;
                Form1.listem.Remove(secilenOgrenci);
                ListeyiDoldur(Form1.listem);
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }
    }
}
