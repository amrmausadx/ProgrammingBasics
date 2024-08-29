using System;
namespace Programming_Basics_CL
{
    internal class Animal
    {
        protected static bool silent = false;
        protected string Name = "animal";
        public Animal()
        {
            if (!silent)
                Console.WriteLine(Name + " is Created");
        }
        public void Eat()
        {
            Console.WriteLine("An Animal EATS");
        }
        public virtual void Move()
        {
            //base.
            Console.WriteLine("An Animal MOVES");
        }

        public static void Main01()
        {
            Lion l = new Lion();
            //Console.Write(l.Name);
            l.Move();
        }
        public static void Main02()
        {
            Lion[] lions = new Lion[5];
            Lion.silent = true;
            for (int i = 0; i < lions.Length; i++)
            {
                lions[i] = new Lion();
                lions[i].Move();
            }
            //l.Move();
        }
        public static void Main03()
        {
            Lion[] lions = new Lion[5];
            Lion.silent = true;
            int i = 0;
            //lions[i] = new Animal();
            Animal a = new Lion();
            ((Lion)a).GiveBirth();
        }
        public static void Main04_MethodsCall()
        {
            Animal a = new Animal();
            a = new Mammal();
            ((Mammal)a).MammalOnly();

            a = new Lion();
            ((Mammal)a).MammalOnly();
            ((Lion)a).LionOnly();

            Lion l = new Lion();
            l.LionOnly();
            //l = (new Mammal());
        }
        public static void Main05_MethodsCall2()
        {
            Animal.silent = true;
            Animal a = new Animal();
            Animal am = new Mammal();
            Mammal m = new Mammal();
            Console.WriteLine("a.Eat()");
            Console.WriteLine("a.Move()");
            a.Eat();
            a.Move();
            Console.WriteLine("am.Eat()");
            Console.WriteLine("am.Move()");
            am.Eat();
            am.Move();
            Console.WriteLine("m.Eat()");
            Console.WriteLine("m.Move()");
            m.Eat();
            m.Move();
        }
        public static void Main06_Ploy()
        {
            Animal.silent = true;
            Random r = new Random();
            Animal[] a = new Animal[10];
            for (int i = 0; i < 10; i++)
            {
                double x = r.NextDouble() * 1000;
                if (x < 300)
                    a[i] = new Animal();
                else if (x < 600)
                    a[i] = new Mammal();
                else
                    a[i] = new Lion();

                Console.Write((i + 1) + " :");
                a[i].Move();
                a[i].Eat();
                Console.Write("Replacing new :");
                if (a[i] is Mammal)
                    ((Mammal)a[i]).Eat();
                else if (a[i] is Lion)
                    ((Lion)a[i]).Eat();
                else
                    a[i].Eat();
            }
        }
    }
    internal class Bird:Animal
    {
        public Bird() {
            Name = "Bird";
            if (!silent) Console.WriteLine(Name + " is Created"); }
    }
    internal class Fish : Animal
    {
        public Fish()
        {
            Name = "Fish";
            if (!silent) Console.WriteLine(Name + " is Created");
        }
    }
    internal class Mammal : Animal
    {
        public Mammal()
        {
            Name = "Mammal";
            if (!silent) Console.WriteLine(Name + " is Created");
        }
        public virtual void GiveBirth()
        {

        }
        public new void Eat()
        {
            Console.WriteLine("A Mammal EATS");
        }
        public override void Move()
        {
            
            Console.WriteLine("A Mammal MOVES");
           // base.Move();
        }
        public void MammalOnly()
        {

        }
    }
    internal class Lion : Mammal
    {
        public Lion()
        {
            Name = "Lion";
            if (!silent) Console.WriteLine(Name + " is Created");
        }
        public new void Eat() {
            Console.WriteLine("A lion eats meat");

        }
        public override void Move()
        {   
            Console.WriteLine("A lion MOVES");
            //base.Move();
        }
        public void LionOnly()
        {

        }
       
    }
    
}