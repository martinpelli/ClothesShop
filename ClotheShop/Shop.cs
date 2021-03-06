using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop
{
    class Shop
    {
        private String name;
        private String direction;
        private List<Garment> listGarments;

        public String Name { get => name; }
        public String Direction { get => direction; }

        public List<Garment> ListGarments { get => listGarments; }
        public Shop(String name, String direction)
        {
            this.name = name;
            this.direction = direction;
            listGarments = new List<Garment>();
        }
    }
}
