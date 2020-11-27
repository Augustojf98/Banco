using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Banco.Entidades;
using Newtonsoft.Json;

namespace Banco.Datos
{
    public class UtilidadMapper
    {
        public TransactionResult Insert(Utilidad utilidad)
        {
            NameValueCollection obj = ReverseMap(utilidad);

            string result = WebHelper.Post("/Utilidades", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private NameValueCollection ReverseMap(Utilidad utilidad)
        {
            string hostName = Dns.GetHostName();
            string usuarioUtilizado;
            string usuario1 = ConfigurationManager.AppSettings["Legajo"];

            if (usuario1 != null)
                usuarioUtilizado = usuario1;
            else
                throw new Exception("El usuario de interacción con el servidor es incorrecto.");

            NameValueCollection n = new NameValueCollection();
            n.Add("Para", utilidad.Para);
            n.Add("Asunto", utilidad.Asunto);
            n.Add("Mensaje", utilidad.Mensaje);
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
