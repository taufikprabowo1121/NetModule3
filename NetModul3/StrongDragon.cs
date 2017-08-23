using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModul3
{
    public class StrongDragon : Monster
    {
        public override void Sleeping()
        {
            Console.WriteLine("The strong dragon take a nap...");
        }
        public override void FireEnemy()
        {
            Console.WriteLine("Fire Strong Dragon");
        }
        public void Flying()
        {
            Console.WriteLine("Dragon Flying");
        }
    }
}
