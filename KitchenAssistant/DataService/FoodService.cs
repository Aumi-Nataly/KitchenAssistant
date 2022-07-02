using KitchenAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAssistant.DataService
{
    /// <summary>
    /// Вывод информации о блюде
    /// </summary>
    public class FoodService
    {
        private List<OrderContentModel> orderContent { get; set; }
        public FoodService()
        {
            orderContent=new List<OrderContentModel>();

            orderContent.Add(new OrderContentModel {OrderId=123,
                FoodName= "Жаркое по - деревенски",
                FoodContent= "корейка свиная, сало свиное, масло сливочное, картофель, перец болгарский, морковь, лук репчатый, чеснок, зелень петрушки, специи, перец чёрный горошком",
                FoodType=1,
                FoodMin=45
            });

            orderContent.Add(new OrderContentModel
            {
                OrderId = 123,
                FoodName = "Макароны с мясом",
                FoodContent = "макароны, мясо, лук, морковь, помидоры, кетчуп, вода, зелень, соль, приправа",
                FoodType = 1,
                FoodMin = 15
            });


            orderContent.Add(new OrderContentModel
            {
                OrderId = 220,
                FoodName = "Классический чизкейк",
                FoodContent = "масло сливочное, крекер, сахар, соль, сыр сливочный, цедра лимона, сок лимонный, соль, яйца, сметана, сахар",
                FoodType = 2,
                FoodMin = 25
            });
        }


        public List<OrderContentModel> GetNewOrderList()
        { 
            return orderContent;    
        }

    }
}
