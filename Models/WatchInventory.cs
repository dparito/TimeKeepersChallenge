using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Model class for Watch Inventory. Set/Modify watch inventory from here
    /// </summary>
    public class WatchInventory
    {
        #region Constructor

        public WatchInventory()
        {
            Inventory = new Dictionary<int, WatchModel>()
            {
                { 1, new WatchModel("Rolex", 100, 3, 200) },
                { 2, new WatchModel("Michael Kors", 80, 2, 120) },
                { 3, new WatchModel("Swatch", 50) },
                { 4, new WatchModel("Casio", 30) },
            };
        }

        #endregion // Constructor

        #region Public Properties

        public Dictionary<int, WatchModel> Inventory { get; private set; }

        #endregion // Public Properties
    }
}
