using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class Operador : Persona
    {
        private List<Prestamo> _prestamos;
        private double _comision;
        private double _porcentajeComision;

        public Operador()
        {
            this._prestamos = new List<Prestamo>();
        }

        public List<Prestamo> Prestamos
        {
            get
            {
                return this._prestamos;
            }
            set
            {
                this._prestamos = value;
            }
        }

        public double Comision
        {
            get
            {
                return this._comision;
            }
            set
            {
                this._comision = value;
            }
        }

        public double PorcentajeComision
        {
            get
            {
                return this._porcentajeComision;
            }
            set
            {
                this._porcentajeComision = value;
            }
        }
    }
}
