using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.RemoveSpecialCharactersFromString("BVK!@#$%^&*()"));
            Console.ReadKey();
            Console.WriteLine("---------------------");

            #region Constructor


            Console.WriteLine("Constructor Demo");
            Console.WriteLine("1. Constructor of a class must have the same name as the class name in which it resides.");
            Console.WriteLine("2. A constructor can not be abstract, final, and Synchronized.");
            Console.WriteLine("3. Within a class, you can create only one static constructor.");
            Console.WriteLine("4. A constructor doesn’t have any return type, not even void.");
            Console.WriteLine("5. A static constructor cannot be a parameterized constructor.");
            Console.WriteLine("6. A class can have any number of constructors.");
            Console.WriteLine("7. ccess modifiers can be used in constructor declaration to control its access i.e which other class can call the constructor.");
            Console.WriteLine(@"Types of Constructor 
                                1. Default Constructor 
                                2. Parameterized Constructor 
                                3. Copy Constructor 
                                4. Private Constructor 
                                5. Static Constructor ");
            Console.WriteLine();


            ConstructorsDemoClass cd = new ConstructorsDemoClass();
            Console.WriteLine("---------------------");

            ConstructorsDemoClass cdc = new ConstructorsDemoClass("Parameterized Constructor");
            Console.WriteLine("---------------------");


            // Create a new ConstructorsDemoClass object.
            ConstructorsDemoClass g1 = new ConstructorsDemoClass("January", 2023);

            // here is g1 details is copied to g2.
            ConstructorsDemoClass g2 = new ConstructorsDemoClass(g1);

            Console.WriteLine("Copy Constructor with value equals to : " + g2.Details);

            Console.ReadKey();
            #endregion Constructor

            Console.WriteLine("---------------------");

            #region Inheritance
            BaseClass baseClass = new BaseClass();
            baseClass.GetBaseClassDetails();
            Console.WriteLine("---------------------");

            SingelInheritanceClas singelInheritanceClas = new SingelInheritanceClas();
            singelInheritanceClas.GetBaseClassDetails();
            singelInheritanceClas.GetDerivedClassDetails();
            Console.WriteLine("---------------------");

            MultiLevelInheritance multiLevel = new MultiLevelInheritance();
            multiLevel.GetBaseClassDetails();
            multiLevel.GetDerivedClassDetails();
            multiLevel.GetMultiLevelClassDetails();
            Console.WriteLine("---------------------");

            HirarchialInheritance hirarchial = new HirarchialInheritance();
            hirarchial.GetBaseClassDetails();
            hirarchial.GetHirarchialClassDetails();
            Console.WriteLine("---------------------");


            MultipleInheritanceByInterface multipleInheritanceByInterface = new MultipleInheritanceByInterface();
            multipleInheritanceByInterface.GetDate();
            multipleInheritanceByInterface.InterfaceI1Method();
            multipleInheritanceByInterface.InterfaceI2Method();
            Console.WriteLine("---------------------");
            #endregion Inheritance
            Console.ReadKey();
        }
    }
}
