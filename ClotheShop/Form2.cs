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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach ( Quotation quote in Record.Quotations)
            {
                String garmentType = " ";
                String shortSleeve = " ";
                String maoCollar = " ";
                String chupinPant = " ";
                String quality = " ";
                if (!quote.Garment.Quality)
                {
                    quality = "X";
                }
                if (quote.Garment is Shirt)
                {
                    garmentType = "Camisa";
                    if (((Shirt)(quote.Garment)).SleeveType)
                    {
                        shortSleeve = "X";
                    }
                    if (((Shirt)(quote.Garment)).CollarType)
                    {
                        maoCollar = "X";
                    }

                }
                else
                {
                    garmentType = "Pantalón";
                    if (((Pant)(quote.Garment)).PantType)
                    {
                        chupinPant = "X";
                    }
                }
                string[] row = { quote.Id.ToString(),quote.DateTime.ToString(), quote.CodS.ToString(), garmentType,quality,shortSleeve, maoCollar,chupinPant, quote.Amount.ToString(), quote.Outcome.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
