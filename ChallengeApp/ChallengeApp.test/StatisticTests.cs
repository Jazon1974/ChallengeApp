

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
            var statistic = employee.GetStatistics();

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
            var statistic = employee.GetStatistics();

            // assert
            Assert.AreEqual(16, statistic.Max);
        }



        [Test]
        public void EmployeeStatisticsTestInputValue()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(10);
            employee.AddGrade(20);
            employee.AddGrade(30);

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual(20, statistic.Average);
        }

        [Test]
        public void EmployeeStatisticsTestInputValueLetter()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade("A");
            employee.AddGrade("B");
            employee.AddGrade("C");

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual(80, statistic.Average);
        }

        [Test]
        public void EmployeeStatisticsTestInputMixValueLetter()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade("A");
            employee.AddGrade("20");
            employee.AddGrade("C");

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual(60, statistic.Average);
        }

        [Test]
        public void EmployeeStatisticsTestAveradgeLetterA()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade("A");
            employee.AddGrade("A");
            employee.AddGrade("B");

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual('A', statistic.AverageLetter);
        }

        [Test]
        public void EmployeeStatisticsTestAveradgeLetterB()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade("A");
            employee.AddGrade("20");
            employee.AddGrade("C");

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual('B', statistic.AverageLetter);
        }

        [Test]
        public void EmployeeStatisticsTestAveradgeLetterC()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade("B");
            employee.AddGrade("80");
            employee.AddGrade("10");

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual('C', statistic.AverageLetter);
        }

        [Test]
        public void EmployeeStatisticsTestAveradgeLetterD()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade("E");
            employee.AddGrade("20");
            employee.AddGrade("C");

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual('D', statistic.AverageLetter);
        }

        [Test]
        public void EmployeeStatisticsTestAveradgeLetterE()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade("10");
            employee.AddGrade("E");
            employee.AddGrade("10");

            //act
            var statistic = employee.GetStatistics();

            //assert
            Assert.AreEqual('E', statistic.AverageLetter);
        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}

