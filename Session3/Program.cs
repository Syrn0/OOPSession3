using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{

    internal class Program
    {

        Program()
        {
           var player1 = new Player("Aria", 100);
           var player2 = new Player("Bram", 100);
           var player3 = new Player("Citra", 100);

           Weapon weapon1 = new Weapon("Pedang kayu", 5);
           Weapon weapon2 = new Weapon("Busur Elf", 12);
           player3.takeDamage(200);

           player1.showPlayer();
           player2.showPlayer();
           player3.showPlayer();
           Console.WriteLine(player3.isAlive());
           weapon1.showInfo();
           weapon2.showInfo();
        }

        static void Main(string[] args)
        {
           Program p = new Program();
        }

        

    }
}