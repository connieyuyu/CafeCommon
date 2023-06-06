using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeCommon.Enums;
using Newtonsoft.Json;

namespace CafeCommon.Models
{
    public class Drink
    {
        [JsonProperty("size")]
        public DrinkSize Size { get; set; }

        [JsonProperty("type")]
        public DrinkType Type { get; set; }
    }
}
