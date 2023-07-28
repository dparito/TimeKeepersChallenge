namespace Models
{
    public class WatchModel
    {
        #region Constructor

        public WatchModel(string watchName, int price, int discountQuant = 0, int discountAmount = 0)
        {
            WatchName = watchName;
            UnitPrice = price;
            DiscountQuantity = discountQuant;
            DiscountAmount = discountAmount;
            OrderedQuantity = 0;
        }

        #endregion // Constructor

        #region Public Properties

        public string WatchName { get; set; }

        public int UnitPrice { get; set; }

        public int DiscountQuantity { get; set; }

        public int DiscountAmount { get; set; }

        public int OrderedQuantity { get; set; }

        #endregion // Public Properties
    }
}