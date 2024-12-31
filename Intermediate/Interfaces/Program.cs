namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        IAttackable attackable = new Player();
        AttackObject(new Player());
        AttackObject(new Enemy());
        Console.ReadKey();
    }
    private static void AttackObject(IAttackable attackable){
        attackable.Damage();
    }
    public class Player : IAttackable{  // if we implement an interface then we have to implement everything within that interface
        public void Damage(){
            Console.WriteLine("Player Damage");
        }
    }
    public class Enemy : IAttackable{
        // public void Damage(){
        //     Console.WriteLine("Enemy Damage");
        // }
    }
    public interface IAttackable{
        public void Damage(){
            Console.WriteLine("Damage");  // this will be default
        }
    }
}
