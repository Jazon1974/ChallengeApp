namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

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
                    char.TryParse(grade, out char chargrade);
                    switch (chargrade)
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

        public override void AddGrade(char grade)
        {
            float result = (float)grade;
            this.AddGrade(grade);
        }

        public override Statistics GetStatistics()
        {

            {
                var statistics = new Statistics();

                foreach (var grade in this.grades)
                {
                    statistics.AddGrade(grade);
                }

                return statistics;
            }
        }
    }
}
