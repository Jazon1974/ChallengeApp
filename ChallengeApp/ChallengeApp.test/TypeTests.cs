namespace ChallengeApp.test
{
    public class TypeTests
    {
        [Test]
        public void ValueTest()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;
            

            var user1 = new User("Jacek", "555");
            var user2 = new User("Jacek", "666");

            // act

            // assert
            // verification of the same values
            Assert.AreEqual(number1, number2);
          

            //verification whether the references are equal
           Assert.AreEqual(user1.Login, user2.Login);

            // verification whether references are different
            Assert.AreNotEqual(user1, user2);
            Assert.AreNotEqual(user1.Password, user2.Password);
        }

        private User GetUser(string name, string password)
        {
            return new User(name, password);
        }
    }
}