using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConstructorsDemoClass
    {
        private string month;
        private int year;

        //Default Constructor
        public ConstructorsDemoClass()
        {
            Console.WriteLine("Default Constructor");
        }
        //------------------------------------------//


        //Parameterized Constructor
        public ConstructorsDemoClass(string input)
        {
            Console.WriteLine("Parameterized Constructor");
        }
        //------------------------------------------//



        // declaring Copy constructor
        public ConstructorsDemoClass(ConstructorsDemoClass s)
        {
            month = s.month;
            year = s.year;
        }

        // Instance constructor
        public ConstructorsDemoClass(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        // Get details of ConstructorsDemoClass
        public string Details
        {
            get
            {
                return "Month: " + month.ToString() +
                         "\nYear: " + year.ToString();
            }
        }

      
        public void GetCopyConstructorDetails()
        {
            // Create a new ConstructorsDemoClass object.
            ConstructorsDemoClass g1 = new ConstructorsDemoClass("January", 2023);

            // here is g1 details is copied to g2.
            ConstructorsDemoClass g2 = new ConstructorsDemoClass(g1);

            Console.WriteLine("Copy Constructor: "+g2.Details);
        }
        //------------------------------------------//


        static ConstructorsDemoClass()
        {
            Console.WriteLine("Static Constructor");
            Console.WriteLine(@"
1. Static Constructor has to be invoked only once in the class 
2. And it has been invoked during the creation of the first reference to a static member in the class.
3. A static constructor is initialized static fields or data of the class and to be executed only once.
4. We don't have control over static constructor it will aoutomatically invoke first time and does not invoke again.
");
        }
        //------------------------------------------//

        //CONFUSE
        //private ConstructorsDemoClass(int id)
        //{
        //    Console.WriteLine("Private Constructor");
        //}


    }
}
