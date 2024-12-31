using System.Diagnostics.Contracts;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        MyList<int> myList = new MyList<int>();   // Now that type T will be of type int
        myList.field = 5;
        Console.WriteLine(myList.MyFunction());
        MyList<bool> myBool = new MyList<bool>();
        myBool.field = false;
        Console.WriteLine(myBool.MyFunction());
        TestFunction("5");
        Console.ReadKey();
    }
    private class MyList<T>{  // this T can be of any type
        public T field;
        public T MyFunction(){
            return default;
        }
    }   
    // private class MyList<T> where T : class {  // with this we can constrain the type of T
    //     public T field;
    //     public T MyFunction(){
    //         return default;
    //     }
    // }   
    private static void TestFunction<T>(T p){   // we can also make a function using Generics
        Console.WriteLine(p);
    }
}
