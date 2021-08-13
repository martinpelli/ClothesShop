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
        private Shop shop;
        private Seller seller;
        private bool typeGarment = true;
        private bool qualityGarment = true;
        private bool collarTypeShirt = false;
        private bool sleeveTypeShirt = false;
        private bool typePant = false;
        private float price = 0;
        private int amount = 0;
        private int id = 0;

        public QuotationForm()
        {
            InitializeComponent();
            createInstances();
            setLabels();
            
        }

        

        private void quoteButton_Click(object sender, EventArgs e)
        {



            if (amount <= 0 || price <= 0)
            {
                MessageBox.Show("El precio o la cantidad no pueden ser 0 o estar vacío");
                clearTextBox();
            }
            else
            {
                List<Garment> removeGarments = new List<Garment>();
                bool noFound = false;
                int from = 0;
                float totalOutcome = 0;
                Garment newGarment = null;
                for (int i = 0; i < amount; i++)
                {
                    float outcome = 0;
                    var garments = CheckStock(from);
                    newGarment = garments.Item1;
                    Garment originalGarment = garments.Item2;
                    from = garments.Item3 + 1;
                    newGarment.Price = price;
                    outcome = newGarment.CheckPrice();
                    totalOutcome += outcome;
                    if (originalGarment == null)
                    {
                        //En el caso de que no se encontró alguna prenda
                        noFound = true;
                        break;
                    }
                    else
                    {
                        //Las prendas que se encuentran se van añadiendo a las listas
                        removeGarments.Add(originalGarment);
                    }
         
                   
                }

                if (noFound)
                {
                    MessageBox.Show("No hay suficiente Stock para la prenda seleccionada");
                }
                else
                {
                    //si todas las prendas se encontraron entonces ahora sí las elimino y las guardo en el historial
                    for (int i = 0; i < amount; i++)
                    {
                        shop.ListGarments.Remove(removeGarments[i]);

                    }
                    Record.Quotations.Add(new Quotation(id, DateTime.Now, seller.CodS, newGarment, amount, totalOutcome));
                    Garment.Stock -= amount;
                    stockTextBox.Text = Garment.Stock.ToString();
                    quoteTextBox.Text = totalOutcome.ToString();
                    id += 1;
                }
            }






        }

        private Tuple<Garment,Garment,int> CheckStock(int from)
        {
            Garment newGarment = null;
            Garment originalGarment = null;
            var index = 0;
            if (typeGarment)
            {
                newGarment = new Shirt(qualityGarment, sleeveTypeShirt, collarTypeShirt);
                for (int i = from; i < shop.ListGarments.Count(); i++)
                {
                    if (shop.ListGarments[i] is Shirt)
                    {
                        //Comparación de objetos por datos ya que Equals es por referencia
                        if (shop.ListGarments[i].Quality == qualityGarment && ((Shirt)shop.ListGarments[i]).SleeveType == sleeveTypeShirt && ((Shirt)shop.ListGarments[i]).CollarType == collarTypeShirt)
                        {
                            originalGarment = shop.ListGarments[i];
                            index = i;
                            break;
                            

                        }

                    }
                    
                }
                return Tuple.Create(newGarment, originalGarment, index);

            }
            else
            {
                newGarment = new Pant(qualityGarment, typePant);
                for (int i = from; i < shop.ListGarments.Count(); i++)
                {
                    if (shop.ListGarments[i] is Pant)
                    {
                        //Comparación de objetos por datos ya que Equals es por referencia
                        if (shop.ListGarments[i].Quality == qualityGarment && ((Pant)shop.ListGarments[i]).PantType == typePant)
                        {
                            originalGarment = shop.ListGarments[i];
                            index = i;
                            break;
                            
                        }
                    }
                    
                }
                return Tuple.Create(newGarment, originalGarment, index);

            }
        }


        private void createInstances()
        {

            shop = new Shop("Banana Republic", "Avenida Siempre Viva");
            seller = new Seller("Kid", "Cudi", 42366);
            for (int i = 0; i < 1000; i++)
            {
                Shirt shirt;
                if (i < 500)
                {
                    if (i < 200)
                    {
                        if (i < 100)
                        {
                            //Camisa - Standard, Manga Corta, Cuello Mao
                            shirt = new Shirt(true, true, true);
                        }
                        else
                        {
                            //Camisa - Premium, Manga Corta, Cuello Mao
                            shirt = new Shirt(false, true, true);
                        }
                    }
                    else
                    {
                        if (i < 350)
                        {
                            //Camisa - Standard, Manga Corta, Cuello Común
                            shirt = new Shirt(true, true);
                        }
                        else
                        {
                            //Camisa - Premium, Manga Corta, Cuello Común
                            shirt = new Shirt(false, true);
                        }
                    }
                }
                else
                {
                    if (i < 650)
                    {
                        if (i < 575)
                        {
                            //Camisa - Standard, Manga Larga, Cuello Mao
                            shirt = new Shirt(true, false, true);
                        }
                        else
                        {
                            //Camisa - Premium, Manga Larga, Cuello Mao
                            shirt = new Shirt(false, false, true);
                        }
                    }
                    else
                    {
                        if (i < 825)
                        {
                            //Camisa - Standard, Manga Larga, Cuello Común
                            shirt = new Shirt(true, false);
                        }
                        else
                        {
                            //Camisa - Premium, Manga Larga, Cuello Común
                            shirt = new Shirt(false, false);
                        }
                    }
                }
                shop.ListGarments.Add(shirt);

            }
            for (int j = 0; j < 2000; j++)
            {
                Pant pant;
                if (j < 1500)
                {
                    if (j < 750)
                    {
                        //Pantalón - Standard, Chupín
                        pant = new Pant(true, true);
                    }
                    else
                    {
                        //Pantalón - Premium, Chupín
                        pant = new Pant(false, true);
                    }
                }
                else
                {
                    if (j < 1750)
                    {
                        //Pantalón - Standard, Común
                        pant = new Pant(true, false);
                    }
                    else
                    {
                        //Pantalón - Premium, Común
                        pant = new Pant(false, false);
                    }
                }
                shop.ListGarments.Add(pant);
            }
            
        }

        private void setLabels()
        {
            sellerName.Text = seller.Name + " " + seller.LastName;
            sellerCod.Text = (seller.CodS).ToString();
            shopName.Text = shop.Name;
            shopDirection.Text = shop.Direction;
            setStockTextBox();
        }

        private void setStockTextBox()
        {
            stockTextBox.Text = (Garment.Stock).ToString();
        }

        private void shirtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Si typeGarment == false => es un pantalón
            //Si typeGarment == true => es una camisa
            typeGarment = ((RadioButton)sender).Checked;

            
        }

        private void shortSleeveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Si sleeveTypeShirt == false => es manga larga
            //Si sleeveTypeShirt == true => es manga corta
            sleeveTypeShirt = ((CheckBox)sender).Checked;

        }

        private void maoCollarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Si collarTypeShirt == false => es cuello común
            //Si collarTypeShirt == true => es cuello mao
            collarTypeShirt = ((CheckBox)sender).Checked;
        }

        private void pantTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Si typePant == false => es común
            //Si typePant == true => es chupín
            typePant = ((CheckBox)sender).Checked;
        }

        private void standardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Si qualityGarment == false => es premium
            //Si qualityGarment == true => es standard
            qualityGarment = ((RadioButton)sender).Checked;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                price = float.Parse(((TextBox)sender).Text);
            }
            catch 
            {
                MessageBox.Show("Ingrese un número válido");
                clearTextBox();

            }                
            

            
        }
            
        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = Int32.Parse(((TextBox)sender).Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un número válido");
                clearTextBox();
            }
        }

        private void recordsLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void clearTextBox()
        {
            amountTextBox.TextChanged -= amountTextBox_TextChanged;
            priceTextBox.TextChanged -= priceTextBox_TextChanged;
            amountTextBox.Text = "";
            priceTextBox.Text = "";
            price = 0;
            amount = 0;
            priceTextBox.TextChanged += priceTextBox_TextChanged;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
        }
    }
}
