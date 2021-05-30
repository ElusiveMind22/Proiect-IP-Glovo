using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LocaluriLibrary.Localuri.MagazineFactories.RestaurantType;
using LocaluriLibrary.Localuri.Restaurante;
namespace LocaluriLibrary.Localuri.MagazineFactories
{
    /// <summary>
    /// Clasa ce implementeaza interfata ILocalFactory. Metoda MakeRestaurant va returna un tip de FastFood,
    /// iar metoda MakeFastFood va returna NULL.
    /// </summary>
    public class Restaurant : ILocalFactory
    {

        /// <summary>
        /// Metoda va returna un tip de local in functie de RestaurantType (Kfc/McDonalds).
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Locale MakeRestaurant(RestaurantType type)
        {
            switch (type)
            {

                case SPLENDEAT:
                    return new SplendEat();
                case NOODLEPACK:
                    return new NoodlePack();
                case LACUIB:
                    return new LaCuib();
                case OXFORD:
                    return new Oxford();
                case CARTUF:
                    return new Cartuf();
                case MAMMAMIA:
                    return new MammaMia();
                case DELICIO:
                    return new Delicio();
                default:
                    return null;

            }
        }
        /// <summary>
        /// Returneaza null, deoarece scopul acestei clase este sa creeze localuri de tipul Restaurant.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Locale MakeFastFood(FastFoodType type)
        {
            Console.WriteLine("NU POTI IMPLEMENTA UN FASTFOOD CU UN MAKERESTAURANT!");
            return null;
        }
    }
}
