using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.FastFood
{
    /// <summary>
    /// Clasa abstracta ce trebuie sa fie mostenita de o clasa de 
    /// tip FastFood (KFC, McDonalds) si mosteneste clasa Locale. Ea are scopul
    /// de a seta variabila _tipDeLocal cu valoarea "FastFood".
    /// </summary>
    public class MagazineFastFood:Locale
    {
        /// <summary>
        /// Constructor ce atribuie lui _tipDeLocal valoarea "FastFood"
        /// </summary>
        public MagazineFastFood() : base()
        {
            _tipDeLocal = "FastFood";
        }
    }
}
