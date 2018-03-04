using System;

namespace Builder
{
    public class HappyMenuBuilder : IBuilder
    {
        private Menu menu = new Menu();
        public void AddDish()
        {
            this.menu.Dish = "Chicken Dish";
        }

        public void AddDessert()
        {
            this.menu.Desert = "Choco Cake";
        }

        public void AddDrink()
        {
            this.menu.Drink = "Coca Cola";
        }

        public Menu GetMenu()
        {
            return this.menu;
        }
    }
}