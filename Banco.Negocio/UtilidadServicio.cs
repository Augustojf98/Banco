using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Datos;
using Banco.Entidades;

namespace Banco.Negocio
{
    public class UtilidadServicio
    {
        private UtilidadMapper utilidadMapper;

        public UtilidadServicio()
        {
            this.utilidadMapper = new UtilidadMapper();
        }

        public int EnviarCorreo(string para, string asunto, string mensaje)
        {
            if (string.IsNullOrEmpty(para))
            {
                throw new Exception("El cliente no tiene email registrado para enviar la actualización");
            }

            TransactionResult result = utilidadMapper.Insert(new Utilidad(para, asunto, mensaje));

            if (result.IsOk)
            {
                return result.Id;
            }
            else
            {
                throw new Exception("Ocurrió un error en el servidor: " + result.Error.ToString());
            }
        }
    }
}
