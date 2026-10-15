namespace Session03
{
    public class Player
    {
        public string Name { get; }
        public int Hp { get; private set; } = 100;
        public int Gold { get; private set; } = 0;

        public Weapon? Equipped { get; private set; }

        public Player(string name, int hp = 100) { Name = name; Hp = hp; }

        public void Equip(Weapon w)
        {
            Equipped = w;
        }

        public void Attack(Monster target)
        {
            int damage = 1;
            if (Equipped != null)
            {
                damage = Equipped.Damage;
            }
            target.TakeDamage(damage);
        }

        public void AddGold(int amount)
        {
            Gold += amount;
        }

        public bool TrySpendGold(int amount)
        {
            if (Gold < amount)
            {
                return false;
            }
            Gold -= amount;
            return true;
        }

        public void TakeDamage(int amount)
        {
            Hp -= amount;
            if (Hp < 0)
            {
                Hp = 0;
            }
        }

        public bool IsAlive() => Hp > 0;

        public void showPlayer()
        {
            Console.WriteLine($"{Name}: {Hp}");
        }
    }
}
