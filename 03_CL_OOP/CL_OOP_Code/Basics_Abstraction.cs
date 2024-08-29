using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_CL
{
    internal class Basics_Abstraction
    {
        public Basics_Abstraction() {
            
            Baloon[] b=new Baloon[3];

        }
    }
    abstract class Baloon
    {
        //internal int speed = 0;
        public abstract void Rise();
      /*  {
            Console.WriteLine("My Speed is to be determined later");
        }*/
    }
    class BlueBaloon : Baloon
    {
        public override void Rise()
        {
            Console.WriteLine("My Speed is 7 meters per minutes");
        }
    }
    class GreenBaloon : Baloon
    {
        public override void Rise()
        {
            Console.WriteLine("My Speed is 6 meters per minutes");
        }

    }
    class RedBaloon : Baloon
    {
        public override void Rise()
        {
            Console.WriteLine("My Speed is 5 meters per minutes");
        }

    }

}
