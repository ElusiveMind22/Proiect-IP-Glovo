using LocaluriLibrary.Localuri.MagazineFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.Restaurante
{
    public class NoodlePack : MagazineRestaurante
    {


        public NoodlePack() : base()
        {
            _meniu = new string[8];
            _meniu[0] = "Noodle cu creveti";
            _meniu[1] = "Noodle cu vita";
            _meniu[2] = "Noodle crispy picant";
            _meniu[3] = "Noodle orange chicken";
            _meniu[4] = "SmartPack vegetarian";
            _meniu[5] = "SmartPack shangai";
            _meniu[6] = "SmartPack crispy";
            _meniu[7] = "SmartPack nuggets";

            _preturi = new double[8];
            _preturi[0] = 18;
            _preturi[1] = 24;
            _preturi[2] = 19;
            _preturi[3] = 15;
            _preturi[4] = 20;
            _preturi[5] = 19.5;
            _preturi[6] = 22;
            _preturi[7] = 19;

            _numeleDeLocal = "NoodlePack";

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;
        }
    }
}
