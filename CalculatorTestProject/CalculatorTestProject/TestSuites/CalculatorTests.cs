using System;
using System.Linq;
using Xunit;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using Xunit.Sdk;
using Xunit.Extensions;
using System.Collections.Generic;

namespace CalculatorTestSuite
{
    public class CalculatorTests : IDisposable
    {
        public CalculatorScreen mainWindow;

        public CalculatorTests()
        {
            Application calcApp = CalculatorApp.Instance.LaunchApp();
            mainWindow = CalculatorApp.GetCalcWindow<CalculatorScreen>("Calculator");
        }

        public void Dispose()
        {
            CalculatorApp.Instance.ShutDownApp();
        }

        public class CalcDataSet
        {
            public string FirstValue { get; set; }
            public Operation Operation { get; set; }
            public string SecondValue { get; set; }
            public string ExpectedResult { get; set; }
        }

        public static IEnumerable<object[]> InputDataPositive()
        {
            return new[]
            {
                new object[]
                {
                    "Division operation verification",
                    new CalcDataSet()
                    {
                        FirstValue = "6",
                        Operation = Operation.Divide,
                        SecondValue = "3",
                        ExpectedResult = "2"
                    }
                },
                new object[]
                {
                    "Addition operation verification",
                    new CalcDataSet()
                    {
                        FirstValue = "8",
                        Operation = Operation.Add,
                        SecondValue = "2",
                        ExpectedResult = "10"            
                    }
                }
            };
        }

        public static IEnumerable<object[]> InputDataNegative()
        {
            return new[]
            {
                new object[]
                {
                    "Verification of division by zero",
                    new CalcDataSet()
                    {
                        FirstValue = "1",
                        Operation = Operation.Divide,
                        SecondValue = "0",
                        ExpectedResult = "Cannot divide by zero"
                    }
                }
            };
        }

        [Fact]
        public void CheckAddition()
        {
            mainWindow.SetValue("2");
            mainWindow.SetOperation(Operation.Add);
            mainWindow.SetValue("3");
            mainWindow.EqualButton.Click();
            string actualResult = mainWindow.ResultLabel.Text;
            string expectedResult = "5";
            Assert.Equal(actualResult, expectedResult);
        }

        [Theory]
        [MemberData("InputDataPositive")]
        public void PositiveOperationsDataDriven(string iterationName, CalcDataSet calcData)
        {
            mainWindow.SetValue(calcData.FirstValue);
            mainWindow.SetOperation(calcData.Operation);
            mainWindow.SetValue(calcData.SecondValue);
            mainWindow.EqualButton.Click();
            string actualResult = mainWindow.ResultLabel.Text;
            Assert.Equal(actualResult, calcData.ExpectedResult);
        }

        [Theory]
        [MemberData("InputDataNegative")]
        public void NegativeOperationsDataDriven(string iterationName, CalcDataSet calcData)
        {
            mainWindow.SetValue(calcData.FirstValue);
            mainWindow.SetOperation(calcData.Operation);
            mainWindow.SetValue(calcData.SecondValue);
            mainWindow.EqualButton.Click();
            string actualResult = mainWindow.ResultLabel.Text;
            Assert.Equal(actualResult, calcData.ExpectedResult);
        }

        [Fact]
        public void CheckAdditionPageObject()
        {
            mainWindow.SetValue("1");
            mainWindow.SetOperation(Operation.Add);
            mainWindow.SetValue("2");
            mainWindow.EqualButton.Click();
            string actualResult = mainWindow.ResultLabel.Text;
            string expectedResult = "3";
            Assert.Equal(actualResult, expectedResult);
        }

        [Fact]
        public void VerifyVersionInAboutWindow()
        {
            mainWindow.HelpMenu.Click();
            mainWindow.AboutCalculatorMenu.Click();
            AboutScreen aboutWindow = CalculatorApp.GetCalcWindow<AboutScreen>("About Calculator");
            string expectedResult = "Version 6.1";
            Assert.Contains(expectedResult, aboutWindow.VersionInformation.Text);
        }
    }
}
