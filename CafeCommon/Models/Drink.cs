using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeCommon.Enums;

namespace CafeCommon.Models
{
    public class Drink
    {
        public DrinkSize Size { get; set; }
        public DrinkType Type { get; set; }
    }
}
