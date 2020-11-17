using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class SinCuentasException : Exception
    {
        public SinCuentasException():base("No hay cuentas registradas.") { }
    }

    public class CuentaInexistenteException : Exception
    {
        public CuentaInexistenteException(int nroCuenta) : base(string.Format("No hay cuentas registradas con el número \"{0}\"", nroCuenta)) { }
    }

    public class SinClientesException : Exception
    {
        public SinClientesException() : base("No hay clientes registrados.") { }
    }
}
