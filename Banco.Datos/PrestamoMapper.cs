using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Entidades;
using Newtonsoft.Json;

namespace Banco.Datos
{
    public class PrestamoMapper
    {
        public List<Prestamo> TraerTodos()
        {
            int registro = int.Parse(ConfigurationManager.AppSettings["Legajo"]);
            string json2 = WebHelper.Get("/prestamo/{registro}"); // trae un texto en formato json de una web
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }

        public List<Prestamo> TraerPorCliente(int idCliente)
        {
            int registro = int.Parse(ConfigurationManager.AppSettings["Legajo"]);
            string json2 = WebHelper.Get("/prestamo/{registro}/{idCliente}"); // trae un texto en formato json de una web
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }

        public TransactionResult Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo/*, string.Empty*/);

            string result = WebHelper.Post("/prestamo", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        //public TransactionResult Put(Cuenta cuenta)
        //{
        //    NameValueCollection obj = ReverseMap(cuenta, "Update");

        //    string result = WebHelper.Post("/cuenta", obj);

        //    TransactionResult resultadoTransaccion = MapResultado(result);

        //    return resultadoTransaccion;
        //}

        public TransactionResult Delete(Prestamo prestamo)
        {
            NameValueCollection obj = new NameValueCollection();

            obj.Add("id", prestamo.Id.ToString());

            string result = WebHelper.Delete("/prestamo", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", prestamo.Id.ToString());
            n.Add("tna", prestamo.TNA.ToString());
            n.Add("linea", prestamo.Linea.ToString());
            n.Add("plazo", prestamo.Plazo.ToString());
            n.Add("idCliente", prestamo.IdCliente.ToString());
            n.Add("monto", prestamo.Monto.ToString());
            n.Add("cuota", prestamo.Cuota.ToString());
            n.Add("usuario", prestamo.Usuario.ToString());
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
