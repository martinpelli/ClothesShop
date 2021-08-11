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
        protected static int stock;

        protected Garment()
        {
            stock = 1000;
            price = 1500;
        }

        protected void CheckQuality()
        {
            if (quality)
            {
                price = price + (30 * price / 100);
            }
        }
        protected abstract void CheckPrice();

    }
}

