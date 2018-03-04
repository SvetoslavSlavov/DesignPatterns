using System;

namespace Builder 
{
    public class KinderMenuBuilder : IBuilder
    {
        private Menu menu = new Menu();
        public void AddDessert()
        {
            this.menu.Desert = "Apple";
        }

        public void AddDish()
        {
            this.menu.Dish = "Fish";
        }

        public void AddDrink()
        {
            this.menu.Drink = "Apple juice";
        }

        public Menu GetMenu()
        {
            return this.menu;
        }
    }
}
