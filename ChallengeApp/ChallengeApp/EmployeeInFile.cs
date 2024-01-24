namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
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
                    }
                    else
                    {
                        throw new Exception("Number out of range 0-100");
                    }
                }
                else if (char.TryParse(grade, out char gradeAsChar))
                {
                    writer.WriteLine(gradeAsChar);
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
            }
        }

        public override void AddGrade(decimal grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                float gradeAsFloat = (float)grade;
                writer.WriteLine(gradeAsFloat);
            }
        }

        public override void AddGrade(long grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                float gradeAsFloat = (float)grade;
                writer.WriteLine(gradeAsFloat);
            }
        }
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
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
            throw new NotImplementedException();
        }
    }
}

