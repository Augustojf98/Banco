﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    [DataContract]
    public class Cuenta
    {
        private int id;
        private int idCliente;
        private int nroCuenta;
        private string descripcion;
        private float saldo;
        private DateTime fechaApertura;
        private DateTime fechaModificacion;
        private bool activo;

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
        public int NroCuenta
        {
            get
            {
                return this.nroCuenta;
            }
            set
            {
                this.nroCuenta = value;
            }
        }

        [DataMember]
        public float Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        [DataMember]
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }

        [DataMember]
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
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

        [DataMember]
        public DateTime FechaApertura
        {
            get
            {
                return this.fechaApertura;
            }
            set
            {
                this.fechaApertura = value;
            }
        }

        [DataMember]
        public DateTime FechaModificacion
        {
            get
            {
                return this.fechaModificacion;
            }
            set
            {
                this.fechaModificacion = value;
            }
        }
    }
}
