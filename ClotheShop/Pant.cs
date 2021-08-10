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

        private Pant(bool pantType = false)
        {
            this.pantType = pantType;
        }

        protected override float CheckPrice()
        {
            return (0);
        }
    }
}
