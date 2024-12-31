namespace Delegates;

class Program
{
    private delegate void AttackDelegate();
    private delegate int MyDelegate(string str);
    private static AttackDelegate attackAction;   // we can store a funtion inside a delegate variable
    //  or we can use Action keyword
    private static Action myAction;  // Action means delegate of return type void with no parameters and we can take up to 16 parameters using Action<>
    private static Func<int> myFunc;  // this is like action but it will return int
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        attackAction = MeleeAttack;
        // attackAction += RangedAttack; we can also store multiple function like this 
        attackAction();
        Console.ReadKey();
        myAction = MeleeAttack;
        myFunc = MYTestFunction2;
        MyDelegate myDelegate = MyTestFuntion;
    }
    private static void MeleeAttack(){  // signature of function should match with delegate
        Console.WriteLine("Melee Attack");
    }
    private static void RangedAttack(){
        Console.WriteLine("Ranged Attack");
    }
    private static int MyTestFuntion(string myString){
        return 0;
    }
    private static int MYTestFunction2(){
        return 0;
    }
}
