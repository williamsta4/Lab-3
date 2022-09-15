using Microsoft.VisualBasic;
using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1;

internal class Person
{
    private string[] arrayOfFirstNames = new string[] {
            "Will", "Jake", "Bob", "Anthony", "Jack",
            "Veronica", "Nichole", "Jane", "Allison", "Katy"};
    //private Dependent[] dependents;

    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime BirthDate { get; init; }
    public SSN SSN { get; init; }
    public Phone Phone { get; init; }

    public Person()
    {
        Random rand = new Random();
        FirstName = arrayOfFirstNames[rand.Next(arrayOfFirstNames.Length)];

        var lastArray = ConsoleApp1.LastName.GetValues(typeof(LastName));
        var value = (LastName)lastArray.GetValue(rand.Next(lastArray.Length));
        this.LastName = value.ToString();

        DateTime dateToday = DateTime.Now;

        int year = rand.Next(dateToday.Year - 81, dateToday.Year - 19);
        int month = rand.Next(1, 12);
        int day = rand.Next(1, 31);

        BirthDate = new DateTime(year, month, day);

        this.SSN = new SSN();

        this.Phone = new Phone();
    }

    public int GetAge()
    {
        var age = DateTime.Now - BirthDate;
        return age.Days / 365;
    }

    public override string ToString()
    {
        return
            $"-----------------------------------------\n" +
            $"Name:\t\t{FirstName} {LastName}\n" +
            $"Birthday:\t{BirthDate.ToShortDateString()}\n" +
            $"Age:\t\t{GetAge()}\n" +
            $"SSN:\t\t{SSN}\n" +
            $"Phone:\t\t{Phone.Number}\n" +
            $"-----------------------------------------\n";
    }
}