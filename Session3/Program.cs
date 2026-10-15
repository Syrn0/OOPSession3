using System;

namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Latihan1();
            Latihan2();
            Latihan3();
            Latihan4();
        }

        static void Latihan1()
        {
            var hero = new Player("Aria");
            var slime = new Monster("Slime", 30);
            hero.Attack(slime);                          Console.WriteLine(slime.Hp);
            hero.Equip(new Weapon("Busur Elf", 12));
            hero.Attack(slime);                          Console.WriteLine(slime.Hp);
        }

        static void Latihan2()
        {
            var hero = new Player("Aria");
            hero.Equip(new Weapon("Pedang Kayu", 5));
            var slime = new Monster("Slime", 30);

            // loop selama keduanya hidup:
            while (hero.IsAlive() && slime.IsAlive())
            {
                hero.Attack(slime);
                if (slime.IsAlive())
                {
                    slime.Attack(hero);
                }
            }

            if (hero.IsAlive())
            {
                Console.WriteLine($"{hero.Name} menang! Sisa Hp: {hero.Hp}");
            }
            else
            {
                Console.WriteLine($"{slime.Name} menang! Sisa Hp: {slime.Hp}");
            }
        }

        static void Latihan3()
        {
            var hero = new Player("Aria");
            var slime = new Monster("Slime", 30);
            var quest = new Quest("Basmi Slime", slime, 50);

            quest.TryComplete();            Console.WriteLine(hero.Gold); 
            quest.Accept(hero);
            quest.TryComplete();            Console.WriteLine(hero.Gold); 
            slime.TakeDamage(30);
            quest.TryComplete();            Console.WriteLine(hero.Gold);  
            quest.TryComplete();            Console.WriteLine(hero.Gold);  
        }

        static void Latihan4()
        {
            var hero = new Player("Aria");
            hero.AddGold(20);
            var shop = new Shop();
            var bow = new Weapon("Busur Elf", 12);

            Console.WriteLine(shop.Sell(hero, bow, 30));   
            Console.WriteLine(hero.Gold);
            hero.AddGold(15);
            Console.WriteLine(shop.Sell(hero, bow, 30));   
            Console.WriteLine(hero.Gold);
            Console.WriteLine(hero.Equipped?.Name);
        }
    }
}
