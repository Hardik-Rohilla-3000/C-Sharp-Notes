namespace Events;  // how to have one class be notified when something happens

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Player player = new Player();
        PlayerHealthBar playerHealthBar = new PlayerHealthBar(player);
        player.Damage();
        Console.ReadKey();
    }
    private class Player{
        public event Action OnPlayerDamaged;
        public void Damage(){
            if(OnPlayerDamaged != null){
                OnPlayerDamaged();
            }
        }
    }
    private class PlayerHealthBar{
        public PlayerHealthBar(Player player){
            player.OnPlayerDamaged += Player_OnPlayerDamaged;
        }
        private void Player_OnPlayerDamaged(){
            Console.WriteLine("Player_OnPlayerDamaged!");
        }
    }
}
