namespace PhoneBook;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your phone book");
        Console.WriteLine("What you want to do: ");
        Console.WriteLine("1 - Add Contact to your list");
        Console.WriteLine("2 - Display contact");
        Console.WriteLine("3 - Display full contact list");
        Console.WriteLine("4 - Search contact");
        Console.WriteLine("x - exit program");

        var phoneBook = new ContactList();
        var userInput = Console.ReadLine();
        while(true)
        {
            if(userInput == "1")
            {
                Console.WriteLine("Insert name");
                var name = Console.ReadLine();
                Console.WriteLine("Insert number");
                var number = Console.ReadLine();

                var newContact = new Contact(name, number);
                phoneBook.AddContact(newContact);

            }
            else if(userInput == "2")
            {
                Console.WriteLine("Insert number");
                var number = Console.ReadLine();

                phoneBook.DisplayContact(number);
            }
            else if(userInput == "3")
            {
                phoneBook.DisplayList();
            }
            else if(userInput == "4")
            {
                Console.WriteLine("Insert name");
                var name = Console.ReadLine();

                phoneBook.SearchContact(name);
            }
            else if(userInput == "x")
            {
                return;
            }
            else
            {
                Console.WriteLine("Wrong input, please try again");
            }
            Console.WriteLine("What you want to do next?");
            userInput = Console.ReadLine();
        }
    }
}