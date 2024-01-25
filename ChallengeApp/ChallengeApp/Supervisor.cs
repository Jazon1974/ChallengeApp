namespace ChallengeApp
{
    public class Supervisor : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;


        private List<float> grades = new List<float>();

        // public Supervisor()
        // {

        // }

        public Supervisor(string name, string surname)
           : base(name, surname)
        {

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }



        public override void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)

        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6" or "6-":
                    this.AddGrade(95);
                    break;
                case "5+" or "+5":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5-" or "-5":
                    this.AddGrade(75);
                    break;
                case "4+" or "+4":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4-" or "-4":
                    this.AddGrade(55);
                    break;
                case "3+" or "+3":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3-" or "-3":
                    this.AddGrade(35);
                    break;
                case "2+" or "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2-" or "-2":
                    this.AddGrade(15);
                    break;
                case "1+" or "+1":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;

                default:
                    throw new Exception("Wrong number. Number 1-6 allowed");
            }



        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            {

                var statistics = new Statistics();
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in this.grades)
                {
                    if (grade >= 0)
                    {
                        statistics.Max = Math.Max(statistics.Max, grade);
                        statistics.Min = Math.Min(statistics.Min, grade);
                        statistics.Average += grade;
                    }
                }
                statistics.Average /= this.grades.Count;

                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    case var average when average > 0:
                        statistics.AverageLetter = 'E';
                        break;
                    default:
                        statistics.AverageLetter = 'F';
                        break;
                }
                return statistics;
            }
        }
    }
}

