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

        public int NuevaCuenta(int idCliente, float saldoInicial, string descripcion)
        {
            int idCuenta = UltimoIdCuenta + 1;

            do
            {
                idCuenta = idCuenta + 1;
            }
            while (BuscarCuentaById(idCuenta) != null);

            Cuenta cuenta = new Cuenta(idCuenta, idCliente, _nroCuenta: 0, _descripcion: descripcion, _saldo: saldoInicial, _activo: true);

            TransactionResult result = cuentaMapper.Insert(cuenta);

            if (result.IsOk)
            {
                this.Cuentas.Add(cuenta);
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

        internal Cuenta BuscarCuentaById(int id)
        {
            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta.Id == id)
                {
                    return cuenta;
                }
            }
            return null;
        }

        public int UltimoIdCuenta
        {
            get
            {
                if (this.cuentas.Count > 0)
                    return this.cuentas.Count;
                else
                    return 0;
            }
        }
    }
}
