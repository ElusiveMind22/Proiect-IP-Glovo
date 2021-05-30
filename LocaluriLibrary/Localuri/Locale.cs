using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri
{
    /// <summary>
    /// Clasa Locale va fi implementata cu ajutorul Design Patternului "Abstract Factory".
    /// Clasa contine date despre meniul si preturile unui local, tipul de local si numele unui local.
    /// </summary>
    public abstract class Locale
    {
        /// <summary>
        /// _meniu stocheaza variabile de tip string[] ce semnifica tipurile de preparate servite la un local.
        /// </summary>
        protected string[] _meniu;
        /// <summary>
        /// _preturi stocheaza variabile de tip double[] ce semnifica preturile preparatelor servite la un local.
        /// </summary>
        protected double[] _preturi;
        /// <summary>
        /// _tipDeLocal stocheaza tipul de local ce poate fi "Restauran" sau "FastFood"
        /// </summary>
        protected string _tipDeLocal;
        /// <summary>
        /// _numeleDeLocal stocheaza numele localului.
        /// </summary>
        protected string _numeleDeLocal;

        /// <summary>
        /// Constructorul clasei
        /// </summary>
        public Locale()
        {

        }
        
        /// <summary>
        /// Proprietatea de get/set pentru _meniu.
        /// </summary>
        public string[] Meniu { get; set; }
        /// <summary>
        /// Proprietatea de get/set pentru _preturi.
        /// </summary>
        public double[] Preturi { get; set; }
        /// <summary>
        /// Proprietatea de get/set pentru _tipDeLocal.
        /// </summary>
        public string TipDeLocal { get; set; }
        /// <summary>
        /// Proprietatea de get/set pentru _numeleDeLocal.
        /// </summary>
        public string NumeleDeLocal { get; set; }
    }


}
