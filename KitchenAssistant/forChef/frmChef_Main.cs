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
    public partial class frmChef_Main : Form
    {
        public frmChef_Main()
        {
            InitializeComponent();
        }

        private void frmChef_Main_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToShortTimeString();   
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
