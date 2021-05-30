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
    public class MammaMia : MagazineRestaurante
    {
        /// <summary>
        /// Constructor ce atribuie valorile specifice restaurantului.
        /// </summary>
        public MammaMia() : base()
        {

            //Atribuire Variabile

            _meniu = new string[8];
            _meniu[0] = "Pizza traditionala";
            _meniu[1] = "Pizza Verona";
            _meniu[2] = "Penne cu vita";
            _meniu[3] = "Coaste de porc";
            _meniu[4] = "Quesadilla de pui";
            _meniu[5] = "Coltunasi cu branza";
            _meniu[6] = "Snitel legume";
            _meniu[7] = "Prajitura red velvet";

            _preturi = new double[8];
            _preturi[0] = 31.5;
            _preturi[1] = 33.9;
            _preturi[2] = 25.5;
            _preturi[3] = 51.4;
            _preturi[4] = 23.5;
            _preturi[5] = 19.5;
            _preturi[6] = 14.9;
            _preturi[7] = 12.5;

            _numeleDeLocal = "MammaMia";

            // Gettere - Settere.

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;
        }

    }
}
