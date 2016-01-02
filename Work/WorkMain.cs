using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work;


class WorkMain
{
    static void Main()
    {
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



    }
}

class Student
{
    public string FirstName;
    public string LastName;
}

