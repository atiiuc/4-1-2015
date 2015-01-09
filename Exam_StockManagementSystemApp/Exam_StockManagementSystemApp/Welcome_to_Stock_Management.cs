using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_StockManagementSystemApp
{
    public partial class Welcome_to_Stock_Management : Form
    {List<Stock> astock=new List<Stock>(); 
        public Welcome_to_Stock_Management()
        {
            InitializeComponent();
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            StockIn aStockIn = new StockIn(astock);
            aStockIn.Show();


        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            StockOut aStockOut = new StockOut(astock);
            aStockOut.Show();

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            View_Current_Stock  aStockOut = new View_Current_Stock(astock);
            aStockOut.Show();

        }
    }
}
