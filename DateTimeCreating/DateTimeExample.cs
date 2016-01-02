using System;

class DateTimeExample
{
    static void Main()
    {
        DateTime halloween = new DateTime(2016, 10, 31);
        Console.WriteLine(halloween);

        DateTime julyMorning = new DateTime(2016, 7, 1, 6, 52, 0);
        Console.WriteLine(julyMorning);

		DateTime dayAfterHalloween = halloween.AddDays(1);
		Console.WriteLine(dayAfterHalloween);
    }
}
