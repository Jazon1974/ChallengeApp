using System.Diagnostics;

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
            float result = (float)grade;
            AddGrade(result);
        }

        public override void AddGrade(string input)
        {
            {
                if (float.TryParse(input, out float grade))
                {
                    AddGrade(grade);
                }
                else if (char.TryParse(input, out char gradeAsChar))
                {
                    switch (gradeAsChar)
                    {
                        case 'A' or 'a':
                            AddGrade((float)100);
                            break;
                        case 'B' or 'b':
                            AddGrade((float)80);
                            break;
                        case 'C' or 'c':
                            AddGrade((float)60);
                            break;
                        case 'D' or 'd':
                            AddGrade((float)40);
                            break;
                        case 'E' or 'e':
                            AddGrade((float)20);
                            break;
                        default:
                            throw new Exception("Wrong letter. Letters A-E allowed");
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
            float result = (float)grade;
            AddGrade(result);
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))

                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);

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

        public override void AddGrade(char grade)
        {
            float result = (float)grade;
            AddGrade(result);
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

