using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop
{
    class Seller
    {
        private String name;
        private String lastName;
        private int codS;

        private Seller(String name, String lastName, int codS)
        {
            this.name = name;
            this.lastName = lastName;
            this.codS = codS;
        }
    }
}
