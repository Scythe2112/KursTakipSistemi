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
    public partial class bolumAtama : Form
    {
        public bolumAtama()
        {
            InitializeComponent();
        }

        private void bolumAtama_Load(object sender, EventArgs e)
        {
            cmbOgrenciler.Items.Insert(0, "Lütfen öğrenci seçiniz");
            foreach (Student item in Form1.listem)
            {
                cmbOgrenciler.Items.Add(item);
            }

            cmbBolumler.Items.Insert(0, "Lütfen bölüm seçiniz");
            foreach (Bolum item in Form1.bolumListesi)
            {
                cmbBolumler.Items.Add(item);
            }
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            Student secilenOgr = cmbOgrenciler.SelectedItem as Student;
            Bolum secilenBlm = cmbBolumler.SelectedItem as Bolum;

            ListViewItem liv = new ListViewItem(secilenOgr.adSoyad);
            liv.SubItems.Add(secilenBlm.bolum_Ad);
            lstwListe.Items.Add(liv);
        }
    }
}
