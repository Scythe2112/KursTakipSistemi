using _12_WFA_KursTakipSistemi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_WFA_KursTakipSistemi
{
    public partial class ogrenciFormu : Form
    {
        public ogrenciFormu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //ilk gösterilecek olan dizin tanımlandı.
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //pencere baslığı.
            openFileDialog.Title = "Lütfen bir öğrenci resmi seçiniz...";
            //birden fazla dosya secmeyi aktif et:
            //openFileDialog.Multiselect = true;
            openFileDialog.Filter = "jpeg dosyları (*.jpeg)|*.jpg|bmp dosyları (*.bmp)|*.bmp";

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                //secilen dosyanın yolunu al.
                //picturebox'a imaj olarak ata.
                string fileName = openFileDialog.FileName;
                //dosya yolunda bulunan imaj oluşturulup pictureboxın imajı olarak alındı.
                pbImaj.Image = new Bitmap(fileName);
            }

            ////birden fazla dosya geliyor ise:
            //List<string> dosyaListesi = new List<string>();
            //for (int i = 0; i < openFileDialog.FileNames.Length-1; i++)
            //{
            //    dosyaListesi.Add(openFileDialog.FileNames[i]);
            //}
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(txtDtarihi.Text);

                //DateTime dtarihi = txtDtarihi.Value;
                //MessageBox.Show(dtarihi.ToLongDateString());

                //secilen resim dosyasının kaydedileceği dizini secmek üzere , saveFileDialog formu set ediliyor:
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog1.Title = "Resim Kaydet";
                saveFileDialog1.Filter = "jpeg dosyları (*.jpeg)|*.jpg|bmp dosyları (*.bmp)|*.bmp|ico dosyları (*.ico)|*.ico|tiff dosyları (*.tiff)|*.tiff|png dosyları (*.png)|*.png|gif dosyları (*.gif)|*.gif";

                //yeni bir öğrenci nesnesi olusturularak formdaki textboxlardan gelen değerlerle dolduruluyor:
                Student std = new Student();
                std.adSoyad = txtAdSoyad.Text;
                std.tcKimlik = txtTc.Text;
                std.adres = txtAdres.Text;
                std.dogumTarihi = txtDtarihi.Value;
                std.egitimProgrami = cmbEgitimProgrami.SelectedItem.ToString();

                //picturebox icerisindeki imaj bir dizine (klasöre) belirlenen formatta kaydediliyor:
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    //resim hangi isim ile kaydedilecek:
                    std.imajYeri = saveFileDialog1.FileName;

                    //gelen dosyanın uzantısı belirleniyor:
                    //string uzanti = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3, 3);

                    //metod dosyanın uzantısını geriye döner.
                    string uzanti = DosyaUzantisiniBul(saveFileDialog1.FileName);

                    switch (uzanti)
                    {
                        //nereye kaydedeyim, hangi formatta kaydedeyim:
                        case "bmp":
                            pbImaj.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                            break;
                        case "jpg":
                            pbImaj.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                            break;
                        case "gif":
                            pbImaj.Image.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                            break;
                        case "ico":
                            pbImaj.Image.Save(saveFileDialog1.FileName, ImageFormat.Icon);
                            break;
                        case "png":
                            pbImaj.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                            break;
                        case "tiff":
                            pbImaj.Image.Save(saveFileDialog1.FileName, ImageFormat.Tiff);
                            break;
                    }

                    //Öğrenci listeye kaydediliyor:
                    Form1.listem.Add(std);

                    //Öğrenci sayısı güncelleniyor:
                    lblOgrenci.Text = Form1.listem.Count.ToString();

                    //islem basarılı ile status bar duzenlemesi yapılıyor:
                    lblMesaj.Text = "Kayıt işlemi başarı ile tamamlandı";
                    durumKontrol.BackColor = Color.Green;
                    lblMesaj.Font = new Font(new FontFamily("Verdana"), 10);
                    lblMesaj.ForeColor = Color.White;

                    //Tum panel kontrollerini temizle
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                lblMesaj.Text = ex.Message;
                durumKontrol.BackColor = Color.Red;
                lblMesaj.Font = new Font(new FontFamily("Verdana"), 10);
                lblMesaj.ForeColor = Color.White;
            }

        }

        private void Temizle()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }

            pbImaj.Image = null;
            txtAdSoyad.Focus();
            txtDtarihi.Value = DateTime.Now;
            cmbEgitimProgrami.SelectedIndex = 0;
        }

        private string DosyaUzantisiniBul(string fileName)
        {
            int totalLenght = fileName.Length;
            int nokta = fileName.LastIndexOf('.')+1;
            int kesilecekUzunluk = totalLenght - nokta;

            string uzanti = fileName.Substring(nokta, kesilecekUzunluk);

            return uzanti;
        }

        private void ogrenciFormu_Load(object sender, EventArgs e)
        {
            List<string> egitimTurleri = new List<string>();
            egitimTurleri.Add("Lütfen eğitim seçiniz...");
            egitimTurleri.Add("Yazılım ve Veritabanı");
            egitimTurleri.Add("Sistem ve Network Eğitimi");

            //foreach (string item in egitimTurleri)
            //{
            //    cmbEgitimProgrami.Items.Add(item);
            //}

            //Combobox'ın veri kaynağı olarak bir koleksiyon tanımlaması yapılabilir.
            cmbEgitimProgrami.DataSource = egitimTurleri;

            txtDtarihi.Format = DateTimePickerFormat.Custom;
            txtDtarihi.CustomFormat = "ddMMMMyyyy";
        }
    }
}
