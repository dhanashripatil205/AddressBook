﻿namespace AddressBookProgram
{
    public class AddressBook1
    {
        public static void Main(string[] args)
        {
            AddressBook obj = new AddressBook();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\n Enter Contact Details {0}", i);
                obj.CreateUser();
            }
            obj.ShowAllPersonsInList();
            Console.WriteLine("\n Do you want to Edit Information: if yes=1, no=2");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A == 1)
            {
                obj.EditUserInformation();
                Console.WriteLine("\n Contact Edited");
                obj.ShowAllPersonsInList();
            }

        }
    }
}