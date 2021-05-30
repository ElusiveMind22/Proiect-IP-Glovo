using LocaluriLibrary.Localuri.FastFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LocaluriLibrary.Localuri.MagazineFactories.FastFoodType;

namespace LocaluriLibrary.Localuri.MagazineFactories
{
    /// <summary>
    /// Clasa ce implementeaza interfata ILocalFactory. Metoda MakeFastFood va returna un tip de FastFood,
    /// iar metoda MakeRestaurant va returna NULL.
    /// </summary>
    public class FastFood : ILocalFactory
    {
        /// <summary>
        /// Metoda va returna un tip de local in functie de FastFoodType (Kfc/McDonalds).
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Locale MakeFastFood(FastFoodType type)
        {
            switch (type)   
            {

                case MCDONALDS: 
                    return new McDonalds();
                case KFC:
                    Console.WriteLine("JARATICULE!");
                    return new Kfc();
                default: 
                    return null;

            }
        }
        /// <summary>
        /// Returneaza null, deoarece scopul acestei clase este sa creeze localuri de tipul FastFood.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Locale MakeRestaurant(RestaurantType type)
        {
            return null;
        }
    }
}
