using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Entidades;
using Banco.Datos;

namespace Banco.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper clienteMapper;
        private List<Cliente> clientes;

        public ClienteServicio()
        {
            clienteMapper = new ClienteMapper();
            clientes = new List<Cliente>();
        }
    }
}
