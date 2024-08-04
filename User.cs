using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project02OOP
{
    internal class User : ICloneable
    {
        // Atomatic Properties For Some Members
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Full Property For Gender To Make A Validation
        private char gender;
        public char Gender
        {
            get
            {
                return gender;
            }

            set
            {
                if(gender == 'F' || gender == 'M')
                {
                    this.gender = value;
                }
                else
                {
                    this.gender = 'M';
                }
            }
        }
        public string City { get; set; }
        public DateOnly AddedDate { get; set; }

        // Arrays 
        public Address[] Addresses;
        public Email[] Emails;
        public Phone[] Phones;
        int CountAddresses;
        int CountEmails;
        int CountPhoneNumbers;

        // Constructor
        public User()
        {
            Addresses = new Address[4];
            Emails = new Email[4];
            Phones = new Phone[4];

            CountAddresses = 0;
            CountEmails = 0;
            CountPhoneNumbers = 0;
        }

        public int SearchAddress(string S)
        {
            for(int i = 0; i < CountAddresses; ++i)
            {
                if (Addresses[i].GetAddress() == S)
                {
                    return 1;
                }
            }

            return -1;
        }

        public int SearchEmail(string S)
        {
            for (int i = 0; i < CountEmails; ++i)
            {
                if (Emails[i].GetEmail() == S)
                {
                    return 1;
                }
            }

            return -1;
        }

        public int SearchPhoneNumber(long L)
        {
            for (int i = 0; i < CountPhoneNumbers; ++i)
            {
                if (Phones[i].GetPhoneNumber() == L)
                {
                    return 1;
                }
            }

            return -1;
        }

        public void AddAddress(Address address)
        {
            Addresses[CountAddresses] = (Address) address.Clone();
            CountAddresses++;
        }

        public void AddEmail(Email email)
        {
            Emails[CountEmails] = (Email) email.Clone();
            CountEmails++;
        }

        public void AddPhoneNumber(Phone phonenumber)
        {
            Phones[CountPhoneNumbers] = (Phone)phonenumber.Clone();
            CountPhoneNumbers++;
        }

        public void EditAddress(int indx, string place, string type, string discription)
        {
            for(int i = 0; i < CountAddresses; ++i)
            {
                if(i == indx - 1)
                {
                    Addresses[i].SetPlace(place);
                    Addresses[i].SetType(type);
                    Addresses[i].SetDiscription(discription);
                    return;
                }
            }

            Console.WriteLine($"No Place Here With This Value {place}");
        }

        public void EditEmail(int indx, string email, string type, string discription)
        {
            for (int i = 0; i < CountEmails; ++i)
            {
                if (i == indx - 1)
                {
                    Emails[i].SetEmail(email);
                    Emails[i].SetType(type);
                    Emails[i].SetDiscription(discription);
                    return;
                }
            }

            Console.WriteLine($"No Email Here With This Value {email}");
        }

        public void EditPhoneNumber(int indx, long phonenumber, string type, string discription)
        {
            for (int i = 0; i < CountPhoneNumbers; ++i)
            {
                if (i == indx - 1)
                {
                    Phones[i].SetPhone(phonenumber);
                    Phones[i].SetType(type);
                    Phones[i].SetDiscription(discription);
                    return;
                }
            }

            Console.WriteLine($"No Phone Number Here With This Value {phonenumber}");
        }

        public void Show()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"The ID Of User : {ID}");
            Console.WriteLine($"The First Name Of User : {FirstName}");
            Console.WriteLine($"The Last Name Of User : {LastName}");
            Console.WriteLine($"The Gender Of User : {Gender}");
            Console.WriteLine($"The City Of User : {City}");
            Console.WriteLine($"The Added Date Of User : {AddedDate}");
            
            if(CountAddresses == 0)
            {
                Console.WriteLine("This User Don't Have Any Address");
            }
            else
            {
                for (int i = 0; i < CountAddresses; ++i)
                {
                    Console.WriteLine($"The Email {i + 1} Of User : {Addresses[i].GetAddress()}");
                }
            }

            if (CountEmails == 0)
            {
                Console.WriteLine("This User Don't Have Any Email");
            }
            else
            {
                for (int i = 0; i < CountEmails; ++i)
                {
                    Console.WriteLine($"The Email {i + 1} Of User : {Emails[i].GetEmail()}");
                }
            }

            if (CountPhoneNumbers == 0)
            {
                Console.WriteLine("This User Don't Have Any Phone Number");
            }
            else
            {
                for (int i = 0; i < CountPhoneNumbers; ++i)
                {
                    Console.WriteLine($"The Phone Number {i + 1} Of User : {Phones[i].GetPhoneNumber()}");
                }
            }
        }

        public object Clone()
        {
            User U = new User();

            U.ID = this.ID;
            U.FirstName = new string(this.FirstName);
            U.LastName = new string(this.LastName);
            U.Gender = this.Gender;
            U.City = new string(this.City);
            U.AddedDate = this.AddedDate;
            U.Addresses = (Address[]) this.Addresses.Clone();
            U.Emails = (Email[]) this.Addresses.Clone();
            U.Phones = (Phone[]) this.Addresses.Clone();

            return U;
        }
    }
}
