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
        protected static int stock = 1000;

        public static int Stock { get => stock; set => stock = value; }
        public float Price { get => price; set => price = value; }

        public bool Quality { get => quality; }
        protected Garment()
        {
            
            price = 0;
        }

        protected void CheckQuality()
        {
            if (!quality)
            {
                price = price + (30 * price / 100);
            }
        }
        public abstract float CheckPrice();

    }
}

