using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocaluriLibrary.Localuri;
using LocaluriLibrary.Localuri.MagazineFactories;

namespace UnitTests
{
    /// <summary>
    /// Verifica daca preturile produselor sunt calculate corect.
    /// </summary>
    [TestClass]
    public class TestBuyFood
    {
        /// <summary>
        /// Verifica daca pretul pentru 2 aripioare de la KFC este corect calculat.
        /// </summary>
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

        /// <summary>
        /// Verifica daca pretul calculat pentru 10 nuggets de la KFC este corect calculat.
        /// </summary>
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

        /// <summary>
        /// Verifica daca pretul pentru 5 BigTasty de la KFC este corect calculat.
        /// </summary>
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

        /// <summary>
        /// Verifica daca pretul pentru 3 Baconuf de la Cartuf este corect calculat.
        /// </summary>
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

        /// <summary>
        /// Verifica daca pretul pentru 3 SmartPackShangai de la KFC este corect calculat.
        /// </summary>
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
    }
}
