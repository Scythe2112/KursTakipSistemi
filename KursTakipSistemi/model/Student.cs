using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_WFA_KursTakipSistemi.model
{
    public class Student
    {
        //field /(property - özellik)
        //get ve set metodları olmadığı için bunlar field olarak adlandırılırlar.
        public string adSoyad; //field
        public string tcKimlik;
        public string adres;
        public string egitimProgrami;
        public DateTime dogumTarihi;
        public string imajYeri;
        public string yorum;

        public override string ToString()
        {
            //return "Öğrenci Adı:"+adSoyad;
            //return adSoyad + "-" + dogumTarihi;
            return adSoyad;
        }
    }
}
