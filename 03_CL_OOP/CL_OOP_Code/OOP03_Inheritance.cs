using System;
using System.Configuration;
namespace ProgrammingBasics._03_OOP
{
    internal class Animal
    {
        protected string Name = "Animal"; 
    }
    internal class Bird:Animal
    {
        public Bird() { Name = "Bird";}

    }
    internal class Fish:Animal
    {
        public Fish() { Name = "Fish"; }

    }
    internal class Mammal:Animal
    {
        public Mammal() { Name = "Mammal"; }
    }
    internal class Lion:Mammal
    {
        public Lion() { Name = "Lion"; }
    }
}
