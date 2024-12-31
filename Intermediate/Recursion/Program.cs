using System.Net.Http.Headers;

namespace Recursion;

class Program
{
    static void Main(string[] args)
    {
        // Mathematical way of making looping logic 
        int number = 0;
        while(number<5){
            number++;
        }
        Console.WriteLine(number);
        Console.WriteLine(RecursionIncrementer(0));
        Console.ReadKey();
    }
    private static int RecursionIncrementer(int number){
        if(number<5){
            return RecursionIncrementer(number+1);
        }
        else{
            return number;
        }
    }
    
}
