using System;

namespace Decorator
{
    class TomatoSauceDecorator : SauceDecorator
    {
        public TomatoSauceDecorator(IPizza pizza) : base(pizza)
        {

        }
    }
}
