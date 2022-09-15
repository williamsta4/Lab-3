namespace ConsoleApp1;
public class SSN
{
    // property
    public string Number { get; init; }


    // constructor
    public SSN()
    {
        Number = GenerateInvalidSSN();
    }

    public string GenerateInvalidSSN()
    {
        // create a variable to store the value we will return
        string invalidSSN = String.Empty;
        Random random = new Random();

        // generate a random number from 900-999 and convert it to a string
        var nineHundredSeries = random.Next(900, 1000).ToString();
        var firstThreeArray = new string[] { "000", "666", nineHundredSeries };

        var firstThree = firstThreeArray[random.Next(3)];
        var secondTwo = "00";
        var lastFour = "0000";

        invalidSSN = string.Concat(firstThree, secondTwo, lastFour);
        return invalidSSN;
    }

    public override string ToString()
    {
        string socialSecurityNumber = Number;
        socialSecurityNumber = socialSecurityNumber.Insert(3, "-");
        socialSecurityNumber = socialSecurityNumber.Insert(6, "-");
        return socialSecurityNumber;
    }
}