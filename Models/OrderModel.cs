using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderModel
    {
        #region Private Member Variables

        public static int _orderId = 0;

        #endregion // Member Variables

        #region Constructor

        public OrderModel()
        {
            _orderId++;
            OrderByWatchId = new Dictionary<int, int>();
            TotalCost = 0;
        }

        #endregion // Constructor

        #region Public Properties

        public Dictionary<int, int> OrderByWatchId { get; set; }

        public int TotalCost { get; private set; }

        #endregion // Public Properties

        #region Public Methods

        public int CalculateTotalCost(Dictionary<int, WatchModel> watches)
        {
            var orderDict = new Dictionary<int, int>();
            foreach (var id in OrderByWatchId.Keys)
            {
                if (!watches.ContainsKey(id))
                    break;
                else
                {
                    if (watches[id].DiscountAmount > 0)
                    {
                        var quotient = OrderByWatchId[id] / watches[id].DiscountQuantity;
                        var remainder = OrderByWatchId[id] % watches[id].DiscountQuantity;
                        TotalCost += (remainder * watches[id].UnitPrice) + (quotient * watches[id].DiscountAmount);
                    }
                    else
                        TotalCost += OrderByWatchId[id] * watches[id].UnitPrice;
                }
            }

            return TotalCost;
        }

        #endregion // Public Methods
    }
}
