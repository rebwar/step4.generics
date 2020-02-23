using System;
namespace step4.generics
{
    class Printer<T> where T:Document
    {
      public void Print(T document)
        {
            Console.WriteLine(document.GetString());
        }
    }
}
