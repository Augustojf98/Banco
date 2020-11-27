using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    [DataContract]
    public class Utilidad
    {
        private string _para;
        private string _asunto;
        private string _mensaje;

        [DataMember]
        public string Para
        {
            get
            {
                return this._para;
            }
            set
            {
                this._para = value;
            }
        }

        [DataMember]
        public string Asunto
        {
            get
            {
                return this._asunto;
            }
            set
            {
                this._asunto = value;
            }
        }

        [DataMember]
        public string Mensaje
        {
            get
            {
                return this._mensaje;
            }
            set
            {
                this._mensaje = value;
            }
        }

        public Utilidad(string para, string asunto, string mensaje)
        {
            this._para = para;
            this._asunto = asunto;
            this._mensaje = mensaje;
        }
    }
}
