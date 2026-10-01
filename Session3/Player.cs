namespace Session03
{
    public class Player
    {
        public string Name { get; }
        public int Hp { get; set; } = 100;
        public int gold { get; set; } = 0;

        public Player(string name, int hp) { Name = name; Hp = hp; }

        public void showPlayer()
        {
            Console.WriteLine($"{Name}: {Hp}");
        }

        public void takeDamage(int amount)
        {
            Hp -= amount;
            if (Hp < 0)
            {
                Hp = 0;
            }
        }

        public bool isAlive() { return Hp > 0; }

    }
}