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

        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                this.clientes = value;
            }
        }

        public int AgregarCliente()
        {
            TransactionResult result = clienteMapper.Insert(new Cliente(400, 41063486, "Augusto", "Falsone", "Falsa 123", "12334545", "pipo.falsone@gmail.com", "03-27-1998"));

            if (result.IsOk)
            {
                return result.Id;
            }
            else
            {
                throw new Exception("Ocurrió un error en el servidor, " + result.Error);
            }
        }

        public List<Cliente> TraerClientes()
        {
            this.clientes = clienteMapper.TraerTodos();

            if (clientes.Count > 0)
                return this.clientes;
            else
                throw new SinClientesException();
        }

        public Cliente BuscarClienteById(int id)
        {
            foreach(Cliente cliente in clientes)
            {
                if (cliente.Id == id)
                    return cliente;
            }
            return null;
        }
    }
}
