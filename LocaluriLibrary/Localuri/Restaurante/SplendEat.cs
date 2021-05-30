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

    public class SplendEat : MagazineRestaurante
    {
        /// <summary>
        /// Constructor ce atribuie valorile specifice restaurantului.
        /// </summary>
        public SplendEat() : base()
        {

            //Atribuire Variabile

            _meniu = new string[8];
            _meniu[0] = "Halloumi burger";
            _meniu[1] = "Hot box";
            _meniu[2] = "Wrap Aioli";
            _meniu[3] = "Wrap gyros";
            _meniu[4] = "Wrap cu halloumi";
            _meniu[5] = "Supa crema ciuperci";
            _meniu[6] = "Supa crema de rosii";
            _meniu[7] = "Pui la gratar";

            _preturi = new double[8];
            _preturi[0] = 20.89;
            _preturi[1] = 21.99;
            _preturi[2] = 16.49;
            _preturi[3] = 16.49;
            _preturi[4] = 19.79;
            _preturi[5] = 10.99;
            _preturi[6] = 10.99;
            _preturi[7] = 12.09;

            _numeleDeLocal = "SplendEat";

            // Gettere - Settere.

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;

        }

    }
}
