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

        public Seller(String name, String lastName, int codS)
        {
            this.name = name;
            this.lastName = lastName;
            this.codS = codS;
        }

        public String Name { get => name; }
        public String LastName { get => lastName; }

        public int CodS { get => codS; }
    }
}
