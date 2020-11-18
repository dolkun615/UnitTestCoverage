using FinanceCalculator;
using System;
using Xunit;

namespace XUnitTest {
    public class UnitTest1 {
        [Fact]
        public void TestSmall()  {
            string expectedValue = "Small";
            string actualValue = FinanceCalculator.Calculator.GetOrderCategory(99);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void TestLarge() {
            string expectedValue = "Large";
            string actualValue = FinanceCalculator.Calculator.GetOrderCategory(101);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void TestAmount100() {
            string expectedValue = "Large";
            string actualValue = FinanceCalculator.Calculator.GetOrderCategory(100);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void TestAddFunction() {
            int expected = 30;
            int actual = FinanceCalculator.Calculator.AddNumbers(10, 20);
            Assert.Equal(expected, actual);  

        } 

    }
}
