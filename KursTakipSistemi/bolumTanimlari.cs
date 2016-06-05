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
    public partial class bolumTanimlari : Form
    {
        public bolumTanimlari()
        {
            InitializeComponent();
        }

        private void bolumTanimlari_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBolumAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBolumAdi.Text))
            {
                //64 bit'lik benzersiz bir id oluşturur
                Guid gd = Guid.NewGuid();

                Bolum blm = new Bolum();
                blm.bolum_Id = gd.ToString();
                blm.bolum_Ad = txtBolumAdi.Text;

                Form1.bolumListesi.Add(blm);
                BolumListele();
            }
            else
            {
                MessageBox.Show("Lütfen Bölüm Adı Girin");
            }
            


        }

        private void BolumListele() {

            lstBolumler.Items.Clear();

            if (Form1.bolumListesi.Count==0)
            {
                lstBolumler.Items.Add("Bölüm Mevcut Değil");
            }
            else
            {
                foreach (Bolum item in Form1.bolumListesi)
                {
                    lstBolumler.Items.Add(item);
                }
            }

        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            DialogResult gelenCevap = MessageBox.Show("Bölüm Silme İşlemi", "Silmek istediğinize emin misiniz?", MessageBoxButtons.YesNo);

            if (gelenCevap == DialogResult.Yes)
            {
                Bolum bolum = lstBolumler.SelectedItem as Bolum;
                Form1.bolumListesi.Remove(bolum);
                BolumListele();
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }
    }
}
