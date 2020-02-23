using System;

namespace step4.generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyGeneric<int> myGeneric = new MyGeneric<int>(100);
            //MyGeneric<string> myGeneric1 = new MyGeneric<string>("Hello");
            //myGeneric1.GenericProperty = "Generic";
            //myGeneric1.genericMethod(myGeneric1.GenericProperty);
            //myGeneric.GenericProperty = 40;
            //myGeneric.genericMethod(20);
            NewsPaper newsPaper = new NewsPaper();
            newsPaper.Name = "NewYorker";
            newsPaper.RelaseDate = DateTime.Now.ToString();
            Printer<NewsPaper> printer = new Printer<NewsPaper>();
            printer.Print(newsPaper);
            //Generic Constraint Test 
            int number = 100;
            //compiler Error because of printer1 type! ;-)
            //Printer<int> printer1 = new Printer<int>();
        }
    }
}
