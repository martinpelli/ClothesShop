using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop
{
    static class Record
    {
        private static List<Quotation> quotations = new List<Quotation>();

        public  static List<Quotation> Quotations { get => quotations; }
    }
}
