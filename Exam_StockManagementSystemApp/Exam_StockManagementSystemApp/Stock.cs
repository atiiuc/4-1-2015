using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_StockManagementSystemApp
{
  public  class Stock
    {
      public string Id { set; get; }
      public int Quantity { set; get; }
      private List<Stock> aStocks = new List<Stock>();
      public Stock(string id,int amount)
      {
          Id = id;
          Quantity = amount;
      }
      public int GetQuantityForStockIn(string id, int quantity,List<Stock> astockvalue )
      {
          aStocks = astockvalue;
          foreach (Stock astock in aStocks)
          {
              if (astock.Id == Id)
              {
                  astock.Quantity += quantity;
                  return astock.Quantity;
              }

          }
          return quantity;
      }
      public int GetQuantityForStockOut(string id, int quantity, List<Stock> astockvalue)
      {
          aStocks = astockvalue;
          foreach (Stock astock in aStocks)
          {
              if (astock.Id == Id)
              {
                  astock.Quantity -= quantity;
                  return astock.Quantity;
              }
              else
              {
                  return -1;
              }

          }
          return quantity;
      }

     
     
    }
}
