

using System;
using System.ComponentModel.Design;

namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee()
        {
        }
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
                Console.WriteLine("invalid grade value");
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

        public void AddGrade(string input)
        {
            if (float.TryParse(input, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                int longInput = input.Length;
                if (longInput == 1)
                {

                    switch (input[0])
                    {
                        case 'A':
                            this.grades.Add(100);
                            break;
                        case 'B':
                            this.grades.Add(80);
                            break;
                        case 'C':
                            this.grades.Add(60);
                            break;
                        case 'D':
                            this.grades.Add(40);
                            break;
                        case 'E':
                            this.grades.Add(20);
                            break;
                        default:

                            Console.WriteLine("Wrong Letter");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Letter");
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
                case var average when average >= 0:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.Average = 'F';
                    break;
            }

            return statistics;

        }

    }
}
