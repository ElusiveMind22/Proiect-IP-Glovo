using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocaluriLibrary.Localuri;
using LocaluriLibrary.Localuri.MagazineFactories;

namespace UnitTests
{
    [TestClass]
    public class TestBuyFood
    {
        [TestMethod]
        public void TestBuy2AripioareKFC()
        {
            //Arrange 
            double total = 0;
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            total = 2 * local.Preturi[0];
            //Assert
            Assert.AreEqual(10, total);
        }
        [TestMethod]
        public void TestBuy10NuggetsKFC()
        {
            //Arrange 
            double total = 0;
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            total = 10 * local.Preturi[2];
            //Assert
            Assert.AreEqual(120, total);
        }
        [TestMethod]
        public void TestBuy5BigTastyMC()
        {
            //Arrange 
            double total = 0;
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.MCDONALDS);

            total = 5 * local.Preturi[5];
            //Assert
            Assert.AreEqual(65, total);
        }
        [TestMethod]
        public void TestBuy3BaconufCartuf()
        {
            //Arrange 
            double total = 0;
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            total = 3 * local.Preturi[4];
            //Assert
            Assert.AreEqual(33, total);
        }
        [TestMethod]
        public void TestBuy3SmartPackShangai()
        {
            //Arrange 
            double total = 0;
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            total = 3 * local.Preturi[5];
            //Assert
            Assert.AreEqual(27, total);
        }
        [TestMethod]
        public void TestBuy2Aripioare()
        {
            //Arrange 
            double total = 0;
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            total = 2 * local.Preturi[0];
            //Assert
            Assert.AreEqual(10, total);
        }

    }
}
