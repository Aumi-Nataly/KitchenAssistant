using KitchenAssistant.DataService;
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
    public partial class frmNewOrderList : Form
    {
        FoodService service;
        public frmNewOrderList()
        {
            InitializeComponent();
            service = new FoodService();

            this.tableLayoutPanelListOrder.Controls.Clear();

            CircleSeeOrder();
        }



        /// <summary>
        /// Вывести 4 самых ранних новых заказа, которые еще не брались в работу 
        /// </summary>
        void CircleSeeOrder()
        {
            this.tableLayoutPanelListOrder.Controls.Clear();

            List<OrderContentModel> orders=service.GetNewOrderList();

            for (int i = 0; i< orders.Count; i++)
            {
                frmOneNewOrder partForm = CreateNeworder(orders[i]);               
                this.tableLayoutPanelListOrder.Controls.Add(partForm);
                partForm.Show();

            }
            
        }

        /// <summary>
        /// Формирование плитки с заказом
        /// </summary>
        /// <returns></returns>
        frmOneNewOrder CreateNeworder(OrderContentModel model)
        {
            frmOneNewOrder partForm = new frmOneNewOrder(model)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Margin = new System.Windows.Forms.Padding(5)
            };


            return partForm;
        }


    }
}
