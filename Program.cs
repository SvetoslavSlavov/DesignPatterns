using System;

namespace DesignPatterns
{
    // Factory Method
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnoinFactory;
            var citiAcct = factory.GetSavingAcount("CITI-321");
            var nationalAcct = factory.GetSavingAcount("NATIONAL-987");

            Console.WriteLine($"My city balance is ${citiAcct.Balance}"+$" and national balance is ${nationalAcct.Balance}");
            // the logic is abstracted away from the client
        }
    }
    // Product
    public abstract class ISavingAcount
    {
        public decimal Balance { get; set; }
    }
    // Concrete Product -> Конкретен продукт
    public class CitiSavingAcct : ISavingAcount
    {
        // Contructor Balance value
        public CitiSavingAcct()
        {
            Balance = 5000;
        }
    }
    // Concrete Product -> Конкретен продукт
    public class NationalSavingAcct : ISavingAcount
    {
        public NationalSavingAcct()
        {
            Balance = 2000;
        }
    }
    // Creator
    interface ICreditUnoinFactory
    {
        // operation which takes in acount number
        ISavingAcount GetSavingAcount(string acctNo);
    }
    // Concrete Creator -> Конкренет Създател
    public class SavingsAcctFactory : ICreditUnoinFactory
    {
        // Assents of factory method -> it contains the logic of what tipe it will be send back.
        public ISavingAcount GetSavingAcount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
            {
                return new CitiSavingAcct();
            }
            else if (acctNo.Contains("NATIONAL"))
            {
                return new NationalSavingAcct();
            }
            else
            {
                throw new ArgumentException("Invalid Account Number");
            }
        }
    }
}
