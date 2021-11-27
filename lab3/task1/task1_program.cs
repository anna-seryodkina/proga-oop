using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite district = new Composite("Dist-13");

            Composite street1 = new Composite("Awesome street");
            district.Add(street1);
            Composite street2 = new Composite("Red street");
            district.Add(street2);

            Composite build1 = new Composite("build#42");
            Composite build2 = new Composite("build#9");
            Composite build3 = new Composite("build#4");

            street1.Add(build1);
            street1.Add(build2);
            street2.Add(build3);

            Flat fl1 = new Flat("#0");
            Flat fl2 = new Flat("#0");
            Flat fl3 = new Flat("#1");
            Flat fl4 = new Flat("#0");

            build1.Add(fl1);
            build2.Add(fl2);
            build2.Add(fl3);
            build3.Add(fl4);
        

            district.GetInfo();
            district.Display(2);
            Console.ReadKey();
        }
    }


    abstract class ResidentalComponent
    {
        protected string name;
        protected int people;

        public ResidentalComponent(string name)
        {
            this.name = name;
        }

        public abstract void Add(ResidentalComponent c);
        public abstract void Remove(ResidentalComponent c);
        public abstract int GetInfo();
        public abstract void Display(int depth);
        
    }

    class Composite : ResidentalComponent
    {
        private List<ResidentalComponent> _children = new List<ResidentalComponent>();

        public Composite(string name) : base(name) 
        {
            this.people = 0;
        }

        public override void Add(ResidentalComponent component)
        {
            _children.Add(component);
        }

        public override void Remove(ResidentalComponent component)
        {
            _children.Remove(component);
        }


        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + this.people.ToString());

            // Recursively display child nodes
            foreach (ResidentalComponent component in _children)
            {
                component.Display(depth + 2);
            }
        }


        public override int GetInfo()
        {
            this.people = 0;
            foreach (ResidentalComponent component in _children)
            {
                this.people += component.GetInfo();
            }            
            return this.people;
        }
    }


    class Flat : ResidentalComponent
    {

        public Flat(string name) : base(name)
        {
            Random rnd = new Random();
            this.people = rnd.Next(150);
        }

        public override void Add(ResidentalComponent c)
        {
            Console.WriteLine("Impossible operation");
        }

        public override void Remove(ResidentalComponent c)
        {
            Console.WriteLine("Impossible operation");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + people.ToString());
        }

        public override int GetInfo()
        {
            return this.people;
        }
    }
}
