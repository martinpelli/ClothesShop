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
        }
        protected override float CheckPrice()
        {
            return (0);
        }
    }
}
