using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModul3
{
    public class FunnyChicken : Monster
    {
        public override void Sleeping()
        {
           Console.WriteLine("The funny chicken tahe a nap...");
        }
        public void Eating()
        {
            Console.WriteLine("yummy");
        }

        public override void FireEnemy()
        {
            throw new NotImplementedException();
        }
    }
}
