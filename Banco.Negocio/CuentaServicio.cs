using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Datos;
using Banco.Entidades;

namespace Banco.Negocio
{
    public class CuentaServicio
    {
        private ClienteServicio clienteServicio;
        private CuentaMapper cuentaMapper;
        private List<Cuenta> cuentas;

        public CuentaServicio()
        {
            clienteServicio = new ClienteServicio();
            cuentaMapper = new CuentaMapper();
            cuentas = new List<Cuenta>();
        }

        public ClienteServicio ClienteServicio
        {
            get
            {
                return this.clienteServicio;
            }
            set
            {
                this.clienteServicio = value;
            }
        }

        public List<Cuenta> Cuentas
        {
            get
            {
                return this.cuentas;
            }
            set
            {
                this.cuentas = value;
            }
        }

        public List<Cuenta> TraerCuentas()
        {
            this.cuentas = cuentaMapper.TraerTodos();

            if (cuentas.Count > 0)
                return cuentas;
            else
                throw new SinCuentasException();
        }

        public int NuevaCuenta(int idCuenta, int idCliente, int nroCuenta, string descripcion)
        {
            Cuenta cuenta = new Cuenta(idCuenta, idCliente, nroCuenta, descripcion, _saldo: 0, _activo: true);

            TransactionResult result = cuentaMapper.Insert(cuenta);

            if (result.IsOk)
            {
                return result.Id;
            }
            else
            {
                throw new Exception(string.Format("Ocurrió un error en el servidor: {0}.", result.Error));
            }
        }

        public int EditarSaldo(int nroCuenta, float saldo)
        {
            Cuenta cuenta = BuscarCuenta(nroCuenta);

            if (cuenta != null)
            {
                cuenta.Saldo = saldo;

                TransactionResult result = cuentaMapper.Insert(cuenta);

                if (result.IsOk)
                {
                    return result.Id;
                }
                else
                {
                    throw new Exception(string.Format("Ocurrió un error en el servidor: {0}.", result.Error));
                }
            }
            else
            {
                throw new CuentaInexistenteException(nroCuenta);
            }
        }

        internal Cuenta BuscarCuenta(int nroCuenta)
        {
            foreach(Cuenta cuenta in cuentas)
            {
                if(cuenta.NroCuenta == nroCuenta)
                {
                    return cuenta;
                }
            }
            return null;
        }
    }
}
