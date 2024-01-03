

namespace ChallengeApp.test
{
    public class EmployeeTest
    {
        [Test]
        public void valueTest()
        {
            //arrange

            var Employee1 = new Employee("Adam", "Nowak");
            Employee1.AddGrade(2);
            Employee1.AddGrade(16);
            Employee1.AddGrade(6);

            var statistic = Employee1.GetStatistics();

            //act


            // assert
            Assert.AreEqual(Employee1.Name, "Adam");
            Assert.AreEqual(Employee1.Surname, "Nowak");
            Assert.AreEqual(statistic.Min, 2);
            Assert.AreEqual(statistic.Max, 16);
            Assert.AreEqual(statistic.Avarge, 8);

        }
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }


    }
}
