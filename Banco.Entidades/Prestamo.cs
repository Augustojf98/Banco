using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    [DataContract]
    public class Prestamo : PrestamoTipo
    {
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;
        private int _idCliente;

        [DataMember]
        public new string Linea
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
        public new double TNA
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

        [DataMember]
        public int Plazo
        {
            get
            {
                return this._plazo;
            }
            set
            {
                this._plazo = value;
            }
        }

        [DataMember]
        public double Monto
        {
            get
            {
                return this._monto;
            }
            set
            {
                this._monto = value;
            }
        }

        [DataMember]
        public string Usuario
        {
            get
            {
                return ConfigurationManager.AppSettings["Legajo"];
            }
        }

        [DataMember]
        public int IdCliente
        {
            get
            {
                return this._idCliente;
            }
            set
            {
                this._idCliente = value;
            }
        }

        [DataMember]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        [DataMember]
        public double CuotaCapital
        {
            get
            {
                return this._monto / this._plazo;
            }
        }

        [DataMember]
        public double CuotaInteres
        {
            get
            {
                return this.CuotaCapital * (this._tna / 12 / 100);
            }
        }

        [DataMember]
        public double Cuota
        {
            get
            {
                return this.CuotaCapital + this.CuotaInteres;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - Tasa {1} | Monto: ${2} | Plazo: {3} meses | Cuota: ${4}", this._linea, this.TNA, this._monto, this._plazo, this.Cuota);
        }
    }
}
