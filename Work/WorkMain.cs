using System;
using Work;

class WorkMain
{
    static void Main()
    {
        const int newYear=2016;
        Student studNew = new Student();
        studNew.FirstName = "Pesho";
        studNew.LastName = "Ivanov";

        //Car myCar=new Car();

        Console.WriteLine(studNew.FirstName+" "+ studNew.LastName  );

        Car myCar=new Car();
        myCar.marka = "Mercedes";
        myCar.model = "G 63 AMG";
        myCar.power = 544;

        Console.WriteLine(myCar.marka+" " + myCar.model + " "+ myCar.power+"Hp");

        Car lastCar=new Car();

        lastCar.marka = "BMW";
        lastCar.model = "X6";
        lastCar.power = 500;

        Console.WriteLine(lastCar.marka+" "+ lastCar.model+" "+lastCar.power);

        DateTime now=DateTime.Today;
        Console.WriteLine(now.Hour);

        int year = int.Parse(Console.ReadLine());
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

class Student
{
    public string FirstName;
    public string LastName;
    public int Age;
}

