using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Entidades;
using Banco.Datos;

namespace Banco.Negocio
{
    public class PrestamoServicio
    {
        private List<Prestamo> _prestamos;
        private List<Operador> _operadores;
        private PrestamoMapper prestamoMapper;
        private PrestamoTipoMapper prestamoTipoMapper;

        public PrestamoServicio()
        {
            this.prestamoMapper = new PrestamoMapper();
            this.prestamoTipoMapper = new PrestamoTipoMapper();
            this._prestamos = new List<Prestamo>();
            this._operadores = new List<Operador>();
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

        public List<Operador> Operadores
        {
            get
            {
                return this._operadores;
            }
            set
            {
                this._operadores = value;
            }
        }

        public List<Prestamo> TraerPrestamos()
        {
            this._prestamos = new List<Prestamo>();
            this._prestamos = this.prestamoMapper.TraerTodos();

            return this._prestamos;
        }

        public List<Prestamo> TraerPrestamosByCliente(int idCliente)
        {
            this._prestamos = new List<Prestamo>();
            this._prestamos = this.prestamoMapper.TraerPorCliente(idCliente);

            return this._prestamos;
        }

        public int CargarPrestamo(Prestamo prestamo)
        {
            TransactionResult result = prestamoMapper.Insert(prestamo);

            if (result.IsOk)
            {
                this.Prestamos.Add(prestamo);
                return result.Id;
            }
            else
            {
                throw new Exception(string.Format("Ocurrió un error en el servidor: {0}", result.Error));
            }
        }

    }
}
