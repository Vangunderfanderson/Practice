using Classes.MessageWriter;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AlgorithmTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            var writer = new MockMessageWriter();
            var fizzBuzz = new FizzBuzz.FizzBuzz(writer);
            fizzBuzz.Run(0, 100);
            var results = writer.WrittenMessages.ToArray();
            Assert.AreEqual("1", results[1]);
            Assert.AreEqual("Fizz", results[3]);
            Assert.AreEqual("Buzz", results[5]);
            Assert.AreEqual("FizzBuzz", results[15]);
        }
    }
}
