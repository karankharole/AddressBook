
using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Program\n===================================");
            AddressBookMain addingContact = new AddressBookMain();
            bool end = true;
            while (end)
            {
                Console.WriteLine("Choose an option to execute :\n1. Create Contact\n2. Add Contact\n3. Edit Contact\n4." +
                    " Delete Contact\n5. View Contact\n6. Restricting Duplicate Contact\n7. End The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addingContact.AddContact();
                        Console.WriteLine("Contact has created");
                        break;
                    case 2:
                        addingContact.AddContact();
                        Console.WriteLine("Contact has added ");
                        addingContact.Display();
                        break;
                    case 3:
                        addingContact.EditContact();
                        break;
                    case 4:
                        addingContact.DeleteContact();
                        break;
                    case 5:
                        addingContact.ViewContact();
                        break;
                    case 6:
                        MultipleAddressBook studentAddressBook = new MultipleAddressBook();

                        studentAddressBook.AddDetails("person", "karan", "kharole", "amt", "Amravati", "Maharashtra", 444601, 9689696292, "karankharole2000@gmail.com");
                        studentAddressBook.AddDetails("person", "chetan", "rathi", "amt", "Akola", "Maharashtra", 444601, 9689696292, "karankharole2000@gmail.com");
                        studentAddressBook.AddDetails("person", "yogesh", "rathi", "amt", "Pune", "Maharashtra", 444601, 9689696292, "karankharole2000@gmail.com");
                        studentAddressBook.AddDetails("person", "Raaj", "kharole", "amt", "surat", "Gujarat", 444601, 9689696292, "karankharole2000@gmail.com");
                        studentAddressBook.AddDetails("person", "Sagar", "kharole", "amt", "Surat", "gujarat", 444601, 9689696292, "karankharole2000@gmail.com");
                        studentAddressBook.AddDetails("person", "Kamlesh", "kharole", "amt", "Surat", "gujarat", 444601, 9689696292, "karankharole2000@gmail.com");
                        Console.WriteLine("Enter Engineer Address Book Name : ");
                        string addressBook = Console.ReadLine();
                        studentAddressBook.AddressBook(addressBook);
                        studentAddressBook.ComputeDetails();
                        studentAddressBook.Search();
                        studentAddressBook.Count();
                        break;
                    case 7:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option ");
                        break;
                }
            }
        }
    }
}