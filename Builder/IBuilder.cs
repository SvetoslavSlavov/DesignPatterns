using System;

namespace Builder
{
    /* 
    Opisva metodi, koito spomagat 
    za opisvaneto na slojiniq obekt menu.
    Vsqko neshto, koeto iska da bude 
    builder na klas trqbva da izpalni nqkolko
    metoda.
    */
    public interface IBuilder
    {
        void AddDish();
        void AddDrink();
        void AddDessert();
        /*
         metod za vzimane na menuto. 
        Nestho trqbva da varne buildara obratno.
        */
        Menu GetMenu();
    }
}