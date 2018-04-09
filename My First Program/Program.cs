using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Yazan", Name;
            Name = (MyName.Equals("Yazan")) ? "Yes" : "No";
            Console.WriteLine("{0} the name is Yazan", Name);
            Console.ReadKey();
        }
    }
}
