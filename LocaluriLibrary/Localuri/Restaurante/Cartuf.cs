using LocaluriLibrary.Localuri.MagazineFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.Restaurante
{
    /// <summary>
    /// Clasa ce mosteneste clasa abstracta MagazineRestaurant.
    /// </summary>
    public class Cartuf : MagazineRestaurante
    {
        /// <summary>
        /// Constructor ce atribuie valorile specifice restaurantului.
        /// </summary>
        public Cartuf() : base()
        {
            
            //Atribuire Variabile

            _meniu = new string[8];
            _meniu[0] = "Carnaciuf";
            _meniu[1] = "Supertuf";
            _meniu[2] = "Torteluf";
            _meniu[3] = "Pizzuf";
            _meniu[4] = "Baconuf";
            _meniu[5] = "Veguf";
            _meniu[6] = "Cartuf mediu";
            _meniu[7] = "Cartuf Mare";

            _preturi = new double[8];
            _preturi[0] = 17;
            _preturi[1] = 19;
            _preturi[2] = 17;
            _preturi[3] = 17;
            _preturi[4] = 17;
            _preturi[5] = 17;
            _preturi[6] = 5;
            _preturi[7] = 8;

            _numeleDeLocal = "Cartuf";

            // Gettere - Settere.

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;
        }

    }
}   
