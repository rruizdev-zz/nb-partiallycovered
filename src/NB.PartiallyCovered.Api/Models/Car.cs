using Newtonsoft.Json;
using System;

namespace NB.PartiallyCovered.Api.Models
{
    [Serializable]
    public record Car
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; init; }

        [JsonProperty(PropertyName = "car")]
        public string Name { get; init; }

        [JsonProperty(PropertyName = "car_model")]
        public string Model { get; init; }

        [JsonProperty(PropertyName = "car_color")]
        public string Color { get; init; }

        [JsonProperty(PropertyName = "car_model_year")]
        public int Year { get; init; }

        [JsonProperty(PropertyName = "car_vin")]
        public string Patent { get; init; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; init; }

        [JsonProperty(PropertyName = "availability")]
        public bool Availability { get; init; }
    }
}
