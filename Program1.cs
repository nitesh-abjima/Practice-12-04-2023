using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionMethod
{

    // Here EXT class contains three methods
    // Now we want to add two more new methods in it 
    // Without re-compiling this class
    class EXT
    {

        // Method 1
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        // Method 2
        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        // Method 3
        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        }

    }

}

namespace ExtensionMethod
{

    // This class contains M4 and M5 method
    // Which we want to add in Geek class.
    // NewMethodClass is a static class
    static class NewMethodClass
    {

        // Method 4
        public static void M4(this EXT g)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5
        public static void M5(this EXT g, string str)
        {
            Console.WriteLine(str);
        }
    }
}
