using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    [DataContract]
    public class PrestamoTipo
    {
        protected string _linea;
        protected double _tna;

        [DataMember]
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

        [DataMember]
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

        public override string ToString()
        {
            return string.Format("{0} | {1}", this._linea, this._tna);
        }
    }
}
