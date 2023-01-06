using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InheritanceDemoClass
    {
        public void GetData()
        {
            Console.WriteLine(@"
1.Super Class:-  The class whose features are inherited is known as super class or a base class or a parent class 
2.Sub Class:-  The class that inherits the other class is known as subclass or a derived class, 
        extended class, or child class.The subclass can add its own fields and methods in addition to the superclass fields and methods 
3. Reusability:-  Inheritance supports the concept of reusability, 
        when we want to create a new class and there is already a class that includes some of the code that we want, 
        we can derive our new class from the existing class. By doing this, we are reusing the fields and methods of the existing class");
        }



    }

    public class BaseClass
    {
        public void GetBaseClassDetails()
        {
            Console.WriteLine("Base Class");
        }
    }

    //A:B single 
    public class SingelInheritanceClas : BaseClass
    {
        public void GetDerivedClassDetails()
        {
            Console.WriteLine("Singel Inheritance");
        }
    }

    //B:A  C:A  D:A  is hierarchial inheritance
    public class HirarchialInheritance : BaseClass 
    {
        public void GetHirarchialClassDetails()
        {
            Console.WriteLine("Hirarchial Inheritance");
        }
    }

    //Multiple Inheritance is not possible with class
    //public class MultipleInheritance : BaseClass, SingelInheritanceClas
    //{

    //}

    //A:B   B:C   C:D    is multileven
    public class MultiLevelInheritance : SingelInheritanceClas
    {
        public void GetMultiLevelClassDetails()
        {
            Console.WriteLine(" Multi Level inheritance");
        }
    }



    //MultipleInheritance using interface
    //Declare methods in interface and implement the methods of interface in class by using inheritance and do multiple inheritance by interface

    public interface I1
    {
        void InterfaceI1Method();
    }

    public class C1 : I1
    {
        public void InterfaceI1Method()
        {
            Console.WriteLine("Implemented Interface I1 method");
        }
    }

    public interface I2
    {
        void InterfaceI2Method();
    }
    public class C2 : I2
    {
        public void InterfaceI2Method()
        {
            Console.WriteLine("Implemented Interface I2 method");
        }
    }

    public class MultipleInheritanceByInterface: I1, I2
    {
        public void GetDate()
        {

            C1 obj1 = new C1();
            obj1.InterfaceI1Method();

            C2 obj2 = new C2();
            obj2.InterfaceI2Method();
            Console.WriteLine("Implemented both Interface methods at a time i.e. I1, I2");
        }
        public void InterfaceI1Method()
        {
            Console.WriteLine("Implemented Interface I1 method");
        }
        public void InterfaceI2Method()
        {
            Console.WriteLine("Implemented Interface I2 method");
        }
    }
}
