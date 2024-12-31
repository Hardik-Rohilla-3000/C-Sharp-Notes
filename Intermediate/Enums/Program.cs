using System.Runtime.CompilerServices;

namespace Enums;

class Program
{
    static void Main(string[] args)
    {
        //  Define unique values with clear names

        PlayerAction playerAction = PlayerAction.NoEnemy;
        Console.WriteLine(playerAction);
        Console.WriteLine((int)playerAction);  //0
        Console.WriteLine((PlayerAction)2);   //Moving toward enemy
        TutorialStage tutorialStage = TutorialStage.Stage1;
        tutorialStage++;
        Console.WriteLine(tutorialStage);  //Stage2
        Console.WriteLine("----------------");
        // syntax to use foreach loop for enums
        foreach(TutorialStage tutorialStage1 in Enum.GetValues(typeof(TutorialStage))){
            Console.WriteLine(tutorialStage1);
        }
        Console.ReadKey();

    }
    // private int GetNextPlayerAction()
    // {
    //     if(!PlayerHasEnemey()){  // now instead of these numbers we can use enum 
    //         return 0;  // No enemy
    //     }
    //     if(!HasPathToEnemy()){
    //         return 1;  // No Path to enemy
    //     }
    //     if(!PlayerWithinAttackDistance()){
    //         return 2;  // moving toward enemy
    //     }
    //     else{
    //         return 3;  // attacking enemy
    //     }
    // }
    
    private enum TutorialStage{
        Stage1,
        Stage2,
        Stage3,
        Stage4,
    }
    private enum PlayerAction{  // at the backend these values are stored as ints and enums is just a datatype
        NoEnemy,
        NoPathToEnemy,
        MovingTowardEnemy,
        AttackingEnemy
    }
    private enum State{
        LookingForEnemy,
        MovingToEnemy,
        AttackingEnemy
    }
    private State state;
    private void HandleState(){
        switch(state){
            case State.MovingToEnemy:
                // moving to enemy logic
                break;
            case State.AttackingEnemy:
                break;
            case State.LookingForEnemy:
                break;
        }
    }
    private PlayerAction GetNextPlayerAction()
    {
        if(!PlayerHasEnemey()){  // now instead of these numbers we can use enum 
            return PlayerAction.NoEnemy;  // No enemy
        }
        if(!HasPathToEnemy()){
            return PlayerAction.NoPathToEnemy;  // No Path to enemy
        }
        if(!PlayerWithinAttackDistance()){
            return PlayerAction.MovingTowardEnemy;  // moving toward enemy
        }
        else{
            return PlayerAction.AttackingEnemy;  // attacking enemy
        }
    }
    private bool PlayerHasEnemey()
    {
        return true;
    }
    private bool HasPathToEnemy()
    {
        return true;
    }
    private bool PlayerWithinAttackDistance()
    {
        return true;
    }
}
