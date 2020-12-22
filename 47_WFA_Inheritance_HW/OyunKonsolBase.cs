using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_WFA_Inheritance_HW
{
    public class OyunKonsolBase :Urun
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Year { get; set; }
        public int BarcodeNo { get; set; }
        
    }
}
