using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal b = new Dog();

            a.Move();
            b.Move();
            //b.Bark();
            Console.ReadKey(true);
        }
    }

    class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("A move");
        }
    }

    class Dog : Animal
    {

        public override void Move()
        {
            Console.WriteLine("D Move");
        }
        public void Bark()
        {
            Console.WriteLine("D bark");
        }
    }
}
