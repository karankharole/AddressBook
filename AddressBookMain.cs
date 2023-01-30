using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookMain
    {
        Dictionary<string, string> Contacts;
        Dictionary<string, Dictionary<string, string>> AddressBook = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<String, Dictionary<String, Dictionary<String, String>>> AddressBookCollection = new Dictionary<string, Dictionary<String, Dictionary<String, String>>>();
        String CurrentAddressBookName = "default";
        //UC1 - Create Contact
        public void CreateContact()
        {
            Console.Write("First Name : ");
            Contacts.Add("First Name ", Console.ReadLine());

            Console.Write("Last Name : ");
            Contacts.Add("Last Name ", Console.ReadLine());

            Console.Write("Address : ");
            Contacts.Add("Address ", Console.ReadLine());

            Console.Write("City : ");
            Contacts.Add("City ", Console.ReadLine());

            Console.Write("State : ");
            Contacts.Add("State ", Console.ReadLine());

            Console.Write("Zip Code : ");
            Contacts.Add("Zip Code ", Console.ReadLine());

            Console.Write("Phone Number : ");
            Contacts.Add("Phone Number  ", Console.ReadLine());

            Console.Write("Email Address : ");
            Contacts.Add("Email Address ", Console.ReadLine());
        }

        public void AddContact()
        {
            Console.WriteLine("Add contact");
            Contacts = new Dictionary<string, string>();

            Console.Write("First Name : ");
            Contacts.Add("First Name ", Console.ReadLine());

            Console.Write("Last Name : ");
            Contacts.Add("Last Name ", Console.ReadLine());

            Console.Write("Address : ");
            Contacts.Add("Address ", Console.ReadLine());

            Console.Write("City : ");
            Contacts.Add("City ", Console.ReadLine());

            Console.Write("State : ");
            Contacts.Add("State ", Console.ReadLine());

            Console.Write("Zip Code : ");
            Contacts.Add("Zip Code ", Console.ReadLine());

            Console.Write("Phone Number : ");
            Contacts.Add("Phone Number  ", Console.ReadLine());

            Console.Write("Email Address : ");
            Contacts.Add("Email Address ", Console.ReadLine());

            Contacts.TryGetValue("First Name", out string FirstName);
            Contacts.TryGetValue("Last Name", out string LastName);
            AddressBook.Add(FirstName + " " + LastName, Contacts);
            Console.WriteLine("Contact added\n");
        }

        public void ViewContact()
        {
            Console.WriteLine("Enter full name:");
            string contactName = Console.ReadLine();
            if (AddressBook.ContainsKey(contactName))
            {
                Contacts = new Dictionary<string, string>();
                AddressBook.TryGetValue(contactName, out Contacts);
                Console.WriteLine("First Name: " + Contacts["first Name"]);

                Console.WriteLine("Last Name:" + Contacts["last Name"]);

                Console.WriteLine("Address:" + Contacts["Address"]);

                Console.WriteLine("City:" + Contacts["City"]);

                Console.WriteLine("State:" + Contacts["State"]);

                Console.WriteLine("Zip:" + Contacts["Zip"]);

                Console.WriteLine("Phone number:" + Contacts["Phone number"]);

                Console.WriteLine("Email:" + Contacts["Email"]);
            }
            else
                Console.WriteLine("Contact doesn't exist");

        }
        //UC3 - Editing Contact
        public void EditContact()
        {
            //Edit information
            Console.WriteLine("Enter full contact name");
            String contactName = Console.ReadLine();

            if (AddressBook.ContainsKey(contactName))
            {
                Console.Write("Select option you want to edit : ");
                Console.WriteLine("1. First Name 2. Last Name 3. Address\n 4. City 5. State 6. Zip\n 7. Phone number  8. Email");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter contact field:");
                String Cotanctinfo = Console.ReadLine();

                switch (option)
                {
                    case 1:
                        AddressBook[contactName]["First Name"] = Cotanctinfo;
                        break;
                    case 2:
                        AddressBook[contactName]["Last Name"] = Cotanctinfo;
                        break;
                    case 3:
                        AddressBook[contactName]["Address"] = Cotanctinfo;
                        break;
                    case 4:
                        AddressBook[contactName]["City"] = Cotanctinfo;
                        break;
                    case 5:
                        AddressBook[contactName]["State"] = Cotanctinfo;
                        break;
                    case 6:
                        AddressBook[contactName]["Zip"] = Cotanctinfo;
                        break;
                    case 7:
                        AddressBook[contactName]["Phone number"] = Cotanctinfo;
                        break;
                    case 8:
                        AddressBook[contactName]["Email"] = Cotanctinfo;
                        break;

                }
            }
            else
            {
                Console.WriteLine("contact doesn't exist");
            }
        }
        //UC4 - Delete Contact
        public void DeleteContact()
        {
            //Delete contact
            Console.WriteLine("Enter contact name:");
            String ContactName = Console.ReadLine();
            if (AddressBook.ContainsKey(ContactName))
            {
                AddressBook.Remove(ContactName);
                Console.WriteLine("contact removed");
            }
            else
                Console.WriteLine("contact doesn't exist");
        }
        //UC6 - Adding Multiple Address Book
        public void CreateAddressBook()
        {
            AddressBook = new Dictionary<string, Dictionary<string, string>>();
            Console.WriteLine("Address Book Name: ");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
                Console.WriteLine("Address Book already exist");
            else
            {
                AddressBookCollection.Add(addressBookName, AddressBook);
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book created");
            }
        }
        public void ChangeAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
            {
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book changed");
            }
            else
                Console.WriteLine("Address Book doesn't exist");
        }

        //Display Contact
        public void Display()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine(contact);
            }
        }

       
    }
}
