using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocaluriLibrary.Localuri;
using LocaluriLibrary.Localuri.MagazineFactories;

namespace UnitTests
{
    [TestClass]
    public class TestFactoryLocalCreate
    {
        [TestMethod]
        public void FastFoodMakeRestaurant()
        {
            //Arrange 

            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeRestaurant(RestaurantType.CARTUF);

            //Assert
            Assert.IsNull(local);
        }
        [TestMethod]
        public void FastFoodMakeRestaurant2()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeRestaurant(RestaurantType.DELICIO);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void FastFoodMakeRestaurant3()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeRestaurant(RestaurantType.LACUIB);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void FastFoodMakeRestaurant4()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeRestaurant(RestaurantType.MAMMAMIA);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void FastFoodMakeRestaurant5()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeRestaurant(RestaurantType.NOODLEPACK);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void FastFoodMakeRestaurant6()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeRestaurant(RestaurantType.OXFORD);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void FastFoodMakeRestaurant7()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeRestaurant(RestaurantType.SPLENDEAT);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void RestaurantMakeFastFood1()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeFastFood(FastFoodType.MCDONALDS);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void RestaurantMakeFastFood2()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeFastFood(FastFoodType.KFC);

            //Assert
            Assert.IsNull(local);

        }
        [TestMethod]
        public void FastFoodMakeFastFood1()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.KFC);

            //Assert
            Assert.IsNotNull(local);

        }
        [TestMethod]
        public void FastFoodMakeFastFood2()
        {
            //Arrange 
            ILocalFactory fastFoodMaker = new FastFood();
            Locale local;
            local = fastFoodMaker.MakeFastFood(FastFoodType.MCDONALDS);

            //Assert
            Assert.IsNotNull(local);

        }
        [TestMethod]
        public void RestaurantMakeRestaurant1()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.CARTUF);

            //Assert
            Assert.IsNotNull(local);

        }
        [TestMethod]
        public void RestaurantMakeRestaurant2()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.DELICIO);

            //Assert
            Assert.IsNotNull(local);

        }
        [TestMethod]
        public void RestaurantMakeRestaurant3()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.LACUIB);

            //Assert
            Assert.IsNotNull(local);

        }
        [TestMethod]
        public void RestaurantMakeRestaurant4()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.MAMMAMIA);

            //Assert
            Assert.IsNotNull(local);

        }
        [TestMethod]
        public void RestaurantMakeRestaurant5()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.NOODLEPACK);

            //Assert
            Assert.IsNotNull(local);

        }
        [TestMethod]
        public void RestaurantMakeRestaurant6()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.OXFORD);

            //Assert
            Assert.IsNotNull(local);
        }
        [TestMethod]
        public void RestaurantMakeRestaurant7()
        {
            //Arrange 
            ILocalFactory restaurantMaker = new Restaurant();
            Locale local;
            local = restaurantMaker.MakeRestaurant(RestaurantType.SPLENDEAT);

            //Assert
            Assert.IsNotNull(local);

        }
        
    }
}
