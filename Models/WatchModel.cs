namespace Models
{
    /// <summary>
    /// Model class for Watches
    /// </summary>
    public class WatchModel
    {
        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="watchName">Watch Name</param>
        /// <param name="price">Per Unit Price</param>
        /// <param name="discountQuant"># of items to which discount can be applied (optional)</param>
        /// <param name="discountAmount">Discount amount (optional)</param>
        public WatchModel(string watchName, int price, int discountQuant = 0, int discountAmount = 0)
        {
            WatchName = watchName;
            UnitPrice = price;
            DiscountQuantity = discountQuant;
            DiscountAmount = discountAmount;
        }

        #endregion // Constructor

        #region Public Properties

        public string WatchName { get; set; }

        public int UnitPrice { get; set; }

        public int DiscountQuantity { get; set; }

        public int DiscountAmount { get; set; }

        #endregion // Public Properties
    }
}