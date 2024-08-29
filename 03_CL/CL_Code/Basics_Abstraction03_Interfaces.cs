using System;


namespace Programming_Basics_CL
{
    internal class Basics_Abstraction03_Interfaces
    {
        public static void Main_interface()
        {
            Employee e =new Employee();
            Engineer eng = new Engineer();
            //((ILiving)e).
            test(e);
            test((ILiving)eng);
        }
        public static void test (ILiving i)
        {
            //Employee zakaria;
            Employee emp = i as Employee;
            if (emp != null)
            {
                ((Employee)i).NID = "5";
                Console.WriteLine("I am an Employee");
            }
            else
            {
                Console.WriteLine("I am not an Employee");
            }
        }
    }
    interface ILiving
    {
        void Born();
        void Eat();
        void Move();
        void Sleep();
        void Die();
    }
    class Person
    {
        public string NID = "", Name = "", Address = "";
        public DateTime DateofBirth = DateTime.Now;
    }
    class Employee :Person,  ILiving
    {
        void ILiving.Born()
        {
            throw new NotImplementedException();
        }

        void ILiving.Die()
        {
            throw new NotImplementedException();
        }

        void ILiving.Eat()
        {
            throw new NotImplementedException();
        }

        void ILiving.Move()
        {
            throw new NotImplementedException();
        }

        void ILiving.Sleep()
        {
            throw new NotImplementedException();
        }
    }
    class Engineer : ILiving
    {
        void ILiving.Born()
        {
            throw new NotImplementedException();
        }

        void ILiving.Die()
        {
            throw new NotImplementedException();
        }

        void ILiving.Eat()
        {
            throw new NotImplementedException();
        }

        void ILiving.Move()
        {
            throw new NotImplementedException();
        }

        void ILiving.Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
