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
            proxy.SetRealStudent(st);

            List<string> folder = proxy.CreateFolder();

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
        public abstract List<string> CreateFolder();
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
        public override List<string> CreateFolder()
        {
            List<string> folder = new List<string>();
            folder.Add(this.GetInfo());
            return folder;
        }
    }

    class Proxy : Student
    {
        int pointsNeeded = 100;
        RealStudent realSt;

        public void SetRealStudent(RealStudent rSt)
        {
            this.realSt = rSt;
        }

        public override List<string> CreateFolder()
        {
            List<string> folder = new List<string>();
            if (this.realSt != null && this.realSt.examPoints >= this.pointsNeeded)
            {
                folder = realSt.CreateFolder();
            }
            else
            {
                Console.WriteLine(">> can't create a folder. Not enought points.");
            }

            return folder;
        }
    }

}
