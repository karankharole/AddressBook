namespace AddressBook
{
    internal class Program
    {


        public static List<ContactDetails> Person = new List<ContactDetails>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");

            adressBook.CreateContact();
        }
    }
    
}