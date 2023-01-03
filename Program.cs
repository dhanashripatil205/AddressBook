namespace AddressBookProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("******** Welcome to Address Book Program ********");

            AddressBook obj = new AddressBook();
            obj.CreateUser();
            obj.ShowAllPersonsInList();
        }


    }
}