using ConsoleApp1;
using System;

public class Program
{
    static List<Person> people = new List<Person>();

    public static void Main(string[] args)
    {
        var option = 0;
        do
        {
            DisplayMenu();
            option = Int32.Parse(Console.ReadLine());
            MenuChoice(option);

            Console.WriteLine("\nHit Enter to return to menu...");
            Console.ReadLine();
            Console.Clear();
        } while (option != 0);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("------ Menu ------");
        Console.WriteLine("1. Create a new Person");
        Console.WriteLine("2. View all people");
        Console.WriteLine("3: Remove a Person");
        Console.WriteLine("4: Display a random Last Name");
        Console.WriteLine("5. Create and View Random SSN");
        Console.WriteLine("6: Display a random Phone Number");
        Console.WriteLine("0. Exit");
        Console.WriteLine("------------------");
    }

    public static void MenuChoice(int option)
    {
        Random random = new Random();
        switch (option)
        {
            case 1:
                people.Add(new Person());
                break;

            case 2:
                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
                break;

            case 3:
                if (people.Count == 0)
                {
                    Console.WriteLine("No Person(s) Exist in the list");
                }
                else
                {
                    DeletePerson(people);
                }
                break;

            case 4:
                Random rand = new Random();
                Console.WriteLine((LastName)rand.Next(Enum.GetNames(typeof(LastName)).Length));
                break;

            case 5:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.SSN);
                break;

            case 6:
                Console.WriteLine("Select your separator");
                string userPhoneInput = Console.ReadLine();
                Phone randomPhone = new Phone();
                string[] words = randomPhone.ToString().Split('-');
                Console.WriteLine($"{words[0]}{userPhoneInput}{words[1]}{userPhoneInput}{words[2]}");
                break;


            case 0:
                Console.WriteLine("See ya!");
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option. Can you read?");
                break;
        }
    }

    private static void DeletePerson(List<Person> arrayList)
    {
        Console.WriteLine("Who would you like to delete");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {arrayList[i].FirstName} {arrayList[i].LastName}");
        }

        Console.WriteLine("Delete Number: ");
        var userInput = Int32.Parse(Console.ReadLine());
        arrayList.RemoveAt(userInput - 1);
    }
}

