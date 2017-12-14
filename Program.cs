using System;

namespace HelloWorldCs
{
    class Program
    {
        static void Main(string[] args)
        {
            // setting used variables
            string name = "Florent Shomora";
            string appName = "Welcome To C# Programming";
            string version = "1.1.2";
            string appYear = "2017/12/14";


            // start here 
            Console.WriteLine("{0},  {1} , Version : {2}. Released Date : {3}", name, appName, version, appYear);
            Console.ReadLine();
        }
    }
}
