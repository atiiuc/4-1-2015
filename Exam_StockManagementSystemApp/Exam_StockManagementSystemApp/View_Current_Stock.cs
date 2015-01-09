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
    public partial class View_Current_Stock : Form
    {List<Stock> aStocks=new List<Stock>(); 
        public View_Current_Stock(List<Stock> aStock )
        {
            aStocks = aStock;
            InitializeComponent();
        }

        private void View_Current_Stock_Load(object sender, EventArgs e)
        {
            foreach (Stock astock  in aStocks)
            {
                
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = astock.Id;

                aListViewItem.SubItems.Add(astock.Quantity.ToString());
              

                aListViewItem.Tag = astock;

                ShowList.Items.Add(aListViewItem);
            }
        }
        
    }
}
