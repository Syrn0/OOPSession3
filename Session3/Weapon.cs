namespace Session03
{
    public class Weapon
    {
        public string Name { get; }
        public int Damage { get; }

        public Weapon(string name, int damage)
        {
            {
                Name = name;
                Damage = damage;
            }
        }

        public void showInfo()
        {
            Console.WriteLine($"{Name} - {Damage}");
        }
    }
}