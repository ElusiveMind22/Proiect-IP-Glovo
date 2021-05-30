using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.Restaurante
{
    /// <summary>
    /// Clasa abstracta ce trebuie sa fie mostenita de o clasa de 
    /// tip Restaurant (Catruf, Delicio, etc) si mosteneste clasa Locale. Ea are scopul
    /// de a seta variabila _tipDeLocal cu valoarea "Restaurant".
    /// </summary>
    public abstract class MagazineRestaurante : Locale  
    {

        /// <summary>
        /// Constructor ce atribuie lui _tipDeLocal valoarea "Restaurant"
        /// </summary>
        public MagazineRestaurante():base()
        {
            _tipDeLocal = "Restaurant";
        }
    }
}
