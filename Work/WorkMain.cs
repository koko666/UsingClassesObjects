using System;
using System.Collections.Generic;

namespace Work
{
    public enum MakeCars
    {
        MERCEDES,
        BMW,
        AUDI,
        SUBARU,
        PORSCHE,
        TOYOTA,
        HONDA,
        BENTLEY
    }

    class WorkMain
    {
        static void Main()
        {
            MakeCars bmwCars = MakeCars.BMW;
            MakeCars audiCars = MakeCars.AUDI;
            MakeCars bentleyCars = MakeCars.BENTLEY;
            MakeCars toyotaCars = MakeCars.TOYOTA;

            Console.WriteLine(bentleyCars);
            Console.WriteLine(bmwCars);
            Console.WriteLine(audiCars);

            Random rnd = new Random();
            int[] nums = new int[rnd.Next(1, 100)];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next();
            }

            Console.Write(string.Join(",", nums));
            Console.WriteLine();
            Console.WriteLine();

            List<int> numList = new List<int>(nums);
            numList.Sort();
            Console.WriteLine(string.Join(";", numList));


            string txt = "       luck  ";
            DateTime now = DateTime.Now;
            Console.WriteLine(txt.Trim().ToUpper());

            now.AddYears(5);
            Car myCar = new Car();
            myCar.make = "Mercedes";
            myCar.model = "G 63 AMG";
            myCar.power = 544;
            Console.WriteLine(myCar.make + " " + myCar.model + " " + myCar.power + "Hp");

            Car lastCar = new Car();
            lastCar.make = "BMW";
            lastCar.model = "X6 M";
            lastCar.power = 567;
            Console.WriteLine(lastCar.make + " " + lastCar.model + " " + lastCar.power + "Hp");

            int year = 2016; // int.Parse(Console.ReadLine());
            bool Leap = DateTime.IsLeapYear(year);

            if (Leap)
            {
                Console.WriteLine("The year {0} is leap", year);
            }
            else
            {
                Console.WriteLine("The year {0} is not leap", year);
            }
        }
    }
}