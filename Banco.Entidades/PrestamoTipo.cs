using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class PrestamoTipo
    {
        protected string _linea;
        protected double _tna;

        public string Linea
        {
            get
            {
                return this._linea;
            }
            set
            {
                this._linea = value;
            }
        }

        public double TNA
        {
            get
            {
                return this._tna;
            }
            set
            {
                this._tna = value;
            }
        }
    }
}
