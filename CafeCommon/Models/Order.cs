using CafeCommon.Enums;
using Newtonsoft.Json;

namespace CafeCommon.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("name")] 
        public string Name { get; set; } = string.Empty;

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }
        
        [JsonProperty("partitionKey")]
        public string PartitionKey => CreatedDate.ToString("yyyyMMdd");

        [JsonProperty("drinks")]
        public List<Drink> Drinks { get; set; } = new List<Drink>();

        [JsonProperty("state")]
        public OrderState State { get; set; }
    }
}