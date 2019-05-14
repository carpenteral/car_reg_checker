using car_reg_utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace car_reg_checker_tests
{
    [TestClass]
    public class CarRegCheckerTest
    {
        [TestMethod]
        public void test_if_51_next_infix_is_02()
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
            CarRegCheckerUtil cut = new CarRegCheckerUtil();
            int[] input = { 51, 52, 52, 54, 55, 56, 57, 58, 59, 60, 61, 62,63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96 ,97, 98, 99};
            int[] expected = { 02, 03, 04, 05, 06, 07 , 08 , 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 };
            int result;

            // Act
            foreach (int number in input)
            {
               result = cut.GetNextInfix(number);
                // Assert
                foreach (int expNum in expected)
                {
                    Assert.AreEqual(expNum, result);
                }
            }
             

            
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
