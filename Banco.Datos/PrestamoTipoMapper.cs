using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Entidades;
using Newtonsoft.Json;

namespace Banco.Datos
{
    public class PrestamoTipoMapper
    {
        public List<PrestamoTipo> TraerTodos()
        {
            string json2 = WebHelper.Get("/prestamotipo"); // trae un texto en formato json de una web
            List<PrestamoTipo> resultado = MapList(json2);
            return resultado;
        }

        private List<PrestamoTipo> MapList(string json)
        {
            List<PrestamoTipo> lst = JsonConvert.DeserializeObject<List<PrestamoTipo>>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(PrestamoTipo tipoPrestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("linea", tipoPrestamo.Linea.ToString());
            n.Add("tna", tipoPrestamo.TNA.ToString());
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
