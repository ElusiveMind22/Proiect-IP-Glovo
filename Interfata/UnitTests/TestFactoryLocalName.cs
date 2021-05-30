using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocaluriLibrary.Localuri;
using LocaluriLibrary.Localuri.MagazineFactories;

namespace UnitTests
{
    [TestClass]
    public class TestFactoryLocalName
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameKFC()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            //Assert
            Assert.AreEqual("KFC", local.NumeleDeLocal);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestAripioareKFC()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            //Assert
            Assert.AreEqual("Aripioare", local.Meniu[0]);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameMcDonalds()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.MCDONALDS);

            //Assert
            Assert.AreEqual("McDonalds", local.NumeleDeLocal);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameCartuf()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.CARTUF);

            //Assert
            Assert.AreEqual("Cartuf", local.NumeleDeLocal);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameDelicio()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.DELICIO);

            //Assert
            Assert.AreEqual("Delicio", local.NumeleDeLocal);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameLaCuib()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.LACUIB);

            //Assert
            Assert.AreEqual("LaCuib", local.NumeleDeLocal);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameMammaMia()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.MAMMAMIA);

            //Assert
            Assert.AreEqual("MammaMia", local.NumeleDeLocal);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameNoodlePack()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.NOODLEPACK);

            //Assert
            Assert.AreEqual("NoodlePack", local.NumeleDeLocal);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NameOxford()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.OXFORD);

            //Assert
            Assert.AreEqual("Oxford", local.NumeleDeLocal);
        }

        /// <summary>
        /// Verifica daca 
        /// </summary>
        [TestMethod]
        public void NameSplendeat()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.SPLENDEAT);

            //Assert
            Assert.AreEqual("SplendEat", local.NumeleDeLocal);

        }

    }
}
