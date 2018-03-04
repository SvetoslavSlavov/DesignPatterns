using System;
using System.Text;

namespace Builder
{
    public class Menu
    {
        public string Dish { get; set; }
        public string Drink { get; set; }
        public string Desert { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Drink" + this.Dish);
            sb.AppendLine("Dish" + this.Dish);
            sb.AppendLine("Dessert" + this.Desert);

            return sb.ToString();
        }
    }
}