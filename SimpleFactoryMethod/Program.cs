using System;

/*
Simple Factory Method - predostavq edin faktory klas, koito 
ima metod, koito vrashta pravilna konkretna instanciq ot daden
klas. Zavisimost ot tova kakav tip sme poiskali.
 */
/*
Factory za laptopi - shte imame edna abstrakciq za laptop i 
sashto taka shte imame klasove, koito shte badat konkretni 
vidove laptopi -> Dell, Assus i Acer. Shte sazdadem nqkolko
instancii v program.cs faila i shte prerabotim tozi kod da mine
prez simplefactory methoda.
*/ 
// Ideqta na creational patterinte e cqloto sazdavane da bade izneseno v factory method
// klientskiq kod ne se interesuva kak se sazdava instanciq na daden klas ne go interesuva dali nov del se sazdava ili 15 parametara.
// promenqiki nachina po koito se sazdava instanciq shte promenim tova samo na 1 mqsto
namespace SimpleFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop dell1 = LaptopFactory.Get(LaptopTypeEnum.Dell);

            Laptop assus1 = LaptopFactory.Get(LaptopTypeEnum.Assus);

        }
    }
}
