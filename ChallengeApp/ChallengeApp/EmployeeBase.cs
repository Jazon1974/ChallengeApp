namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        private List<float> grades = new List<float>();


        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Surname { get; private set; }

        public string Name { get; private set; }



        public abstract void AddGrade(float grade);


        public abstract void AddGrade(int grade);


        public abstract void AddGrade(string grade);


        public abstract void AddGrade(double grade);


        public abstract void AddGrade(decimal grade);


        public abstract void AddGrade(long grade);


        public abstract void AddGrade(char grade);


        public abstract Statistics GetStatistics();
    }
}
