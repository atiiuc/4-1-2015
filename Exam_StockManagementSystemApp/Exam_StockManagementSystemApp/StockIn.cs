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
    public partial class StockIn : Form
    {
        List<Stock> aStocks = new List<Stock>();
        public StockIn(List<Stock> aStock)
        {
            aStocks = aStock;
            InitializeComponent();
        }

   

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int amount=Convert.ToInt32(quantityText.Text);
            Stock aStock=new Stock(idText.Text,amount);
            int itemAmount = aStock.GetQuantityForStockIn(idText.Text,amount,aStocks);
            if (itemAmount == amount)
            {
               aStocks.Add(aStock);
                MessageBox.Show("Added");
               
            }
            else
            {
                aStock.Quantity = itemAmount;
                MessageBox.Show("updated");
                
            }
          

        }

    }
}

