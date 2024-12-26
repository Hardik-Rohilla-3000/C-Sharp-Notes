using System.ComponentModel;

namespace Basic_C_Sharp;

class Program
{
    static void Main(string[] args)
    {
        // string interpolation

        //int age = 35;
        //string name = "code monkey";

        //Console.WriteLine("my name is " + name + " and I'm " + age + " years old");
        //Console.WriteLine($"my name is {name} and I'm {age} years old");

        //Console.WriteLine("my name is \"code monkey\"");



        //switch

        // string name = "code monkey";
        // switch (name)
        // {
        //    default:
        //        Console.WriteLine("unkown name");
        //        break;
        //    case "code monkey":
        //        Console.WriteLine("hello code monkey");
        //        break;
        //    case "iron man":
        //        Console.WriteLine("hello iron man");
        //        break;
        //    case "black widow":
        //        Console.WriteLine("hello black widow");
        //        break;
        // }



        // Arrays, lists

        // int[] numbersArray = new int[5];  // a new array of 5 elements (size of array is fixed)
        // numbersArray.Length returns the length of the array 
        // Array.IndexOf(numbersArray,123) to get the index of the element of an array 

        // List<int> numbersList = new List<int>();    size is not fixed so we can leave it blank
        // numbersList.Count  same as numbersArray.length
        // numbersList.Add()  adds the element to the end of the list 
        // numbersList.Insert()  adds at specific index 
        // numbersList.Remove() removes the element 
        // numbersList.RemoveAt()  removes at specific index
        // numbersList.Contains()   return true or false based on the availability of the element 
        // numbersList.IndexOf()   same as contains but returns the index of the element  



        // foreach loop

        // string[] nameArray = new string[]{
        //     "code monkey",
        //     "iron man",
        //     "black widow",
        //     "spider man"
        // };
        // foreach(string name in nameArray){
        //     Console.WriteLine(name);
        // }
        // Console.ReadKey();
    }
}
