using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class Prestamo : PrestamoTipo
    {
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;
        private int _idCliente;

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

        public string Usuario
        {
            get
            {
                return this._usuario;
            }
            set
            {
                this._usuario = ConfigurationManager.AppSettings["Legajo"];
            }
        }

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

        public double CuotaCapital
        {
            get
            {
                return this._monto / this._plazo;
            }
        }

        public double CuotaInteres
        {
            get
            {
                return this.CuotaCapital * (this._tna / 12 / 100);
            }
        }

        public double Cuota
        {
            get
            {
                return this.CuotaCapital + this.CuotaInteres;
            }
        }
    }
}
