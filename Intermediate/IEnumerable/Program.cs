// learn how to make your custom types work with foreach 
namespace IEnumerable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> intList = new List<int>();
        foreach (int i in intList){

        }
        Console.ReadKey();
    }
    public class PlayerStat{
        public Stat dex = new Stat{name = "Dexterity", value = 12};
        public Stat str = new Stat{name = "Strength", value = 28};
        public Stat wis = new Stat{name = "Wisdom", value = 35};
    }
    public class Stat{
        public string name;
        public int value;
    }
    private class Player{
        
    }
}
