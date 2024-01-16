
namespace ChallengeApp
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();

        public Employee() { }
        public Employee(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Number out of range 0-100");
            }
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(string grade)
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

                    switch (grade[0])
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

        public Statistics GetStatistics()
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