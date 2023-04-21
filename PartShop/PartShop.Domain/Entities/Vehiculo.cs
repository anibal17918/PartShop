using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PartShop.Domain.Entities
{
    public class Vehiculo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("imageURL")]
        public string ImageURL { get; set; }

        [JsonPropertyName("model")]
        public string Modelc { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("anio")]
        public int Anio { get; set; }

        [JsonPropertyName("precio")]
        public decimal Precio { get; set; }

        [JsonPropertyName("stock")]
        public int Stock { get; set; }

        [JsonPropertyName("enReparacion")]
        public bool InRepair { get; set; }

        [JsonPropertyName("status")]
        public string Estatus { get; set; }

        [JsonPropertyName("estadoReparacion")]
        public string RepairStatus { get; set; }

        [JsonPropertyName("comentarioReparacion")]
        public string RepairComment { get; set; }

        [JsonPropertyName("fechaReparacion")]
        public DateTime? FechaReparacion { get; set; }

        // Método para agregar un comentario a un vehículo
        public static async Task AgregarComentario(int idVehiculo, string comentario)
        {
            string url = $"https://publicapigrupo3.azurewebsites.net/api/Car/{idVehiculo}";
            HttpClient client = new HttpClient();
            var data = new Dictionary<string, string>
            {
                { "comment", comentario }
            };
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                // El comentario se agregó correctamente
            }
            else
            {
                throw new Exception("Error al agregar comentario al vehículo. Código de estado HTTP: " + response.StatusCode);
            }
        }

        public static async Task<List<Vehiculo>> ObtenerTodosLosVehiculos()
        {
            string url = "https://publicapigrupo3.azurewebsites.net/api/Car";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Vehiculo>>(json);
            }
            else
            {
                throw new Exception("Error al obtener los vehículos de la API. Código de estado HTTP: " + response.StatusCode);
            }
        }
    }
}




