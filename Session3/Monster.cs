namespace Session03
{
    public class Monster
    {
        public string Name { get; }
        public int Hp { get; private set; }

        public Monster(string name, int hp) { Name = name; Hp = hp; }

        public void TakeDamage(int amount) => Hp = Math.Max(0, Hp - amount);
        public bool IsAlive() => Hp > 0;

        // Tambahan: monster membalas dengan 8 damage
        public void Attack(Player target) => target.TakeDamage(8);
    }
}
