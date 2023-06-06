using CafeCommon.Enums;

namespace CafeCommon.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public IEnumerable<Drink> Drinks { get; set; } = new List<Drink>();
        public OrderState State { get; set; }
    }
}