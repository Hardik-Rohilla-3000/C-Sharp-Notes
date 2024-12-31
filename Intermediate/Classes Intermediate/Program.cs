// Inheritance


namespace Classes_Intermediate;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Unit unit = new Unit();
        Enemy enemy = new Enemy();
        Player player = new Player("Hardik Rohilla");
        unit.Move();
        player.Move();
        Console.WriteLine(player.ToString());
        Console.WriteLine(player);  // does the same thing
        // Player playerTwo = new Enemy();  this is not possible
        // Unit unit2 = player;  // this is possible
        Unit unitTwo = enemy;
        unitTwo.Move();
        Console.ReadKey();  
    }
    public class Unit{
        public float speed;
        // protected float speed;  with protected this is variable can only be used in this class and any other class which extends this class
        // public void Move(){
        //     Console.WriteLine("move unit");
        // }
        public virtual void Move(){
            Console.WriteLine("Move Unit");
        }
    }
    public class Enemy:Unit{
        public override void Move()
        {
            Console.WriteLine("Move Enemey");
        }
    }
    public class Player: Unit{
        private string playerName;
        public Player(string playerName){
            // Move()
            this.playerName = playerName;
            speed = 5;
        }
        public override void Move()   // with this we can override the funtion
        {
            Console.WriteLine("Move Player");
        }
        public override string ToString()
        {
            return "Player: "+playerName;
        }
    }

    // abstract classes are not required to create a instance 
}
