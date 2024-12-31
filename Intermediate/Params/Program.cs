// namespace Params;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//         PrintPlayerName("Hardik Rohilla","code monkey");  // we can pass this function without any parameter also
//         Console.ReadKey();
//     }
//     private static void PrintPlayerName(params string[] playerNameArray){  // params parameter must be the last parameter in the parameter list
//         Console.WriteLine(playerNameArray.Length);
//     }
// }



// Optional Params

using System.Numerics;

namespace Params;

class Program
{
    private enum UnitType{
        Melee,
        Ranged,
        Wizard
    }
    static void Main(string[] args)
    {
        SpawnUnit(new Vector3(0,0,0), UnitType.Melee, Quaternion.Identity, 56);
        // SpawnUnit(healthAmount: 56);  // with this we can only pass the health argument condition all other params should be optional
        // SpawnUnit(new Vector3(10,5,0));
        Console.ReadKey();
    }
    // private static void SpawnUnit(Vector3 spawnPositon){
    //     SpawnUnit(spawnPositon,UnitType.Melee,Quaternion.Identity,100);
    // }
    // private static void SpawnUnit(Vector3 spawnPositon, UnitType unitType, Quaternion spawnRotation, int healthAmount){
    //     Console.WriteLine($"Spawning unit of type {unitType} with health: {healthAmount} at {spawnPositon}, {spawnRotation}");
    // }
    private static void SpawnUnit(Vector3 spawnPositon, UnitType unitType, Quaternion spawnRotation, int healthAmount = 100){ // now we don't need to pass the health argument it will come as 100 by default and it should come at last as the params 
        Console.WriteLine($"Spawning unit of type {unitType} with health: {healthAmount} at {spawnPositon}, {spawnRotation}");
    }
}