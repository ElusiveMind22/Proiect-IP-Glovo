using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocaluriLibrary.Localuri;
using LocaluriLibrary.Localuri.MagazineFactories;

namespace UnitTests
{
    [TestClass]
    public class TestFactoryLocalType
    {
        [TestMethod]
        public void TypeKFC()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            //Assert
            Assert.AreEqual("FastFood",local.TipDeLocal);

        }
        [TestMethod]
        public void TypeMcDonalds()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.MCDONALDS);

            //Assert
            Assert.AreEqual("FastFood", local.TipDeLocal);

        }
        [TestMethod]
        public void TypeCartuf()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.CARTUF);

            //Assert
            Assert.AreEqual("Restaurant", local.TipDeLocal);

        }
        [TestMethod]
        public void TypeDelicio()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.DELICIO);

            //Assert
            Assert.AreEqual("Restaurant", local.TipDeLocal);

        }
        [TestMethod]
        public void TypeLaCuib()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.LACUIB);

            //Assert
            Assert.AreEqual("Restaurant", local.TipDeLocal);

        }
        [TestMethod]
        public void TypeMammaMia()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.MAMMAMIA);

            //Assert
            Assert.AreEqual("Restaurant", local.TipDeLocal);

        }
        [TestMethod]
        public void TypeNoodlePack()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.NOODLEPACK);

            //Assert
            Assert.AreEqual("Restaurant", local.TipDeLocal);

        }
        [TestMethod]
        public void TypeOxford()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.OXFORD);

            //Assert
            Assert.AreEqual("Restaurant", local.TipDeLocal);
        }
        [TestMethod]
        public void TypeSplendeat()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.SPLENDEAT);

            //Assert
            Assert.AreEqual("Restaurant", local.TipDeLocal);

        }
        
    }
}
