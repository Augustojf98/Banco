﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Datos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net/api/v1";

            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get(string url)
        {
            var uri = rutaBase + url;

            var responseString = client.DownloadString(uri);

            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":true,\"id\":5,\"error\":null}";
            }


        }

        public static string Put(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "PUT", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":true,\"id\":5,\"error\":null}";
            }


        }

        public static string Delete(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "DELETE", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":true,\"id\":5,\"error\":null}";
            }


        }
    }
}