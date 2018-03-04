using System;
using System.Text;

/* Prototype se izpolzva dosta 
chesto v igrite. Imame edin igrach i
toi dostiga nqkakav progres i 
iskame da zapametim dokade e dostignal.
*/
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Player1 player1 = new Player1();
            player1.Name = "John";
            player1.Level = 3;
            player1.Age = 99;


            Player1 player1ToSave = player1.Clone() as Player1;

            player1.Level = 4;

            System.Console.WriteLine(player1);
            System.Console.WriteLine(player1ToSave);

            // Kogato izpolzvame Clone metoda ima razlichni inastancii.
            
        }
    }
}

