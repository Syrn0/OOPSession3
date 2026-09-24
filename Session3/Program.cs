using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player("Aria", 100);
            var player2 = new Player("Bram", 100);
            var player3 = new Player("Citra", 100);

            var weapon1 = new Weapon("Pedang kayu", 5);
            var weapon2 = new Weapon("Busur Elf", 12);

            player2.Hp -= 30;

            player1.showPlayer();
            player2.showPlayer();
            player3.showPlayer();

            weapon1.showInfo();
            weapon2.showInfo();
        }

        

    }
}