using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_order_management_system
{
    public class clsOrder : ICalculatable
    {

        public List<clsFoodItem> listFood;

        public clsOrder(List<clsFoodItem> food)
        {
            listFood = food;
        }


        public float Calculatable()
        {
            float Num = 0;
           
            foreach ( clsFoodItem food in listFood) 
            {
                Num += food.FoodPrice;
            }
            
            return Num;
        }

    }
}
