using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student st = new Student("John Smith");
  
            st.Study(2);
            st.Study(1);
            st.Study(10);
            st.Study(1);
            st.PassExam();
    
            // Wait for user
            Console.ReadKey();
        }
    }


    abstract class State
    {
        protected Student student;
        protected int progress;
    
        protected int lowerLimit;
        protected int upperLimit;
        protected int grade;
    
        // Properties
        public Student Student
        {
            get { return student; }
            set { student = value; }
        }
    
        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }
    
        public abstract void Study(int lessons);
        public abstract void PassExam();
    }


    class ZeroPointsDefaultState : State
    {
        public ZeroPointsDefaultState(State state) : this(state.Progress, state.Student)
        {
            //
        }
    
        public ZeroPointsDefaultState(int progress, Student st)
        {
            this.progress = progress;
            this.student = st;
            Initialize();
        }

        private void Initialize()
        {
            lowerLimit = 0;
            upperLimit = 60;
            grade = 2;
        }

        public override void PassExam()
        {
            Console.WriteLine($"you passed the exam. Grade: {this.grade}");
        }

        public override void Study(int lessons)
        {
            progress += 5 * lessons;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (progress > upperLimit)
            {
                student.State = new ThreePointsState(this);
            }
        }
    }

    class ThreePointsState : State
    {
        public ThreePointsState(State state)
        {
            this.progress = state.Progress;
            this.student = state.Student;
            Initialize();
        }


        private void Initialize()
        {
            lowerLimit = 60;
            upperLimit = 80;
            grade = 3;
        }

        public override void PassExam()
        {
            Console.WriteLine($"you passed the exam. Grade: {this.grade}");
        }

        public override void Study(int lessons)
        {
            progress += 5 * lessons;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (progress > upperLimit)
            {
                student.State = new FourPointsState(this);
            }
        }
    }

    class FourPointsState : State
    {
        public FourPointsState(State state)
        {
            this.progress = state.Progress;
            this.student = state.Student;
            Initialize();
        }


        private void Initialize()
        {
            lowerLimit = 80;
            upperLimit = 95;
            grade = 4;
        }

        public override void PassExam()
        {
            Console.WriteLine($"you passed the exam. Grade: {this.grade}");
        }

        public override void Study(int lessons)
        {
            progress += 5 * lessons;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (progress > upperLimit)
            {
                student.State = new FivePointsState(this);
            }
        }
    }

    class FivePointsState : State
    {
        public FivePointsState(State state)
        {
            this.progress = state.Progress;
            this.student = state.Student;
            Initialize();
        }


        private void Initialize()
        {
            lowerLimit = 95;
            upperLimit = 100;
            grade = 5;
        }

        public override void PassExam()
        {
            Console.WriteLine($"you passed the exam. Grade: {this.grade}");
        }

        public override void Study(int lessons)
        {
            progress += 5 * lessons;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (progress < lowerLimit)
            {
                student.State = new ZeroPointsDefaultState(this);
            }
        }
    }


    class Student
    {
        private State _state;
        private string _name;
    
        // Constructor
        public Student(string st_name)
        {
            this._name = st_name;
            this._state = new ZeroPointsDefaultState(0, this);
        }

        // Properties
        public int Progress
        {
            get { return _state.Progress; }
        }
    
        public State State
        {
            get { return _state; }
            set { _state = value; }
        }
    
        public void Study(int lessons)
        {
            _state.Study(lessons);
            Console.WriteLine($"you are studing... [progress: {_state.Progress}% ]");
        }
        public void PassExam()
        {
            _state.PassExam();
        }
    }

}
