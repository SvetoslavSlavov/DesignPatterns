using System;

namespace Decorator
{
    abstract class SauceDecorator : IPizza
    {
        protected IPizza pizza;
        public SauceDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public virtual double GetCost()
        {
            return this.pizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return this.pizza.GetDescription();
        }
    }
}

