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
    public partial class StockOut : Form
    {List<Stock> aStocks=new List<Stock>(); 
        public StockOut(List<Stock> aStock )
        {
            aStocks = aStock;
            InitializeComponent();
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(quantityOutText.Text);
            Stock aStock = new Stock(idOutText.Text, amount);
            int itemAmount = aStock.GetQuantityForStockOut(idOutText.Text, amount,aStocks);

            if (itemAmount!=-1)
            {
              aStock.Quantity = itemAmount;
                MessageBox.Show("updated");   
            }
            else
            {
                MessageBox.Show("this item doesn't exists!");
            } 

            
        }
    }
}
