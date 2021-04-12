using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace ProyectoITXamarin
{
    public class ViewModel
    {
        public List<Venta> Ventas { get; set;}

        public ViewModel()
        {
            List<Venta> Ventas = new List<Venta>();
            TraerDatosCharts();
        }

        public async void TraerDatosCharts()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://api.jsonbin.io/b/607491075b165e19f61e15df");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accpet", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Venta>>(content);
                //Ventas. = resultaxdoñ
                this.Ventas = resultado;
            }
        }
    }

    public class Venta
    {
        public string NameEmpresa { get; }
        public int Cantidad { get; }

        public Venta(int cantidad, string nameEmpresa)
        {
            this.NameEmpresa = nameEmpresa;
            this.Cantidad = cantidad;
        }
    }

    
}
