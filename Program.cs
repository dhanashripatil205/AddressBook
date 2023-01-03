namespace AddressBookProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("******** Welcome to Address Book Program ********");

            AddressBook obj = new AddressBook();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\n Enter Contact Details {0}", i);
                obj.CreateUser();
            }
            obj.ShowAllPersonsInList();
        }


    }
}