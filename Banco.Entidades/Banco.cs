using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Banco.Entidades
{
    public class Banco
    {
        private int id;
        private string nombre;
        private string direccion;
        private DateTime fechaCreacion;

        public Banco(int _id, string _nombre, string _direccion, string _fechaCreacion)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.direccion = _direccion;
            this.fechaCreacion = Convert.ToDateTime(_fechaCreacion);
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }
    }
}
