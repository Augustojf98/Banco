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
    }
}
