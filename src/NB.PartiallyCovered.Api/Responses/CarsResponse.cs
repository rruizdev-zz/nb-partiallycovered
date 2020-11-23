using NB.PartiallyCovered.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NB.PartiallyCovered.Api.Responses
{
    [Serializable]
    public class CarsResponse
    {
        [JsonProperty(PropertyName = "cars")]
        public IEnumerable<Car> Cars { get; set; }
    }
}
