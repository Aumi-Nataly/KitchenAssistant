using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenAssistant.Models
{
    /// <summary>
    /// Карточка состава заказа
    /// </summary>
    public class OrderContentModel
    {
        public int OrderId { get; set; } 
        public string FoodName { get; set; }
        public string FoodContent { get; set; }
        public int FoodType { get; set; }

        public int FoodMin { get; set; }
    }
}
