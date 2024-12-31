using System.Reflection;
using System.Resources;

namespace Dictionary;

class Program
{
    private enum ResourceType{
        Stone,
        Wood,
        Gold
    }
    static void Main(string[] args)
    {
        // Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>();
        // // we can also declare and intialise the dictionary at the same time as arrays and lists
        // // Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>() {
        // //     {ResourceType.Gold,45},
        // //     {ResourceType.Stone,45},
        // //     {ResourceType.Wood,45},
        // // };
        // resourceTypeAmountDictionary.Add(ResourceType.Stone,56);
        // // resourceTypeAmountDictionary[ResourceType.Stone] = 56 ;  this does the same thing as the above function
        // Console.WriteLine(resourceTypeAmountDictionary[ResourceType.Stone]);
        // resourceTypeAmountDictionary[ResourceType.Stone] = 30;

        // // methods to check the value of a key in a dictionary
        
        // // Console.WriteLine(resourceTypeAmountDictionary.ContainsKey(ResourceType.Wood));
        // resourceTypeAmountDictionary.Add(ResourceType.Wood,24);
        // if(resourceTypeAmountDictionary.TryGetValue(ResourceType.Wood,out int woodAmount)){  //this function will check the if the given key has a value or not if it has then it will store that value in that variable
        //     Console.WriteLine(woodAmount);
        // }
        // resourceTypeAmountDictionary.Remove(ResourceType.Wood);

        Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>(){
            {ResourceType.Stone,10},
            {ResourceType.Wood,35}
        };
        foreach(KeyValuePair<ResourceType,int> keyValuePair in resourceTypeAmountDictionary){
            Console.WriteLine(keyValuePair.Key+" : "+keyValuePair.Value);
        }
        foreach(ResourceType resourceType in resourceTypeAmountDictionary.Keys){
            Console.WriteLine(resourceType+" : "+resourceTypeAmountDictionary[resourceType]);
        }
        Console.ReadKey();
    }
}
