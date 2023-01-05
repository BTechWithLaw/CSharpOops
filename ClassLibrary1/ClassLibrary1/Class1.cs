using System;

namespace ClassLibrary1
{
    
    public class Class1
    {
        public void DisplayData()
        {
            AbstractionExampleClass obj = new AbstractionExampleClass();
            string name = obj.RemoveSpecialCharactersFromString("Bvamshi!@#$%^&*()_+<>?:[]");
        }
       
        
    }
}
