using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealStudent st = new RealStudent();


            Proxy proxy = new Proxy();

            List<string> folder = proxy.CreateFolder(st);

            if (folder != null && folder.Count != 0)
            {
                Console.WriteLine(folder[0]);
            }
            else
            {
                Console.WriteLine("the folder is empty.");
            }

            Console.Read();
        }
    }


    abstract class Student 
    {
        public abstract List<string> CreateFolder(RealStudent realSt);
    }

    class RealStudent : Student
    {
        private string name;
        private int age;
        private int id;
        public int examPoints;
        public RealStudent()
        {
            this.name = "Oleg";
            this.age = 19;
            this.id = 1;
            this.examPoints = 100;
        }
        public string GetInfo()
        {
            return name + " " + age + " y.o." + "[ " + id + " ] points: " + examPoints;
        }
        public override List<string> CreateFolder(RealStudent realSt)
        {
            List<string> folder = new List<string>();
            folder.Add(this.GetInfo());
            return folder;
        }
    }

    class Proxy : Student
    {
        int pointsNeeded = 100;

        public override List<string> CreateFolder(RealStudent realSt)
        {
            List<string> folder = new List<string>();
            if (realSt != null && realSt.examPoints >= this.pointsNeeded)
            {
                realSt = new RealStudent();
                folder = realSt.CreateFolder(realSt);
            }

            return folder;
        }
    }

}
