using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    [DataContract]
    public abstract class Persona
    {
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected string email;
        protected string telefono;
        protected string direccion;
        protected DateTime fechaNacimiento;
    }
}
