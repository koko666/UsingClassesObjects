using System;
using Work;

class WorkMain
{
    static void Main()
    {
        string txt = "       luck  ";
        DateTime now=DateTime.Now;
        Console.WriteLine(txt.Trim().ToUpper());


        now.AddYears(5);
        Car myCar=new Car();
        myCar.marka = "Mercedes";
        myCar.model = "G 63 AMG";
        myCar.power = 544;
        Console.WriteLine(myCar.marka+" " + myCar.model + " "+ myCar.power+"Hp");

        Car lastCar=new Car();
        lastCar.marka = "BMW";
        lastCar.model = "X6 M";
        lastCar.power = 567;
        Console.WriteLine(lastCar.marka+" "+ lastCar.model+" "+lastCar.power+"Hp");

        int year = 2016;// int.Parse(Console.ReadLine());
        bool Leap = DateTime.IsLeapYear(year);

        if (Leap)
        {
            Console.WriteLine("The year {0} is leap", year );
        }
        else
        {
            Console.WriteLine("The year {0} is not leap", year);
        }
    }
}
