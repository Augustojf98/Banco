using Newtonsoft.Json;
using Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Configuration;


namespace Banco.Datos
{
    public class CuentaMapper
    {
        public List<Cuenta> TraerTodos()
        {
            string json2 = WebHelper.Get("/cuenta"); // trae un texto en formato json de una web
            List<Cuenta> resultado = MapList(json2);
            return resultado;
        }

        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, string.Empty);

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        public TransactionResult Put(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "Update");

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        public TransactionResult Delete(Cuenta cuenta)
        {
            NameValueCollection obj = new NameValueCollection();

            obj.Add("id", cuenta.Id.ToString());

            string result = WebHelper.Delete("/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        private List<Cuenta> MapList(string json)
        {
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta, string tipo)
        {
            NameValueCollection n = new NameValueCollection();
            if (tipo == "Update")
            {
                n.Add("id", cuenta.Id.ToString());
                n.Add("Saldo", cuenta.Saldo.ToString());
            }
            else
            {
                n.Add("Id", cuenta.Id.ToString());
                n.Add("IdCliente", cuenta.IdCliente.ToString());
                n.Add("NroCuenta", cuenta.NroCuenta.ToString());
                n.Add("Descripcion", cuenta.Descripcion);
                n.Add("FechaApertura", cuenta.FechaApertura.ToShortDateString()); // DateTime
                n.Add("FechaModificacion", cuenta.FechaModificacion.ToShortDateString()); // DateTime
                n.Add("Activo", cuenta.Activo.ToString()); // bool
            }
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
