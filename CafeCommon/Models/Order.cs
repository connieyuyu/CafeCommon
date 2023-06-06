using CafeCommon.Enums;
using Newtonsoft.Json;

namespace CafeCommon.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("drinks")]
        public IEnumerable<Drink> Drinks { get; set; } = new List<Drink>();

        [JsonProperty("state")]
        public OrderState State { get; set; }
    }
}