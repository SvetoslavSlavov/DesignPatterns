using System;

namespace Adapter
{
    /*
    Adapter -> se izpolzva v sluchaite, v koito klientskiq kod
    izpolzva edin interface i drug klas nash bi trqbvalo da
    bade adaptiran po takav nachin, che da moje i toi da 
    izpolzva sashtiq interface.
    (Adapter - kontakta klienta klienta ochakva 2 neshta da
    mu badat podadeni klasa, koito shte ima nujda ot adapter
    shte pasva na takav adapter. Klasa adapter bi trqbvalo da
    go promeni v polza na klienta.)
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* sekciq 1 */
            Tank tank = new Tank();
            tank.DriveForward();
            tank.FireWeapen();
            tank.AssignDriver("John");

            System.Console.WriteLine(new String('-', 10));
            /* sekciq 2 */
            Robot robot = new Robot();
            robot.WalkForward();
            robot.SmashWithHands();
            robot.ReactToHuman("Jack");

            System.Console.WriteLine(new String('-', 10));


            /*
            Ako klientskiq kod ochakva samo edni i sashti metodi
            nqma kak vtorata chasht ot koda da bade izvikana
            po kakavto i da e nachin. (sekciq 2)
             */
            RobotAdapter robotAdapter = new RobotAdapter(robot);
            robotAdapter.DriveForward();
            robotAdapter.FireWeapen();
            robotAdapter.AssignDriver("Jack");

        }
    }
}
