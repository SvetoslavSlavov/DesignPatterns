using System;

namespace Builder
{
    /*
    Direktora znae kakvo trqbva da se sluchi
    pri sazdavaneto na dadeno menu no konktretnite
    builderi znaqt kakvo trqbva da se sluchi na vsqka
    edna stapka.
     */
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.AddDrink();
            builder.AddDish();
            builder.AddDessert();
        }
    }
}
