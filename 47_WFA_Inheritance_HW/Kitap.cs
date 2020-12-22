using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_WFA_Inheritance_HW
{
    public class Kitap :Urun
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public int BarcodeNo { get; set; }
        public bool Hardcover { get; set; }
        public string Genre { get; set; }

    }
}
