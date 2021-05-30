using LocaluriLibrary.Localuri.MagazineFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.Restaurante
{
    public class Cartuf : MagazineRestaurante
    {
        public Cartuf() : base()
        {
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

            Meniu = _meniu;
            Preturi = _preturi;
            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;
        }

    }
}   
