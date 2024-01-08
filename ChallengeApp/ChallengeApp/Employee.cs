

using System;

namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();
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
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
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

        public Statistics GetStatistics()
        {
          var statistics = new Statistics();
          statistics.Avarge = 0;
          statistics.Max = float.MinValue;
          statistics.Min = float.MaxValue;

          foreach (var grade in this.grades)
          {
              statistics.Max = Math.Max(statistics.Max, grade);
              statistics.Min = Math.Min(statistics.Min, grade);
              statistics.Avarge += grade;
          }
          statistics.Avarge /= this.grades.Count;


          return statistics;

         }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Avarge = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            var liczba = this.grades[index];
            while (index < this.grades.Count)
            {
                liczba = this.grades[index];
                statistics.Max = Math.Max(statistics.Max, liczba);
                statistics.Min = Math.Min(statistics.Min, liczba);
                statistics.Avarge += liczba;
                index++;
            }
            statistics.Avarge /= this.grades.Count;


            return statistics;

        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Avarge = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            do
            {
                var liczba = this.grades[index];
                statistics.Max = Math.Max(statistics.Max, liczba);
                statistics.Min = Math.Min(statistics.Min, liczba);
                statistics.Avarge += liczba;
                index++;
            }
            while (index < this.grades.Count);

            statistics.Avarge /= this.grades.Count;

            return statistics;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Avarge = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            float liczba = 0;
            for (int index = 0; index < this.grades.Count; ++index)
            {
                liczba = this.grades[index];
                statistics.Max = Math.Max(statistics.Max, liczba);
                statistics.Min = Math.Min(statistics.Min, liczba);
                statistics.Avarge += liczba;
            }
            statistics.Avarge /= this.grades.Count;


            return statistics;

        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Avarge = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarge += grade;
            }
            statistics.Avarge /= this.grades.Count;


            return statistics;

        }
    }
}
