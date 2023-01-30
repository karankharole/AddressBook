
using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adress Book program..... ");

            AddressBookMain createContact = new AddressBookMain();
            bool end = true;
            while (true)
            {
                Console.WriteLine("Choose an option to execute the program : \n1. Add a contact\n2. Display contact\n3." +
                    " Edit a contact\n4. Delete a contact\n5. End the program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        createContact.CreateContact();
                        break;
                    case 2:
                        createContact.Display();
                        break;
                    case 3:
                        createContact.EditContact();
                        break;
                    case 4:
                        createContact.DeleteContact();
                        break;
                    case 5:
                        createContact.ViewContact();
                        break;
                    case 6:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Option ");
                        break;
                }
            }
        }
    }
}