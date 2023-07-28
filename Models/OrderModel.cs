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
                        var fullPriceWatches = OrderByWatchId[id] / watches[id].DiscountQuantity;
                        var discountedWatches = OrderByWatchId[id] % watches[id].DiscountQuantity;
                        TotalCost += (discountedWatches * watches[id].UnitPrice) + (fullPriceWatches * watches[id].DiscountAmount);
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
