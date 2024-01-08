

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
            var statistics4 = new Statistics();
            statistics4.Avarge = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;

            var index = 0;

            var liczba = this.grades[index];
            while (index < this.grades.Count)
            {
                liczba = this.grades[index];
                statistics4.Max = Math.Max(statistics4.Max, liczba);
                statistics4.Min = Math.Min(statistics4.Min, liczba);
                statistics4.Avarge += liczba;
                index++;
            }
            statistics4.Avarge /= this.grades.Count;


            return statistics4;

        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Avarge = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            var index = 0;

            do
            {
                var liczba = this.grades[index];
                statistics3.Max = Math.Max(statistics3.Max, liczba);
                statistics3.Min = Math.Min(statistics3.Min, liczba);
                statistics3.Avarge += liczba;
                index++;
            }
            while (index < this.grades.Count);

            statistics3.Avarge /= this.grades.Count;

            return statistics3;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Avarge = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            float liczba = 0;
            for (int index = 0; index < this.grades.Count; ++index)
            {
                liczba = this.grades[index];
                statistics2.Max = Math.Max(statistics2.Max, liczba);
                statistics2.Min = Math.Min(statistics2.Min, liczba);
                statistics2.Avarge += liczba;
            }
            statistics2.Avarge /= this.grades.Count;


            return statistics2;

        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics1 = new Statistics();
            statistics1.Avarge = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Avarge += grade;
            }
            statistics1.Avarge /= this.grades.Count;


            return statistics1;

        }
    }
}
