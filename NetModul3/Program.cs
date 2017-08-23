using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModul3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsters = new List<Monster>();
            monsters.Add(new StrongDragon());
            foreach(Monster monster in monsters)
            {
                if(monster is Fire)
                {
                   (monster as Fire).FireEnemy();
                }
                else
                {
                    Console.WriteLine("interface canot load");
                }
               
            }
            Console.ReadKey();
                /*
            Monster monster = new StrongDragon();
            FunnyChicken chicken = new FunnyChicken();

            monster.Sleeping();
            chicken.Sleeping();

            Console.ReadKey();
            */
        }
    }
}
