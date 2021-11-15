using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Properties Demo:");
            Console.WriteLine();
            Player player = new Player();
            //player.health = 100;
            player.SetHealth(100);
            
            //Examples
            player.SetHealth(1);

            if (player.GetHealth() == 0)
            {
                //player dies.......
            }

            player.Shield = 99999;

            if (player.Shield == 0)
            {
                //shield breaks
            }

            //CAN'T DO THIS
            //player.Name = "falseName";

            Console.WriteLine("Player Name: " + player.Name);
            Console.WriteLine("Player Shield: " + player.Shield);
            Console.WriteLine("Player Health: " + player.GetHealth());
            Console.ReadKey(true);
        }
    }
}
