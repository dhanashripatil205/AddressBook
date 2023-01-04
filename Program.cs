using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-5 Program to Add multiple person in a Address Book

            Console.WriteLine("Welcome to Address Book");

            int choice = 0;
            while (choice != 2)
            {
                Console.WriteLine("1.Perform Operations \n2.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice != 2)
                    AddressBook1.AddPerson();
            }
            AddressBook1.ListPeople();
            Console.WriteLine("Program Ends: Address Book: Press Enter");
            Console.ReadLine();

        }
    }
}