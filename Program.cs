using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Address Book  \n");

            ContactDetailsRepo contactDetailsRepo = new ContactDetailsRepo();

            Boolean flag = true;


            while (flag)
            {
                Console.WriteLine("Enter 1 for Add person Details : ");
                Console.WriteLine("Enter 2 for displaying person details : ");
                Console.WriteLine("Enter 3 for Editing person details : ");
                Console.WriteLine("Enter 4 for Delete person details : ");
                Console.WriteLine("Enter 5 for Exit : ");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Please Add All the Details :");
                        Console.Write("Enter the First Name : ");
                        string first_Name = Console.ReadLine();


                        Console.Write("Enter the Last Name : ");
                        string last_Name = Console.ReadLine();
                        Console.Write("Enter the Mobile Number : ");
                        string mobile_Number = Console.ReadLine();
                        Console.Write("Enter the Email Id : ");
                        string email_Id = Console.ReadLine();
                        Console.Write("Enter the Address : ");
                        string address = Console.ReadLine();
                        Console.Write("Enter the City : ");
                        string city = Console.ReadLine();
                        Console.Write("Enter the State : ");
                        string state = Console.ReadLine();
                        Console.Write("Enter the Zip : ");
                        string zip = Console.ReadLine();
                        person person1 = new person()
                        {
                            FirstName = first_Name,
                            LastName = last_Name,
                            MobileNumber = int.Parse(mobile_Number),
                            Email = email_Id,
                            Address = address,
                            City = city,
                            State = state,
                            zip = int.Parse(zip),
                        };
                        contactDetailsRepo.AddPersonDetails(person1);

                        break;
                    case 2:
                        contactDetailsRepo.DisplayContact();
                        break;
                    case 3:
                        Console.WriteLine(" Please Enter person  Details which you want to edit : ");
                        Console.Write("Enter tha First name : ");
                        string first_Name1 = Console.ReadLine();
                        Console.Write("Enter tha Last name : ");
                        string last_Name1 = Console.ReadLine();
                        Console.Write("Enter tha Mobile Number : ");
                        string mobile_Number1 = Console.ReadLine();
                        Console.Write("Enter tha  Email Id : ");
                        string email_Id1 = Console.ReadLine();
                        Console.Write("Enter tha Address  : ");
                        string address1 = Console.ReadLine();
                        Console.Write("Enter tha City : ");
                        string city1 = Console.ReadLine();
                        Console.Write("Enter tha State name : ");
                        string state1 = Console.ReadLine();
                        Console.Write("Enter tha Zip : ");
                        string zip1 = Console.ReadLine();
                        person person2 = new person()
                        {
                            FirstName = first_Name1,
                            LastName = last_Name1,
                            MobileNumber = int.Parse(mobile_Number1),
                            Email = email_Id1,
                            Address = address1,
                            City = city1,
                            State = state1,
                            zip = int.Parse(zip1),
                        };
                        contactDetailsRepo.Edit_Person_Details(person2);
                        break;
                    case 4:
                        Console.WriteLine("Please Enter person  Details which you want to delete : ");
                        Console.Write("Enter tha First name : ");
                        string first_Name2 = Console.ReadLine();
                        contactDetailsRepo.delete_Person(first_Name2);
                        break;
                    default:
                        Console.WriteLine("Exiting the loop .");
                        flag = false;
                        break;
                }
            }
        }
    }
}