using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper
{
    public class OrderModel
    {
        private static int _orderId = 0;
        private int _discountAmount;

        public OrderModel()
        {
            _orderId++;
        }

        public Dictionary<WatchModel, int> WatchesCount { get; set; }

        public int TotalCost { get; set; }

    }
}
