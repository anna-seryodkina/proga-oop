using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler hr1 = new Recruiter1();
            Handler hr2 = new Recruiter2();

            hr1.SetSuccessor(hr2);
            hr1.SetSpecialists(new List<Summary>());
            hr2.SetSpecialists(new List<Summary>());

            Summary mrCodersSummary = new Summary("Coder13", 21, 3, 3000, "nothing", "dev");
            hr1.AddSpecialist(mrCodersSummary);


            Summary mrJsSummary = new Summary("Joe", 25, 4, 10000, "java something", "frontend developer");
            hr2.AddSpecialist(mrJsSummary);


            Vacancy vacancy = new Vacancy(4, 12000, "frontend developer");
            hr1.ProcessRequest(vacancy);
        }
    }


    abstract class Handler
    {
        protected Handler successor;
        protected List<Summary> specialists;
 
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public void SetSpecialists(List<Summary> specialists)
        {
            this.specialists = specialists;
        }
    
        public abstract void ProcessRequest(Vacancy vacancy);

        public abstract void AddSpecialist(Summary summary);

    }

    class Recruiter1 : Handler
    {
        public override void ProcessRequest(Vacancy vacancy)
        {
            if (specialists != null)
            {
                foreach(Summary s in specialists)
                {
                    if(s.position == vacancy.Position && s.experience == vacancy.Experience)
                    {
                        Console.WriteLine($"\nCandidate: {s.fullname}, {s.age} y.o.\n");
                        return;
                    }
                }
            }

            if (successor != null)
            {
                successor.ProcessRequest(vacancy);
            }
        }

        public override void AddSpecialist(Summary summary)
        {
            this.specialists.Add(summary);
        }
    }

    class Recruiter2 : Handler
    {
        public override void ProcessRequest(Vacancy vacancy)
        {
            if (specialists != null)
            {
                foreach(Summary s in specialists)
                {
                    if(s.position == vacancy.Position && s.experience == vacancy.Experience)
                    {
                        Console.WriteLine($"\nCandidate: {s.fullname}, {s.age} y.o.\n");
                        return;
                    }
                }
            }

            Console.WriteLine("\nот халепа! нікого не знайшли...(\n");
        }

        public override void AddSpecialist(Summary summary)
        {
            this.specialists.Add(summary);
        }
    }

    class Vacancy
    {
        private int _experience;
        private double _salary;
        private string _position;

        public Vacancy(int experience, double salary, string pos)
        {
            this._experience = experience;
            this._salary = salary;
            this._position = pos;
        }
    
        public int Experience
        {

            get { return _experience; }
            set { _experience = value; }
        }
    
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }

    class Summary
    {
        public string fullname;
        public int age;
        public int experience;
        public double salary;
        public string skills;
        public string position;

        public Summary(string fullname, int age, int experience, double salary, string skills, string position)
        {
            this.fullname = fullname;
            this.age = age;
            this.experience = experience;
            this.salary = salary;
            this.skills = skills;
            this.position = position;
        }
    }

}
