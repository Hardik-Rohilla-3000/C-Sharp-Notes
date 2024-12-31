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

        // MultiDimensional array 

        // int[,] numbersArray = new int[5,6]; // Dimensions of 2d array its length will be 5*6=30
        // // this is how we can access the 2d array
        // for(int i=0;i<numbersArray.GetLength(0);i++){
        //     for(int j=0;j<numbersArray.GetLength(1);j++){
        //         Console.WriteLine(i+", "+j+": "+numbersArray[i,j]);
        //     }
        // }

        int[,] numbersArray = new int[,] {{1,2,3},{4,5,6}};  // with this syntax we should have same number of elements in every dimension
        for(int i=0;i<numbersArray.GetLength(0);i++){
            for(int j=0;j<numbersArray.GetLength(1);j++){
                Console.WriteLine(i+", "+j+": "+numbersArray[i,j]);
            }
        }
        Console.ReadKey();



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
