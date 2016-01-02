using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class WorkMain
    {
        static void Main()
        {
            DateTime now=DateTime.Now;
            DateTime nnnDateTime= now.AddHours(12);
            
            Console.WriteLine(now.AddHours(12));
            Console.WriteLine(nnnDateTime.Hour  );
        }
    }
}
