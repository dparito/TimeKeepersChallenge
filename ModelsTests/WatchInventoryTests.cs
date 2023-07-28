using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTests
{
    public class WatchInventoryTests
    {
        private WatchInventory _watchInventory;
        private WatchModel _rolex;
        private WatchModel _mKors;
        private WatchModel _swatch;
        private WatchModel _casio;

        [SetUp]
        public void Setup()
        {
            _watchInventory = new WatchInventory();
            _rolex = new WatchModel("Rolex", 100, 3, 200);
            _mKors = new WatchModel("Michael Kors", 80, 2, 120);
            _swatch = new WatchModel("Swatch", 50);
            _casio = new WatchModel("Casio", 30);
        }

        [TearDown] public void Teardown()
        {

        }

        [TestCase]
        public void TestConstructor()
        {
            var inventory = new WatchInventory();

            Assert.IsNotNull(inventory);
            Assert.That(inventory.Inventory.Count, Is.GreaterThan(0));

            Assert.That(inventory.Inventory[1].WatchName, Is.EqualTo(_rolex.WatchName));
            Assert.That(inventory.Inventory[2].WatchName, Is.EqualTo(_mKors.WatchName));
            Assert.That(inventory.Inventory[3].WatchName, Is.EqualTo(_swatch.WatchName));
            Assert.That(inventory.Inventory[4].WatchName, Is.EqualTo(_casio.WatchName));
        }

        [TestCase]
        public void TestPropertyInventory()
        {
            Assert.IsNotNull(_watchInventory);
            Assert.That(_watchInventory.Inventory.Count, Is.GreaterThan(0));

            Assert.That(_watchInventory.Inventory[1].WatchName, Is.EqualTo(_rolex.WatchName));
            Assert.That(_watchInventory.Inventory[2].WatchName, Is.EqualTo(_mKors.WatchName));
            Assert.That(_watchInventory.Inventory[3].WatchName, Is.EqualTo(_swatch.WatchName));
            Assert.That(_watchInventory.Inventory[4].WatchName, Is.EqualTo(_casio.WatchName));
        }
    }
}
