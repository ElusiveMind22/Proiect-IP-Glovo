using LocaluriLibrary.Localuri.MagazineFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.Restaurante
{

    public class LaCuib : MagazineRestaurante
    {
        public LaCuib() : base()
        {
            _meniu = new string[8];
            _meniu[0] = "Meniul zilei";
            _meniu[1] = "Salata";
            _meniu[2] = "Burger vegan";
            _meniu[3] = "Turta pleurotus";
            _meniu[4] = "Paste cu pesto";
            _meniu[5] = "Bors";
            _meniu[6] = "Briosa vegana";
            _meniu[7] = "Cartofi la tigaie";

            _preturi = new double[8];
            _preturi[0] = 18;
            _preturi[1] = 25;
            _preturi[2] = 23;
            _preturi[3] = 25;
            _preturi[4] = 25;
            _preturi[5] = 14;
            _preturi[6] = 5;
            _preturi[7] = 10;

            _numeleDeLocal = "LaCuib";

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;
        }

    }
}
