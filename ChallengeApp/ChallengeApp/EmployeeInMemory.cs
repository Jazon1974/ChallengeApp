namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        
        public event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
        
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Number out of range 0-100");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                int longInput = grade.Length;
                if (longInput == 1)
                {
                    char.TryParse(grade, out char grade1);
                    switch (grade1)
                    {
                        case 'A' or 'a':
                            this.AddGrade(100);
                            break;
                        case 'B' or 'b':
                            this.AddGrade(80);
                            break;
                        case 'C' or 'c':
                            this.AddGrade(60);
                            break;
                        case 'D' or 'd':
                            this.AddGrade(40);
                            break;
                        case 'E' or 'e':
                            this.AddGrade(20);
                            break;
                        default:
                            throw new Exception("Wrong letter. Letters A-E allowed");
                    }
                }
                else
                {
                    throw new Exception("Wrong letter. Letters A-E allowed");
                }
            }
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            float result = (float)grade;
            this.AddGrade(grade);
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
