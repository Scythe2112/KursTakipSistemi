using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_WFA_KursTakipSistemi.model
{
    public class Bolum
    {
        public string bolum_Id;
        public string bolum_Ad;

        public override string ToString()
        {
            return bolum_Id+"-"+bolum_Ad;
        }

    }
}
