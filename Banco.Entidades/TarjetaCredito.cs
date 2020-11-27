using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Banco.Entidades
{
    [DataContract]
    public class TarjetaCredito
    {
        private int _idCliente;
        private int _periodoVencimiento;
        private int _tipo;
        private double _limiteCompra;
        private string _nroPlastico;

        [DataMember]
        public string NroPlastico
        {
            get
            {
                return this._nroPlastico;
            }
            set
            {
                this._nroPlastico = value;
            }
        }

        [DataMember]
        public int Tipo
        {
            get
            {
                return this._tipo;
            }
            set
            {
                this._tipo = value;
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
        public int PeriodoVencimiento
        {
            get
            {
                return this._periodoVencimiento;
            }
            set
            {
                this._periodoVencimiento = value;
            }
        }

        [DataMember]
        public double LimiteCompra
        {
            get
            {
                return this._limiteCompra;
            }
            set
            {
                this._limiteCompra = value;
            }
        }

        public TarjetaCredito() {}

        public TarjetaCredito(int idCliente, int tipo, int periodoVencimiento, double limiteCompra, string nroPlastico)
        {
            this._tipo = tipo;
            this._periodoVencimiento = periodoVencimiento;
            this._idCliente = idCliente;
            this._limiteCompra = limiteCompra;
            this._nroPlastico = nroPlastico;
        }
    }
}
