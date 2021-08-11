using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop
{
    class Pant: Garment
    {
        private bool pantType;

        public Pant(bool quality, bool pantType = false)
        {
            base.quality = quality;
            this.pantType = pantType;
        }

        protected override float CheckPrice()
        {
            return (0);
        }
    }
}
