using Newtonsoft.Json;
using System;

namespace NB.PartiallyCovered.Api.Models
{
    [Serializable]
    public class Car
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "car")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "car_model")]
        public string Model { get; set; }

        [JsonProperty(PropertyName = "car_color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "car_model_year")]
        public int Year { get; set; }

        [JsonProperty(PropertyName = "car_vin")]
        public string Patent { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "availability")]
        public bool Availability { get; set; }
    }
}
