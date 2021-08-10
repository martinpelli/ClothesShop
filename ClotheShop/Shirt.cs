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

        private Shirt(bool sleeveType = false, bool collarType = false)
        {
            this.sleeveType = sleeveType;
            this.collarType = collarType;
        }
        protected override float CheckPrice()
        {
            return (0);
        }
    }
}
