using Models;

namespace ModelsTests
{
    public class WatchModelTests
    {
        private WatchModel _watchModel;

        [SetUp]
        public void Setup()
        {
            _watchModel = new WatchModel("Rolex", 100);
        }

        [TearDown]
        public void Teardown()
        {
            //if (_watchModel != null)
            //    _watchModel.Dispose();
        }

        [TestCase("Rolex", 100, 3, 200)]
        [TestCase("Michael Kors", 80, 2, 120)]
        [TestCase("Swatch", 50)]
        [TestCase("Casio", 30)]
        [TestCase("", 0, 4, 5)]
        [TestCase("", 0, 0, 0)]
        [TestCase("", 0, 0, -1)]
        [TestCase("", 0, -1, 0)]
        [TestCase("", -1, 0, 0)]
        [TestCase("", -1, -1, -1)]
        public void TestConstructor(string name, int price, int discountQuant = 0, int discountAmount = 0)
        {
            //if (_watchModel != null)
            //    _watchModel.Dispose();

            _watchModel = new WatchModel(name, price, discountQuant, discountAmount);

            Assert.IsNotNull(_watchModel);
            Assert.That(_watchModel.WatchName, Is.EqualTo(name));
            Assert.That(_watchModel.UnitPrice, Is.EqualTo(price));
            Assert.That(_watchModel.DiscountQuantity, Is.EqualTo(discountQuant));
            Assert.That(_watchModel.DiscountAmount, Is.EqualTo(discountAmount));
        }

        [TestCase("Rolex")]
        [TestCase("Michael Kors")]
        [TestCase("Swatch")]
        [TestCase("Casio")]
        [TestCase("CASIO")]
        [TestCase("casio")]
        [TestCase("")]
        [TestCase("qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnm")]
        [TestCase("1234567890")]
        [TestCase("!@#$%^&*()")]
        [TestCase("abcABC123!@#")]
        public void TestPropertyWatchName(string name)
        {
            _watchModel.WatchName = name;

            Assert.IsNotNull(_watchModel);
            Assert.That(_watchModel.WatchName, Is.EqualTo(name));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(1000)]
        [TestCase(99999)]
        [TestCase(999999)]
        public void TestPropertyUnitPrice(int price)
        {
            _watchModel.UnitPrice = price;

            Assert.IsNotNull(_watchModel);
            Assert.That(_watchModel.UnitPrice, Is.EqualTo(price));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(1000)]
        [TestCase(99999)]
        [TestCase(999999)]
        public void TestPropertyDiscountQuantity(int quant)
        {
            _watchModel.DiscountQuantity = quant;

            Assert.IsNotNull(_watchModel);
            Assert.That(_watchModel.DiscountQuantity, Is.EqualTo(quant));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(1000)]
        [TestCase(99999)]
        [TestCase(999999)]
        public void TestPropertyDiscountAmount(int amt)
        {
            _watchModel.DiscountAmount = amt;

            Assert.IsNotNull(_watchModel);
            Assert.That(_watchModel.DiscountAmount, Is.EqualTo(amt));
        }
    }
}