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
        public BancoServicio()
        {
            this.banco = new Entidades.Banco(1, "Banco Hipotecario S.A.", "Reconquista 151, CABA", "24-09-1886");
            this.cuentaServicio = new CuentaServicio();
        }
    }
}
