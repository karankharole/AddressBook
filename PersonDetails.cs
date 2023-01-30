using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class PersonDetails
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public long PhoneNumber;
        public string Email;
        public string AddressBook;

        public PersonDetails()
        {

        }
        public PersonDetails(string addressbook, string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
            AddressBook = addressbook;
        }
        public string toString()
        {
            return "Address Book : " + AddressBook + "\n" + " " + "User Details Of " + FirstName + LastName + "\nAddress : " + Address

                + "\nCity :" + City + "\nState : " + State + "\nZip : " + Zip + "\nPhoneNumber : " + PhoneNumber + "\nEmail : " + Email;
        }
    }
}
