namespace Project02OOP
{
    internal class Program
    {
        public static void ThrowMsg()
        {
            Console.WriteLine("Sorry : No Users Here !");
        }
        public static void Main()
        {
            Console.WriteLine("============== Contact Manager Application ==============");

            Contact C = new Contact();  
            // Create Object From Contact To Manage The Application

            while(true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please Choose Number Between 1 and 6");
                Console.WriteLine("1 - Add User To The Contact");
                Console.WriteLine("2 - Edit User Date From The Contact");
                Console.WriteLine("3 - Count Numbers Of Users At The Contact");
                Console.WriteLine("4 - Search User From The Contact");
                Console.WriteLine("5 - Delete User From The Contact");
                Console.WriteLine("6 - Show All Users At The Contact");
                Console.WriteLine("------------------------------------");

                int Choice = int.Parse(Console.ReadLine());

                if(Choice >= 1 && Choice <= 6)
                {
                    switch (Choice)
                    {
                        case 1:
                            Console.Write("Enter User ID : ");
                            int UserId1 = int.Parse(Console.ReadLine());

                            Console.Write("Enter User FirstName : ");
                            string UserFirstName = Console.ReadLine();

                            Console.Write("Enter User LastName : ");
                            string UserLastName = Console.ReadLine();

                            Console.Write("Enter User Gender 'M' or 'F' : ");
                            char UserGender = char.Parse(Console.ReadLine());

                            Console.Write("Enter User City : ");
                            string UserCity = Console.ReadLine();

                            Console.Write("Enter Current Date For Added This User : ");
                            string AddedDate = Console.ReadLine();

                            Console.WriteLine("How Much Addresses For This User Under 5 Addresses");
                            int NumsAddresse = int.Parse(Console.ReadLine());

                            Address[] Arr1 = new Address[NumsAddresse];
                            for(int i = 0; i < NumsAddresse; ++i)
                            {
                                Arr1[i] = new Address();

                                Console.WriteLine($"Enter Info For Number{i + 1} Address");

                                Console.WriteLine("Enter The Place Of This Address");
                                string Str1 = Console.ReadLine();
                                Arr1[i].SetPlace(Str1);

                                Console.WriteLine("Enter The Type Of This Address");
                                string Str2 = Console.ReadLine();
                                Arr1[i].SetType(Str2);

                                Console.WriteLine("Enter The Discription Of This Address");
                                string Str3 = Console.ReadLine();
                                Arr1[i].SetDiscription(Str3);
                            }

                            Console.WriteLine("How Much Emails For This User Under 5 Emails");
                            int NumsEmails = int.Parse(Console.ReadLine());

                            Email[] Arr2 = new Email[NumsEmails];
                            for (int i = 0; i < NumsEmails; ++i)
                            {
                                Arr2[i] = new Email();

                                Console.WriteLine($"Enter Info For Number{i + 1} Email");

                                Console.WriteLine("Enter The Email Of This Email");
                                string Str1 = Console.ReadLine();
                                Arr2[i].SetEmail(Str1);

                                Console.WriteLine("Enter The Type Of This Email");
                                string Str2 = Console.ReadLine();
                                Arr2[i].SetType(Str2);

                                Console.WriteLine("Enter The Discription Of This Email");
                                string Str3 = Console.ReadLine();
                                Arr2[i].SetDiscription(Str3);
                            }

                            Console.WriteLine("How Much Phone Numbers For This User Under 5 Phone Numbers");
                            int NumsPhones = int.Parse(Console.ReadLine());

                            Phone[] Arr3 = new Phone[NumsPhones];
                            for (int i = 0; i < NumsPhones; ++i)
                            {
                                Arr3[i] = new Phone();

                                Console.WriteLine($"Enter Info For Number{i + 1} Phone Number");

                                Console.WriteLine("Enter The Phone Number Of This Phone");
                                long Str1 = long.Parse(Console.ReadLine());
                                Arr3[i].SetPhone(Str1);

                                Console.WriteLine("Enter The Type Of This Phone Number");
                                string Str2 = Console.ReadLine();
                                Arr3[i].SetType(Str2);

                                Console.WriteLine("Enter The Discription Of This Phone Number");
                                string Str3 = Console.ReadLine();
                                Arr3[i].SetDiscription(Str3);
                            }

                            C.AddUser(UserId1, UserFirstName, UserLastName, UserGender, UserCity, AddedDate, Arr1, Arr2, Arr3);
                            
                            break;

                        case 2:

                            if(C.CountUsers() == 0)
                            {
                                ThrowMsg();
                                break;
                            }

                            Console.WriteLine("Enter User ID");
                            int UserId2 = int.Parse(Console.ReadLine());

                            int Temp = C.MakeValidationWithId(UserId2);

                            if(Temp == -1)
                            {
                                Console.WriteLine($"No User Here With ID {UserId2}");
                                break;
                            }

                            Console.WriteLine("Enter Your Choice");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("1 - Edit User ID");
                            Console.WriteLine("2 - Edit User First Name");
                            Console.WriteLine("3 - Edit User Last Name");
                            Console.WriteLine("4 - Edit User Gender");
                            Console.WriteLine("5 - Edit User City");
                            Console.WriteLine("6 - Edit User Added Date");
                            Console.WriteLine("7 - Edit User Address");
                            Console.WriteLine("8 - Edit User Email");
                            Console.WriteLine("9 - Edit User Phone Number");
                            Console.WriteLine("-----------------");
                            int ChoiceEdited = int.Parse(Console.ReadLine());

                            int indx = -1;

                            string? Updated1 = null;
                            string? Updated2 = null;
                            string? Updated3 = null;

                            if(ChoiceEdited == 7)
                            {
                                Console.WriteLine("Enter The Number Of Value Which You Need To Update It");
                                indx = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter The Updated Value Of Member One [Place]:");
                                Updated1 = Console.ReadLine();

                                Console.WriteLine("Enter The Updated Value Of Member Two [Type]:");
                                Updated2 = Console.ReadLine();

                                Console.WriteLine("Enter The Updated Value Of Member Three [Discription]:");
                                Updated3 = Console.ReadLine();

                                C.EditUser(UserId2, 7, indx, Updated1, Updated2, Updated3);
                            } 
                            else if (ChoiceEdited == 8)
                            {
                                Console.WriteLine("Enter The Number Of Value Which You Need To Update It");
                                indx = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter The Updated Value Of Member One [Email]:");
                                Updated1 = Console.ReadLine();

                                Console.WriteLine("Enter The Updated Value Of Member Two [Type]:");
                                Updated2 = Console.ReadLine();

                                Console.WriteLine("Enter The Updated Value Of Member Three [Discription]:");
                                Updated3 = Console.ReadLine();

                                C.EditUser(UserId2, 8, indx, Updated1, Updated2, Updated3);
                            }
                            else if (ChoiceEdited == 9)
                            {
                                Console.WriteLine("Enter The Number Of Value Which You Need To Update It");
                                indx = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter The Updated Value Of Member One [Phone]:");
                                Updated1 = Console.ReadLine();

                                Console.WriteLine("Enter The Updated Value Of Member Two [Type]:");
                                Updated2 = Console.ReadLine();

                                Console.WriteLine("Enter The Updated Value Of Member Three [Discription]:");
                                Updated3 = Console.ReadLine();

                                C.EditUser(UserId2, 9, indx, Updated1, Updated2, Updated3);

                            }
                            else
                            {
                                Console.WriteLine("Enter The Updated Value :");
                                Updated1 = Console.ReadLine();
                                C.EditUser(UserId2, ChoiceEdited, indx, Updated1, Updated2, Updated3);
                            }

                            break;

                        case 3:
                            Console.WriteLine($"The Number Of Users In The Contact System Is {C.CountUsers()}");
                            break;

                        case 4:

                            if (C.CountUsers() == 0)
                            {
                                ThrowMsg();
                                break;
                            }

                            Console.WriteLine("Enter Data Which You Need To Get The User Have This Data :");
                            Console.WriteLine("---------------------------");

                            while(true)
                            {
                                Console.WriteLine("Choose Number Between 1 To 9");
                                Console.WriteLine("1 - Search Using ID");
                                Console.WriteLine("2 - Search Using First Name");
                                Console.WriteLine("3 - Search Using Last Name");
                                Console.WriteLine("4 - Search Using Gender");
                                Console.WriteLine("5 - Search Using City");
                                Console.WriteLine("6 - Search Using Added Date");
                                Console.WriteLine("7 - Search Using Address");
                                Console.WriteLine("8 - Search Using Email");
                                Console.WriteLine("9 - Search Using Phone Number");

                                int Cho = int.Parse(Console.ReadLine());

                                if(Cho >= 1 && Cho <= 9)
                                {
                                    Console.WriteLine("Enter The Value Which You Need To Search");
                                    string S = Console.ReadLine();

                                    C.SearchUser(Cho, S);

                                    Console.WriteLine("Are You Need To Search Using Anothor Data ?");
                                    Console.WriteLine("Press y If Yes");
                                    Console.WriteLine("Press Any Button If No");
                                    char Cho1 = char.Parse(Console.ReadLine());

                                    if(Cho1 != 'y')
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Choice ! Try Again");
                                }
                            }

                            
                            break;

                        case 5:

                            if (C.CountUsers() == 0)
                            {
                                ThrowMsg();
                                break;
                            }

                            Console.WriteLine("Enter User ID Which You Need To Delete It :");
                            int UserId3 = int.Parse(Console.ReadLine());
                            C.DeleteUser(UserId3);

                            break;

                        case 6:

                            if (C.CountUsers() == 0)
                            {
                                ThrowMsg();
                                break;
                            }

                            C.ShowAllUsersData();
                            break;
                    }
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Are You Need To Make Another Operation ?");
                    Console.WriteLine("Press y If Yes");
                    Console.WriteLine("Press Another Any Button If No");
                    char Ch = char.Parse(Console.ReadLine());
                    if(Ch != 'y')
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Choice ! Try Again");
                }
            }
        }
    }
}
