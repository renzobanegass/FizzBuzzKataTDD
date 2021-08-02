using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKataTest
{
    [TestClass]
    public class FizzBuzzKataTest
    {
        [TestMethod]
        public void Returns_1_on_Position_0_Array()
        {
            object[] FizzBuzzList = FizzBuzzKata.FizzBuzzKata.GetList();

            Assert.AreEqual(1, FizzBuzzList[0]);
        }

        [TestMethod]
        public void Returns_Fizz_on_Position_2_Array()
        {
            object[] FizzBuzzList = FizzBuzzKata.FizzBuzzKata.GetList();

            Assert.AreEqual("Fizz", FizzBuzzList[2]);
        }

        [TestMethod]
        public void Returns_Buzz_on_Position_4_Array()
        {
            object[] FizzBuzzList = FizzBuzzKata.FizzBuzzKata.GetList();

            Assert.AreEqual("Buzz", FizzBuzzList[4]);
        }

        [TestMethod]
        public void Returns_FizzBuzz_on_Position_14_Array()
        {
            object[] FizzBuzzList = FizzBuzzKata.FizzBuzzKata.GetList();

            Assert.AreEqual("FizzBuzz", FizzBuzzList[14]);
        }

        [TestMethod]
        public void Return_Correct_Array()
        {
            object[] FizzBuzzList = FizzBuzzKata.FizzBuzzKata.GetList();

            object[] CorrectFizzBuzzList = new object[] { 1, 2 , "Fizz", 4, "Buzz", "Fizz", 7, 8, "Fizz", "Buzz", 11, "Fizz", 13, 14, "FizzBuzz", 16, 17, "Fizz", 19, "Buzz"};

            CollectionAssert.AreEqual(CorrectFizzBuzzList, FizzBuzzList);
        }
    }
}
