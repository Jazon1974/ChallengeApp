namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;


        private List<float> grades = new List<float>();


        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(fileName))

            {
                float gradeAsFloat = grade;
                writer.WriteLine(gradeAsFloat);
                this.grades.Add(gradeAsFloat);

            }
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (float.TryParse(grade, out float gradeAsFloat))
                {

                    if (gradeAsFloat >= 0 && gradeAsFloat <= 100)
                    {
                        writer.WriteLine(gradeAsFloat);
                        this.grades.Add(gradeAsFloat);


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
                else if (char.TryParse(grade, out char gradeAsChar))
                {
                    writer.WriteLine(gradeAsChar);

                    switch (gradeAsChar)
                    {
                        case 'A' or 'a':
                            this.grades.Add(100);
                            break;
                        case 'B' or 'b':
                            this.grades.Add(80);
                            break;
                        case 'C' or 'c':
                            this.grades.Add(60);
                            break;
                        case 'D' or 'd':
                            this.grades.Add(40);
                            break;
                        case 'E' or 'e':
                            this.grades.Add(20);
                            break;
                        default:
                            throw new Exception("Wrong letter. Letters A-E allowed");
                    }

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Number out of range 0-100 or letter out of range A-E");
                }
            }
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                float gradeAsFloat = (float)grade;
                writer.WriteLine(gradeAsFloat);
                this.grades.Add(gradeAsFloat);
            }
        }


        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
                this.grades.Add(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                float gradeAsFloat = (float)grade;
                writer.WriteLine(gradeAsFloat);
            }
        }

        public override Statistics GetStatistics()

        {
            var statistics = new Statistics();

            foreach (var gradeAsFloat in this.grades)
            {
                statistics.AddGrade(gradeAsFloat);
            }
            return statistics;
        }
    }
}

