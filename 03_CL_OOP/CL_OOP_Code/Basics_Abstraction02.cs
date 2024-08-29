using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_CL.Abstraction
{
    internal class Basics_Abstraction02
    {
        public static void Main_Pubby()
        {
            Animal d = new Pubby();
            d.Sound();
        }
    }
    public abstract class Animal {
        public abstract void Sound();
        public void Sleep()
        {
            Console.WriteLine("ZZZZZ!");
        }
    }
    class Dog:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Parks!");
        }
    }
    class Pubby : Dog
    {
       /* public override void Sound()
        {
            Console.WriteLine("Litte Dog Parks!");
        }*/
    }
}
