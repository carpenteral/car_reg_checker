using car_reg_utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace car_reg_checker_tests
{
    [TestClass]
    public class CarRegCheckerTest
    {
        [TestMethod]
        public void test_case_1()
        {
            // Arrange
            CarRegCheckerUtil cut = new CarRegCheckerUtil();
            int input = 51;
            int expected = 02;

            // Act
            int result = cut.GetNextInfix(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_case_2()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void test_case_3()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void test_case_4()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
