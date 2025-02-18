namespace InvestigatingDotNetReverse
{
    using System.Collections.Concurrent;
    //using System.Linq;

    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var stack = new ConcurrentStack<string>(["one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"]);

            // Act
            var test = stack.ToArray().Reverse().ToList();

            // Assert
            Assert.Equals(10, test.Count);
            //Assert.Contains("one", array);
            //Assert.Contains("ten", array);
        }
    }
}
