using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Banco.Entidades
{
    [DataContract]
    public class Cliente : Persona
    {
        private int id;
        private bool activo;
        private DateTime fechaAlta;

        [DataMember]
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        
        [DataMember]
        public DateTime FechaAlta
        {
            get
            {
                return this.fechaAlta;
            }
            set
            {
                this.fechaAlta = value;
            }
        }

        [DataMember]
        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }
        }


        public Cliente(int _id, int _dni, string _nombre, string _apellido, string _direccion, string _telefono, string _email, string _fechaNacimiento)
        {
            this.id = _id;
            this.dni = _dni;
            this.direccion = _direccion;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.telefono = _telefono;
            this.email = _email;
            this.fechaNacimiento = Convert.ToDateTime(_fechaNacimiento);
            this.fechaAlta = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        public override string ToString()
        {
            return string.Format("Cliente {0} {1}, DNI {2}.", this.nombre?.ToUpper(), this.apellido?.ToUpper(), this.dni);
        }
    }
}
