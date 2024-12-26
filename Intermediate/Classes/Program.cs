namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        Player codeMonkeyPlayer = new Player("code monkey");
        codeMonkeyPlayer.SayHello();
        Player ironManPlayer = new Player("iron man");
        ironManPlayer.SayHello();
        Console.ReadKey();
    }
    class Player{
        public string name = "-";
        public Player(string name){  // constructor
            this.name = name;
            Console.WriteLine($"creating Player {name}");
        }
        public void SayHello(){
            Console.WriteLine($"Hello {name}!");
        }
    }
    // static keyword means this is will belong to the class itself and not to any of the instance of the class
}
