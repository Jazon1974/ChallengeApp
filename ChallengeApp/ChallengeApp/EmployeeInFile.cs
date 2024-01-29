namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(fileName))

            {
                string gradeAsFloat = grade.ToString();
                AddGrade(gradeAsFloat);
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
                    switch (gradeAsChar)
                    {
                        case 'A' or 'a':
                            writer.WriteLine(100);
                            break;
                        case 'B' or 'b':
                            writer.WriteLine(80);
                            break;
                        case 'C' or 'c':
                            writer.WriteLine(60);
                            break;
                        case 'D' or 'd':
                            writer.WriteLine(40);
                            break;
                        case 'E' or 'e':
                            writer.WriteLine(20);
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
                string gradeAsFloat = grade.ToString();
                AddGrade(gradeAsFloat);
            }
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                string gradeAsFloat = grade.ToString();
                AddGrade(gradeAsFloat);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                string gradeAsFloat = grade.ToString();
                AddGrade(gradeAsFloat);
            }
        }    

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    int countline = 1;
                    Console.WriteLine("Liczby z pliku");
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        Console.WriteLine(number);
                        result.AddGrade(number);
                        line = reader.ReadLine();
                        countline++;
                    }
                }

            }
            return result;
        }
    }
}

