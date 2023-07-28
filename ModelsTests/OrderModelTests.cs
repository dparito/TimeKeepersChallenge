using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTests
{
    public class OrderModelTests
    {
        private OrderModel _order;
        private WatchModel _rolex;
        private WatchModel _mKors;
        private WatchModel _swatch;
        private WatchModel _casio;

        [SetUp]
        public void Setup()
        {
            _order = new OrderModel();
            _rolex = new WatchModel("Rolex", 100, 3, 200);
            _mKors = new WatchModel("Michael Kors", 80, 2, 120);
            _swatch = new WatchModel("Swatch", 50);
            _casio = new WatchModel("Casio", 30);
        }

        [TearDown] public void TearDown() { }

        [TestCase]
        public void TestConstructor()
        {
            OrderModel model = new OrderModel();
            
            Assert.IsNotNull(model);
            Assert.IsNotNull(model.OrderByWatchId);
            Assert.That(model.TotalCost, Is.EqualTo(0));
        }

        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, -1)]
        [TestCase(100, 100)]
        [TestCase(999999, 999999)]
        public void TestPropertyOrderByWatchId(int key, int val) 
        {
            _order.OrderByWatchId.Add(key, val);

            Assert.IsNotNull(_order.OrderByWatchId);
            Assert.That(_order.OrderByWatchId.Count, Is.GreaterThan(0));
            Assert.That(_order.OrderByWatchId[key], Is.EqualTo(val));
        }

        [TestCase]
        public void TestPropertyTotalCost()
        {
            OrderModel model = new OrderModel();

            Assert.That(model.TotalCost, Is.EqualTo(0));
        }

        [TestCase(0,0,0,0)]
        public void TestCalculateTotalCost(int rolexCount, int mkCount, int swatchCount, int casioCount)
        {
            var watches = new Dictionary<int, WatchModel>()
            {
                { 1, _rolex },
                { 2, _mKors },
                { 3, _swatch },
                { 4, _casio },
            };

            _order.OrderByWatchId.Add(1, rolexCount);
            _order.OrderByWatchId.Add(2, mkCount);
            _order.OrderByWatchId.Add(3, swatchCount);
            _order.OrderByWatchId.Add(4, casioCount);

            var total = _order.CalculateTotalCost(watches);

            Assert.That(_order.TotalCost, Is.GreaterThanOrEqualTo(0));
        }
    }
}
