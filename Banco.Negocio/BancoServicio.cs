using System;
using Banco.Entidades;
using Banco.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    public class BancoServicio
    {
        private Entidades.Banco banco;
        private CuentaServicio cuentaServicio;
        private PrestamoServicio prestamoServicio;
        private UtilidadServicio utilidadServicio;

        public BancoServicio()
        {
            this.banco = new Entidades.Banco(1, "Banco Hipotecario S.A.", "Reconquista 151, CABA", "09-24-1886");
            this.cuentaServicio = new CuentaServicio();
            this.prestamoServicio = new PrestamoServicio();
            this.utilidadServicio = new UtilidadServicio();
        }

        public UtilidadServicio UtilidadServicio
        {
            get
            {
                return this.utilidadServicio;
            }
            set
            {
                this.utilidadServicio = value;
            }
        }

        public CuentaServicio CuentaServicio
        {
            get
            {
                return this.cuentaServicio;
            }
            set
            {
                this.cuentaServicio = value;
            }
        }

        public PrestamoServicio PrestamoServicio
        {
            get
            {
                return this.prestamoServicio;
            }
            set
            {
                this.prestamoServicio = value;
            }
        }
    }
}
