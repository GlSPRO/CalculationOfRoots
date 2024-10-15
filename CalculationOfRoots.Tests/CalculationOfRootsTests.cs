using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MathOperations.Tests
{
    [TestClass]
    public class MathOperationsTests
    {
        static CalculationOfRoot mathOperations;
        static List<double> expectedRootsDGreaterThanZero;
        static List<double> expectedRootDEqualsZero;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            mathOperations = new CalculationOfRoot();

            expectedRootsDGreaterThanZero = new List<double> { 1, -3 };
            expectedRootDEqualsZero = new List<double> { -1 };
        }

        [TestMethod]
        public void FindRoots_DGreaterThanZero_ReturnsTwoRoots()
        {
            double a = 1, b = 2, c = -3;
            List<double> actualRoots = mathOperations.FindRoots(a, b, c);

            CollectionAssert.AreEquivalent(expectedRootsDGreaterThanZero, actualRoots);
            CollectionAssert.AllItemsAreUnique(actualRoots);
        }

        [TestMethod]
        public void FindRoots_DEqualsZero_ReturnsOneRoot()
        { // Discriminant =0
            double a = 1, b = 2, c = 1;
            List<double> actualRoot = mathOperations.FindRoots(a, b, c);

            CollectionAssert.AreEqual(expectedRootDEqualsZero, actualRoot);
        }

        [TestMethod]
        public void FindRoots_DLessThanZero_IsNotSubsetOf()
        {
            double a = 1, b = 1, c = 1;

            List<double> actualRoots = mathOperations.FindRoots(a, b, c);

            List<double> someNumbers = new List<double> { 1, 2, 3 };
            // Тут корней нет
            CollectionAssert.IsNotSubsetOf(actualRoots, someNumbers);
        }


        [TestMethod]
        public void CalculatePercentage_ValidInputs_ReturnsCorrectResult()
        {
            double number = 200;
            double percentage = 12.5;
            double expected = 25;
            double actual = mathOperations.CalculatePercentage(number, percentage);

            Assert.AreEqual(expected, actual, delta: 0.0001, $"Процент от {number} при {percentage}% должен быть равен {expected}");
        }
    }
}
