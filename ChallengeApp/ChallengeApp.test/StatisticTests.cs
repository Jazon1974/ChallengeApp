

namespace ChallengeApp.test
{
    public class StatisticTests
    {
        [Test]
        public void EmployeeStatisticTestMin()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(16);
            employee.AddGrade(6);

            //act
            var statistic = employee.GetStatisticsWithWhile();

            // assert
            Assert.AreEqual(2, statistic.Min);
        }

        [Test]
        public void EmployeeStatisticTestMax()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(16);
            employee.AddGrade(6);

            //act
            var statistic = employee.GetStatisticsWithWhile();

            // assert
            Assert.AreEqual(16, statistic.Max);
        }

        [Test]
        public void EmployeeStatisticTestAvarge()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(16);
            employee.AddGrade(6);

            //act
            var statistic = employee.GetStatisticsWithWhile();

            // assert
            Assert.AreEqual(8, statistic.Avarge);
        }
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
