using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.MagazineFactories
{
    /// <summary>
    /// Interfata ce are doua metode ce trebuie sa fie implementate de un factory.
    /// MakeFastFood va prelua un tip din enumul FastFoodType, iar MakeRestaurant un tip
    /// din Restaurant type. 
    /// </summary>
    public interface ILocalFactory
    {
        /// <summary>
        /// Metoda care ia un tip de local de fastfood si returneaza clasa respectiva.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
         Locale MakeFastFood( FastFoodType type);
        /// <summary>
        /// Metoda care ia un tip de local de restaurant si returneaza clasa respectiva.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        Locale MakeRestaurant( RestaurantType type);
    }
}
