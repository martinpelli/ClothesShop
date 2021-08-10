using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop
{
    abstract class Garment
    {
        protected bool quality;
        protected float price;
        protected int stock;

        protected Garment() { }
        protected Garment(float price, int stock, bool quality = false)
        {
            this.quality = quality;
            this.price = price;
            this.stock = stock;
        }

        protected abstract float CheckPrice();

    }
}

