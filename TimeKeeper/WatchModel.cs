using System.Collections.Generic;

namespace TimeKeeper
{
    public class WatchModel
    {
        public WatchModel(string watchName, int price, int discountQuant = 0, int discountAmount = 0)
        {
            WatchName = watchName;
            UnitPrice = price;
            DiscountQuantity = discountQuant;
            DiscountAmount = discountAmount;
            OrderedQuantity = 0;
        }

        public string WatchName { get; set; }

        public int UnitPrice { get; set; }

        public int DiscountQuantity { get; set; }

        public int DiscountAmount { get; set; }

        public int OrderedQuantity { get; set; }

    }
}
