using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Model class for orders
    /// </summary>
    public class OrderModel
    {
        #region Private Member Variables

        // auto-incrementing order ID
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

        /// <summary>
        /// Calculates total cost of the order by correlating ordered quantity by watch ID and applying corresponding discounts
        /// </summary>
        /// <param name="watches">Inventory of watched with corresponding watch IDs</param>
        /// <returns>Total cost to the user</returns>
        public int CalculateTotalCost(Dictionary<int, WatchModel> watches)
        {
            foreach (var id in OrderByWatchId.Keys)
            {
                // Verifying ordered watch exists in inventory
                if (!watches.ContainsKey(id))
                    break;
                else
                {
                    // Applying discounts if applicable
                    if (watches[id].DiscountAmount > 0)
                    {
                        var fullPriceWatches = OrderByWatchId[id] / watches[id].DiscountQuantity;
                        var discountedWatches = OrderByWatchId[id] % watches[id].DiscountQuantity;
                        TotalCost += (discountedWatches * watches[id].UnitPrice) + (fullPriceWatches * watches[id].DiscountAmount);
                    }
                    else
                        TotalCost += OrderByWatchId[id] * watches[id].UnitPrice; // calculating total cost directly for non-discounted items
                }
            }

            return TotalCost;
        }

        #endregion // Public Methods
    }
}
