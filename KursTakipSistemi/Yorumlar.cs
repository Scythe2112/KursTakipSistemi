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
    public partial class Yorumlar : Form
    {
        private int childFormNumber = 0;

        public Yorumlar()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
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

        private void Yorumlar_Load(object sender, EventArgs e)
        {
            //Liste boşsa (öğrenci yoksa) ogrenciFormu butonunu göster, öğrenci var ise comboyu doldur.
            if (Form1.listem.Count==0)
            {
                lblDurumMesaji.Text = "Lütfen önce öğrenci girişi yapınız";
                btnOgrenciFormu.Visible = true;
            }
            else
            {
                //comboyu doldur:
                foreach (Student ogrenci in Form1.listem)
                {
                    //nesne olarak ekledik:
                    cmbOgrenciler.Items.Add(ogrenci);
                }

                //cmbOgrenciler.DataSource = Form1.listem;
            }
        }

        private void btnOgrenciFormu_Click(object sender, EventArgs e)
        {
            //yorumları kapat öğrenci formunu aç.
            ogrenciFormu frm = new ogrenciFormu();
            this.Close();
            frm.Show();
        }

        Student std = new Student();

        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextleriTemizle(tabControl1.Controls);

            //secilen bir sey var ise
            if (cmbOgrenciler.SelectedIndex!=-1)
            {
                //secilen öğrenci yakalandı.
                 std=(Student)cmbOgrenciler.SelectedItem;

                //bu öğrencinin yorumu var mı yok mu?
                if (!string.IsNullOrEmpty(std.yorum))
                {
                    //öğrencinin daha önceden yapılmıs bir yorumu vardır:
                    tabControl1.SelectedIndex = 1;
                    //tabControl1.SelectedTab = tabPage4;
                    txtYorumText.Text = std.yorum; //yorum textboxa yazdırıldı.
                }
                else
                    tabControl1.SelectedIndex = 0;
            }
            //secilen bir sey yok ise:
            else
            {
                tabControl1.SelectedIndex = 0;
                lblDurumMesaji.Text = "Yorum yapmak ya da görüntülemek için bir öğrenci seçiniz...";
            }
        }

        //bu metod .Controls yazabildiğimiz tüm kontorller için (panel, groupbox,tabcontainer gibi) kullanılabilir.
        private void TextleriTemizle(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            /*
            StringBuilder:
            birden fazla string üzerinde islem yapmak için kullanılır. System.Text namespace'i altında bulunur.
            */
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Yeni String");

            //StringBuilder sb1 = new StringBuilder("Yeni String");
            //MessageBox.Show(sb1.ToString());

            /*
            string bir değiskene yeni değer atamaya calıstığımzda ramde yeni bir değisken oluşturulur eski string değisken silinir. burada yasanan performans kaybını önlemek amacıyla StringBuilder nesnesi kullanılır.
            */

            //biz yorum kaydımızı yapalım:
            StringBuilder yorumlar = new StringBuilder();
            yorumlar.Append(txtEgitim.Text);
            //yorumlar.AppendLine(); 1 satır bosluk atar.
            yorumlar.Append(txtKisisel.Text);
            yorumlar.Append(txtTakim.Text);

            //secilen ogrenciyi Bul
            Student std = (Student)cmbOgrenciler.SelectedItem;
            //yorum atamasını yap:
            std.yorum = yorumlar.ToString();

            //yorum görüntüleyi aç ve yorumu göster:
            tabControl1.SelectedIndex = 1;
            txtYorumText.Text = std.yorum;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eğer secili olan öğrencinin yorumu yok ise, aktif olan index 0 olsun (yani yorum yap tabı secili olarak kalsın)
            if (string.IsNullOrEmpty(std.yorum)) //global değiskenin yorumu kontrol edildi.
                tabControl1.SelectedIndex = 0;
        }
    }
}
