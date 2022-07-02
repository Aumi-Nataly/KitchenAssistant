using KitchenAssistant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenAssistant.forChef
{
    public partial class frmOneNewOrder : Form
    {
        public int OrderId { get; set; }
        public string FoodName { get; set; }
        public string FoodContent { get; set; }
        public int FoodType { get; set; }

        public int FoodMin { get; set; }

        public frmOneNewOrder(OrderContentModel order)
        {
            InitializeComponent();

            OrderId = order.OrderId;
            FoodName=order.FoodName;
            FoodContent=order.FoodContent;  
            FoodType=order.FoodType;
            FoodMin=order.FoodMin;
        }

        void SeeData()
        {
            labelFood.Text = FoodName;
            labelTimeCook.Text = FoodMin.ToString() + " мин";
            labelNumberOrder.Text= "Заказ № "+OrderId.ToString();
            richTextBoxIngredient.Text = FoodContent;

            pictureBox1.Image = SelectTypeFood();
        }

        Bitmap SelectTypeFood()
        {

            Bitmap picFood = null;

            switch (FoodType)
            {
                case 1:
                    picFood= global::KitchenAssistant.Properties.Resources.meat_food_chicken;
                    break;
                case 2:
                    picFood = global::KitchenAssistant.Properties.Resources.muffin_cake;
                    break;
                
            }

            return picFood;

        }

        private void frmOneNewOrder_Load(object sender, EventArgs e)
        {
            SeeData();
        }
    }
}
