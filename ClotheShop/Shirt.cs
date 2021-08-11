using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop
{
    class Shirt : Garment
    {
        private bool sleeveType;
        private bool collarType;

        public Shirt(bool quality, bool sleeveType = false, bool collarType = false)
        {
            base.quality = quality;
            this.sleeveType = sleeveType;
            this.collarType = collarType;
            CheckPrice();
        }
        protected override void CheckPrice()
        {
            CheckQuality();
            if (sleeveType)
            {
                price = price - (10 * price / 100);
            }
            if (collarType)
            {
                price = price + (3 * price / 100);
            }

        }
    }
}
