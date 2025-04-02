using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_order_management_system
{
    public class clsFoodItem
    {
        public string FoodName { get; set; }
        public float  FoodPrice { get; set; }
        

        public clsFoodItem(string foodname , float foodprice)
        {
            FoodName = foodname;
            FoodPrice = foodprice;
        }

        
        public override bool Equals(object obj)
        {
           if (obj is clsFoodItem other)
            {
              return this.FoodName == other.FoodName && this.FoodPrice == other.FoodPrice;
            }
           return false;
        }


        public override int GetHashCode()
        {
            int hashFoodName = FoodName == null ? 0 : FoodName.GetHashCode();
            int hashFoodPrice = FoodPrice.GetHashCode();
            return (hashFoodName * 397) ^ hashFoodPrice;
        }
    }
}
