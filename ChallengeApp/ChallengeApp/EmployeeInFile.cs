using System.Reflection.Metadata.Ecma335;

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
                    writer.WriteLine(gradeAsFloat);
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

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                float gradeAsFloat = (float)grade;
                writer.WriteLine(gradeAsFloat);
            }
        }

        private List<float> grades = new List<float>();
        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {

                using (var reader = File.OpenText(fileName))

                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.ToString();
                        Console.WriteLine(number);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }

                result.Average = 0;
                result.Max = float.MinValue;
                result.Min = float.MaxValue;

                foreach (var grade in this.grades)
                {
                    if (grade >= 0)
                    {
                        result.Max = Math.Max(result.Max, grade);
                        result.Min = Math.Min(result.Min, grade);
                        result.Average += grade;
                    }
                }
                result.Average /= this.grades.Count;
            }
            return result;
        }

        public override void AddGrade(float input)
        {
        
        }

    }

}
