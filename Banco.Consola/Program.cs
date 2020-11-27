using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Entidades;
using Banco.Negocio;

namespace Banco.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteServicio ClienteServicio = new ClienteServicio();

            ClienteServicio.TraerClientes();

            ClienteServicio.AgregarCliente();
        }
    }
}
