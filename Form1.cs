using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_order_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<clsFoodItem> currentOrder = new List<clsFoodItem>();
      
        StringBuilder OrderSummary = new StringBuilder();
       

        private void btnSmallPizza_Click(object sender, EventArgs e)
        {

        }




        private void AllCLick(object  sender, EventArgs e)
        {

            Button btn = sender as Button;

            float Pri = 0;

            if (float.TryParse(btn.Tag.ToString(), out float ra))
                Pri = ra;


            clsFoodItem item = new clsFoodItem(btn.Text, Pri);
            string tex = ($" Name is {item.FoodName}\n  Price is {item.FoodPrice}\n");

            if (currentOrder.Contains(item))
            {
                currentOrder.Remove(item);
                int index = OrderSummary.ToString().IndexOf(tex);
                if (index != -1)
                {
                    OrderSummary.Remove(index, tex.Length);
                    if (index > 0 && OrderSummary[index - 1] == '\n')
                    {
                        OrderSummary.Remove(index - 1, 1);
                    }
                    else if (index < OrderSummary.Length && OrderSummary[index] == '\n')
                    {
                        OrderSummary.Remove(index, 1); 
                    }

                }

            }
            else
            {
                currentOrder.Add(item);
                tex = $" Name is {item.FoodName}\n  Price is {item.FoodPrice}\n";
                OrderSummary.AppendLine(tex);
            }


            if (OrderSummary.Length > 0 && OrderSummary[OrderSummary.Length - 1] == '\n')
            {
                OrderSummary.Remove(OrderSummary.Length - 1, 1);
            }

            lblOrder.Text = OrderSummary.ToString();
        }

        private void btnReseat_Click(object sender, EventArgs e)
        {
          
            currentOrder = new List<clsFoodItem> ();

            OrderSummary.Clear();
            lblOrder.Text= string.Empty;
            lblPrize.Text = string.Empty;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (currentOrder.Count > 0 )
            {


              clsOrder order = new clsOrder(currentOrder);
              lblPrize.Text = Convert.ToString( order.Calculatable());
            }
            else
            {
                MessageBox.Show("No selected Item");
            }
        }
    }

               



}
