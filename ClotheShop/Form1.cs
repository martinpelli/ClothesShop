using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheShop
{
    partial class QuotationForm : Form
    {
        public Shop shop;
        public Seller seller;
        public QuotationForm()
        {
            InitializeComponent();
            createInstances();
            setLabels();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            
        }


        private void createInstances()
        {

            shop = new Shop("bananaRepublic", "Avenida Siempre Viva");
            seller = new Seller("Kid", "Cudi", 0);
            for (int i = 0; i < 1000; i++)
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
                    if (i < 650)
                    {
                        if (i < 575)
                        {
                            shirt = new Shirt(false, true, true);
                        }
                        else
                        {
                            shirt = new Shirt(true, true, true);
                        }
                    }
                    else
                    {
                        if (i < 825)
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
            for (int j = 0; j < 2000; j++)
            {
                Pant pant;
                if (j < 1500)
                {
                    if (j < 750)
                    {
                        pant = new Pant(false, true);
                    }
                    else
                    {
                        pant = new Pant(true, true);
                    }
                }
                else
                {
                    if (j < 250)
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

        private void setLabels()
        {
            sellerName.Text = seller.Name + " " + seller.LastName;
            sellerCod.Text = (seller.CodS).ToString();
            shopName.Text = shop.Name;
            shopDirection.Text = shop.Direction;
        }
    }
}
