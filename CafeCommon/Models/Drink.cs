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
        public Drink(DrinkType type)
        {
            Type = type;
            Name = GetName();
            ImageUrl = GetImageUrl();
        }

        [JsonProperty("size")]
        public DrinkSize Size { get; set; }

        [JsonProperty("type")]
        public DrinkType Type { get; set; }

        public string Name { get; }

        public string ImageUrl { get; }

        private string GetName()
        {
            switch (Type)
            {
                case DrinkType.Cappuccino:
                    return "Cappuccino";

                case DrinkType.FlatWhite:
                    return "Flat White";

                case DrinkType.Espresso:
                    return "Espresso";

                case DrinkType.Latte:
                    return "Latte";

                case DrinkType.BlackTea:
                    return "Black Tea";

                case DrinkType.EarlGreyTea:
                    return "Earl Grey Tea";

                case DrinkType.GreenTea:
                    return "Green Tea";

                default: return "";
            }
        }

        private string GetImageUrl()
        {
            switch (Type)
            {
                case DrinkType.Cappuccino:
                    return
                        "https://hips.hearstapps.com/hmg-prod/images/directly-above-shot-of-cappuccino-served-on-table-royalty-free-image-769817517-1564602749.jpg";

                case DrinkType.FlatWhite:
                    return "https://d3vueie8hikq61.cloudfront.net/wp-content/uploads/2018/02/latte-vs-flat-white.jpg";

                case DrinkType.Espresso:
                    return "https://d9pl0lig74xnv.cloudfront.net/catalog/product/cache/91e9c011f0ac998e686df01a906b8401/1/0/10602-10_a_1.jpg";

                case DrinkType.Latte:
                    return "https://coffeeaffection.com/wp-content/uploads/2020/01/how-to-make-a-latte-at-home.webp";

                case DrinkType.BlackTea:
                    return "https://cdn.intelligencebank.com/au/share/NOrD/1VN0z/ZX8GD/preset=pB6BA/T125AE008_chai_brewed_loose_leaf";

                case DrinkType.EarlGreyTea:
                    return "https://cdn.intelligencebank.com/au/share/NOrD/1VN0z/en7JL/preset=pB6BA/B125AE018_french_earl_grey_teabag_lifestyle";

                case DrinkType.GreenTea:
                    return "https://cdn.shopify.com/s/files/1/0253/2553/5337/products/green_tea_b2b5b32f-1f04-44d8-8f01-f960b29b1be2_600x_crop_center.jpg?v=1568194793";
                
                default:
                    return string.Empty;
            }
        }
    }
}
