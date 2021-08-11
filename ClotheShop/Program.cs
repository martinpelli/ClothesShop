using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheShop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            createInstances();
        }

        static private void createInstances()
        {
            Shop shop = new Shop("bananaRepublic", "Avenida Siempre Viva");
            Seller seller = new Seller("kid", "Kudi", 0);
            for(int i=0; i < 1000; i++)
            {
                Shirt shirt;
                if (i < 500)
                {
                    if (i < 200)
                    {
                        if (i < 100)
                        {
                            shirt = new Shirt(false, false, true);
                        }
                        else
                        {
                            shirt = new Shirt(true, false, true);
                        }
                    }
                    else
                    {
                        if (i < 350)
                        {
                            shirt = new Shirt(false, false);
                        }
                        else
                        {
                            shirt = new Shirt(true, false);
                        }
                    }
                }
                else
                {
                    if(i < 650)
                    {
                        if(i < 575)
                        {
                            shirt = new Shirt(false,true,true);
                        }
                        else
                        {
                            shirt = new Shirt(true, true, true);
                        }
                    }
                    else
                    {
                        if(i < 825)
                        {
                            shirt = new Shirt(false, true);
                        }
                        else
                        {
                            shirt = new Shirt(true, true);
                        }
                    }
                }
                shop.listGarments.Add(shirt);

            }
            for(int j=0; j < 2000; j++)
            {
                Pant pant;
                if(j < 1500)
                {
                    if(j < 750)
                    {
                        pant = new Pant(false,true);
                    }
                    else
                    {
                        pant = new Pant(true, true);
                    }
                }
                else
                {
                    if(j < 250)
                    {
                        pant = new Pant(false, false);
                    }
                    else
                    {
                        pant = new Pant(true, false);
                    }
                }
                shop.listGarments.Add(pant);
            }
        }

    }
}
