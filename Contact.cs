using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02OOP
{
    internal class Contact
    {
        User[] Users;
        int Count;

        public Contact()
        {
            Users = new User[1000];
            Count = 0;
        }

        public void AddUser(int id, string firstname, string lastname, char gender, string city, string addeddate, Address[] arr1, Email[] arr2, Phone[] arr3)
        {
            Users[Count] = new User();

            Users[Count].ID = id;
            Users[Count].FirstName = firstname;
            Users[Count].LastName = lastname;
            Users[Count].Gender = gender;
            Users[Count].City = city;
            Users[Count].AddedDate = DateOnly.Parse(addeddate);

            for(int i = 0; i < arr1.Length; ++i)
            {
                Users[Count].AddAddress(arr1[i]);
            }

            for (int i = 0; i < arr2.Length; ++i)
            {
                Users[Count].AddEmail(arr2[i]);
            }

            for (int i = 0; i < arr3.Length; ++i)
            {
                Users[Count].AddPhoneNumber(arr3[i]);
            }

            Count++;    // Increase Number Of Users At The Contact By 1
        }

        public void EditUser(int id, int choice, int indx, string? updated1, string? updated2, string? updated3)
        {
            for(int i = 0; i < Count; ++i)
            {
                if (Users[i].ID == id)
                {
                    switch(choice)
                    {
                        case 1:
                            Users[i].ID = int.Parse(updated1);
                            break;

                        case 2:
                            Users[i].FirstName = updated1;
                            break;

                        case 3:
                            Users[i].LastName = updated1;
                            break;

                        case 4:
                            Users[i].Gender = char.Parse(updated1);
                            break;

                        case 5:
                            Users[i].City = updated1;
                            break;

                        case 6:
                            Users[i].AddedDate = DateOnly.Parse(updated1);
                            break;

                        case 7:
                            for(int j = 0; j < Users[i].Addresses.Length; ++j)
                            {
                                if (Users[i].Addresses[j] == Users[i].Addresses[indx - 1])
                                {
                                    Users[i].EditAddress(indx, updated1, updated2, updated3);
                                }
                            }
                            break;

                        case 8:
                            for (int j = 0; j < Users[i].Emails.Length; ++j)
                            {
                                if (Users[i].Emails[j] == Users[i].Emails[indx - 1])
                                {
                                    Users[i].EditEmail(indx, updated1, updated2, updated3);
                                }
                            }
                            break;

                        case 9:
                            for (int j = 0; j < Users[i].Phones.Length; ++j)
                            {
                                if (Users[i].Phones[j] == Users[i].Phones[indx - 1])
                                {
                                    long Temp = long.Parse(updated1);

                                    Users[i].EditPhoneNumber(indx, Temp, updated2, updated3);
                                }
                            }
                            break;
                    }

                    return;
                }
            }

            Console.WriteLine($"No User Here With ID {id}");
        }

        public int CountUsers()
        {
            return Count;
        }

        public void SearchUser(int choice, string value)
        {
            switch(choice)
            {
                case 1:
                    int val = int.Parse(value);

                    for(int i = 0; i < Count; ++i)
                    {
                        if (Users[i].ID == val)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 2:

                    for(int i = 0; i < Count; ++i)
                    {
                        if (Users[i].FirstName == value)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 3:

                    for (int i = 0; i < Count; ++i)
                    {
                        if (Users[i].LastName == value)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 4:

                    char val1 = char.Parse(value);
                    for (int i = 0; i < Count; ++i)
                    {
                        if (Users[i].Gender == val1)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 5:

                    for (int i = 0; i < Count; ++i)
                    {
                        if (Users[i].City == value)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 6:

                    DateOnly val2 = DateOnly.Parse(value);

                    for (int i = 0; i < Count; ++i)
                    {
                        if (Users[i].AddedDate == val2)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 7:

                    for (int i = 0; i < Count; ++i)
                    {
                        int Result = Users[i].SearchAddress(value);

                        if(Result == 1)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 8:

                    for (int i = 0; i < Count; ++i)
                    {
                        int Result = Users[i].SearchEmail(value);

                        if (Result == 1)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;

                case 9:

                    for (int i = 0; i < Count; ++i)
                    {
                        long val3 = long.Parse(value);

                        int Result = Users[i].SearchPhoneNumber(val3);

                        if (Result == 1)
                        {
                            Users[i].Show();
                            break;
                        }
                    }

                    break;
            }
        }

        public void DeleteUser(int id)
        {
            int indx = -1;

            for(int i = 0; i < Count; ++i)
            {
                if (Users[i].ID == id)
                {
                    indx = i;
                    break;
                }
            }

            if(indx != -1)
            {
                for(int i = indx; i < Count - 1; ++i)
                {
                    Users[i] = (User) Users[i + 1].Clone();
                }

                Count--;

                Console.WriteLine("Delete Operation Is Done");
            }
            else
            {
                Console.WriteLine($"No User At The Contact With The ID : {id}");
            }
        }

        public void ShowAllUsersData()
        {
            Console.WriteLine("All Users Data At The Contact");

            int Counter = 0;

            for(int i = 0; i < Count; ++i)
            {
                Console.WriteLine($"User {Counter + 1}");
                Users[i].Show();
            }
        }

        public int MakeValidationWithId(int id)
        {
            for(int i = 0; i < Count; ++i)
            {
                if (Users[i].ID == id)
                {
                    return 1;
                }
            }

            return -1;
        }
    }
}
