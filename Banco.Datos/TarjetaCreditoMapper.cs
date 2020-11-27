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
    public class TarjetaCreditoMapper
    {
        public List<TarjetaCredito> TraerTodos()
        {
            string json2 = WebHelper.Get("/tarjetacredito/889059");
            List<TarjetaCredito> lst = MapList(json2);
            return lst;
        }

        public List<TarjetaCredito> MapList(string json2)
        {
            List<TarjetaCredito> resultado = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json2);
            return resultado;
        }

        public TransactionResult MapResultado(string json)
        {
            TransactionResult result = JsonConvert.DeserializeObject<TransactionResult>(json);
            return result;
        }

        public TransactionResult InsertTC(TarjetaCredito tarjetaCredito)
        {
            NameValueCollection obj = ReverseMap(tarjetaCredito);

            string result = WebHelper.Post("/tarjetacredito", obj);

            TransactionResult result2 = MapResultado(result);

            return result2;
        }

        public NameValueCollection ReverseMap(TarjetaCredito tarjetaCredito)
        {
            NameValueCollection collection = new NameValueCollection();
            collection.Add("Usuario", ConfigurationManager.AppSettings["Legajo"].ToString());
            collection.Add("idCliente", tarjetaCredito.IdCliente.ToString());
            collection.Add("Tipo", tarjetaCredito.Tipo.ToString());
            collection.Add("PeriodoVencimiento", tarjetaCredito.PeriodoVencimiento.ToString());
            collection.Add("LimiteCompra", tarjetaCredito.LimiteCompra.ToString());
            collection.Add("NroPlastico", tarjetaCredito.NroPlastico.ToString());

            return collection;
        }

    }
}
