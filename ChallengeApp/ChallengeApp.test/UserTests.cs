using System.Net.WebSockets;
using System.Reflection.Metadata;

namespace ChallengeApp.tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScorses_ShouldCorrumAsResult()
        {
            // arrange
            var user1 = new User("Jacek", "12345");
            user1.AddScore(5);
            user1.AddScore(6);

            var user2 = new User("Pawe³", "3333");
            user2.AddScore(5);
            user2.AddScore(3);
            user2.AddScore(-8);

            var user3 = new User("Marek", "bvfyuvbdfuib");
            user3.AddScore(2);
            user3.AddScore(-5);
            user3.AddScore(-10);
            // act
            var result1 = user1.Result;
            var result2 = user2.Result;
            var result3 = user3.Result;
            // assert
            Assert.AreEqual(11, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-13, result3);

        }
    }
}