using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop
{
    class Quotation
    {
        private int id;
        private DateTime dateTime;
        private int codS;
        private Garment garment;
        private int amount;
        private float outcome;

        public Quotation(int id, DateTime dateTime, int codS, Garment garment, int amount, float outcome)
        {
            this.amount = amount;
            this.codS = codS;
            this.dateTime = dateTime;
            this.garment = garment;
            this.id = id;
            this.outcome = outcome;
        }
    }
}
