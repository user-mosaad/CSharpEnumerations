namespace CSharpEnumerations;

class Program
{
    static void Main()
    {
        // Basic enums and flags usage
        var countries = Country.MW | Country.ET;
        var value = (int)countries;
        Console.WriteLine(countries);
        Console.WriteLine(value);

        var country = (Country)value;
        Console.WriteLine(country);

        // Parsing
        var parsed = Enum.Parse<Country>("ET");
        Console.WriteLine(parsed);

        Console.WriteLine();
        // Iterate over all values in an enum
        foreach (var countryy in Enum.GetValues<Country>()) // Note: used 'countryy' instead of 'country' here
        {
            Console.WriteLine($"{countryy} = {(int)countryy}");
        }

        // Enum TryParse() method
        if (Enum.TryParse<Country>("MW", out var unknown))
        {
            Console.WriteLine(unknown);
        }
        else
        {
            Console.WriteLine("'SA' is not on the list of countries.");
        }
    }
}
