using System;

namespace AddressBook_Using_Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using ADO.NET");

            AddressBookRepo objrepo = new AddressBookRepo();
            //abrepo.CheckConnection();
            AddressBookModel objmodel = new AddressBookModel();
            AddressBookModel objUpdatemodel = new AddressBookModel();
            AddressBookModel objdelmodel = new AddressBookModel();
            while (true)
            {
                Console.WriteLine("\nEnter Choice  \n1.AddContact \n2.EditContact \n3.DeleteContact \n4.RetriveStateorCity" +
                                  "\n5.SizeofBook\n6.SortPersonNameByCity\n7.identifyEachAddressbook\n8.CountByBookType\n9.Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            //AddressBookModel abmodel = new AddressBookModel();
                            objmodel.First_Name = "Neha";
                            objmodel.Last_Name = "Jagtap";
                            objmodel.Address = "Shahunagar";
                            objmodel.City = "Satara";
                            objmodel.State = "Maharashtra";
                            objmodel.Zip = "415001";
                            objmodel.Phone_Number = "7498753245";
                            objmodel.Email = "neha@gmail.com";
                            objmodel.BookName = "MyBook";
                            objmodel.AddressbookType = "family";
                            bool result = objrepo.AddContact(objmodel);

                            if (result)
                                Console.WriteLine("Record added successfully...");
                            else
                                Console.WriteLine("Some problem is there...");
                            Console.ReadKey();
                            break;
                        case 2:
                            // Update recods
                            //AddressBookModel abmodel1 = new AddressBookModel();
                            objUpdatemodel.First_Name = "Nikita";
                            objUpdatemodel.Last_Name = "Jadhav";
                            objUpdatemodel.City = "Satara";
                            objUpdatemodel.State = "Maharashtra";
                            objUpdatemodel.Email = "nikita@gmail.com";
                            objUpdatemodel.BookName = "MyBook1";
                            objUpdatemodel.AddressbookType = "Family1";
                            objrepo.EditContactUsingFirstName(objUpdatemodel);
                            Console.ReadKey();
                            break;
                        case 3:
                            objdelmodel.First_Name = "Neha";
                            objrepo.DeleteContactUsingName(objdelmodel);
                            Console.ReadKey();
                            break;
                        case 4:
                            objrepo.RetrieveContactFromPerticularCityOrState();
                            Console.ReadKey();
                            break;
                        case 5:
                            objrepo.AddressBookSizeByCityANDState();
                            Console.ReadKey();
                            break;
                        case 6:
                            objrepo.SortPersonNameByCity();
                            Console.ReadKey();
                            break;
                        case 7:
                            objrepo.identifyEachAddressbooktype();
                            Console.ReadKey();
                            break;
                        case 8:
                            objrepo.GetNumberOfContactsCountByBookType();
                            Console.ReadKey();
                            break;

                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter the valid choise :: ");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Only enter integer number :: ");
                }
            }
        }
    }
}
