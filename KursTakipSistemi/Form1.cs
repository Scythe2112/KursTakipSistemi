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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öğrenciTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciFormu frm = new ogrenciFormu();
            frm.MdiParent = this; //oğrenci formu mdiParent(ana form) olan form1'e bağlandı.
            frm.Show();
        }

        //tum öğrencilerin kaydedilmesi için Generic bir list tanımlandı.Static yapıldı cünkü: ogrenciFormundan bu listeye her erismek istediğimde Form1'in instance(örneğini) almadan, direkt Form1.listem seklinde erismek istiyoruz.
        public static List<Student> listem = new List<Student>();
        public static List<Bolum> bolumListesi = new List<Bolum>();

        //public static int bolumSayac = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1'in icerdiği MDI Formları hizalama:
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void öğrenciYorumlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yorumlar yrm = new Yorumlar();
            FormKontroluYap(yrm);
        }

        private void tümÖğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciListesi ogr = new ogrenciListesi();
            //ogr.MdiParent = this;
            //ogr.Show();
            FormKontroluYap(ogr);
        }

        private void bölümTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolumTanimlari bt = new bolumTanimlari();
            FormKontroluYap(bt);
        }

        private void FormKontroluYap(Form gelenForm)
        {
            bool acikmi = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.Text==gelenForm.Text)
                {
                    acikmi = true;
                }
            }

            if (acikmi==true)
            {
                MessageBox.Show("Form Zaten Açık");
            }
            else
            {
                gelenForm.MdiParent = this;
                gelenForm.Show();
            }


        }

        private void öğrenciyeBölümAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolumAtama bt = new bolumAtama();
            FormKontroluYap(bt);
        }
    }
}
