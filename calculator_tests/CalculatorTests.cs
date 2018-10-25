using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System.Diagnostics;

namespace calculator_tests
{
    [TestClass]
    public class Multiplication
    {
        [TestMethod]
        public void WholeNumbers()
        {
            var input = "2 * 3";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("6", output);
        }

        [TestMethod]
        public void ImproperFraction()
        {
            var input = "9/2 * 1/5";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("9/10", output);
        }

        [TestMethod]
        public void FractionDoubleDigit()
        {
            var input = "1/2 * 31/81";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("31/162", output);
        }

        [TestMethod]
        public void Fraction()
        {
            var input = "1/2 * 3/8";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("3/16", output);
        }

        [TestMethod]
        public void Multiple_Fractions()
        {
            var input = "2/3 * 3/4 * 30/90";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1/6", output);
        }

        [TestMethod]
        public void Multiple_WholeNumberWithFractions()
        {
            var input = "2_1/2 * 3_3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("9_3/8", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberAndFraction()
        {
            var input = "2 * 3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_1/2", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndFraction()
        {
            var input = "2_1/4 * 1/2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_1/8", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndWholeNumber()
        {
            var input = "2_1/2 * 2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("5", output);
        }
    }


    [TestClass]
    public class Division
    {
        [TestMethod]
        public void WholeNumbers()
        {
            var input = "2 / 3";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("2/3", output);
        }

        [TestMethod]
        public void ImproperFraction()
        {
            var input = "9/2 / 1/5";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("22_1/2", output);
        }

        [TestMethod]
        public void FractionDoubleDigit()
        {
            var input = "1/2 / 31/81";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_19/62", output);
        }

        [TestMethod]
        public void Fraction()
        {
            var input = "1/2 / 3/8";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_1/3", output);
        }

        [TestMethod]
        public void Multiple_Fractions()
        {
            var input = "2/3 / 3/4 / 30/90";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("2_2/3", output);
        }

        [TestMethod]
        public void Multiple_WholeNumberWithFractions()
        {
            var input = "2_1/2 / 3_3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("2/3", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberAndFraction()
        {
            var input = "2 / 3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("2_2/3", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndFraction()
        {
            var input = "2_1/4 / 1/2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("4_1/2", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndWholeNumber()
        {
            var input = "2_1/2 / 2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_1/4", output);
        }
    }


    [TestClass]
    public class Addition
    {
        [TestMethod]
        public void WholeNumbers()
        {
            var input = "2 + 3";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("5", output);
        }

        [TestMethod]
        public void ImproperFraction()
        {
            var input = "9/2 + 1/5";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("4_7/10", output);
        }

        [TestMethod]
        public void FractionDoubleDigit()
        {
            var input = "1/2 + 31/81";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("143/162", output);
        }

        [TestMethod]
        public void Fraction()
        {
            var input = "1/2 + 3/8";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("7/8", output);
        }

        [TestMethod]
        public void Multiple_Fractions()
        {
            var input = "2/3 + 3/4 + 30/90";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_3/4", output);
        }

        [TestMethod]
        public void Multiple_WholeNumberWithFractions()
        {
            var input = "2_1/2 + 3_3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("6_1/4", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberAndFraction()
        {
            var input = "2 + 3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("2_3/4", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndFraction()
        {
            var input = "2_1/4 + 1/2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("2_3/4", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndWholeNumber()
        {
            var input = "2_1/2 + 2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("4_1/2", output);
        }
    }

    [TestClass]
    public class Subtraction
    {
        [TestMethod]
        public void WholeNumbers()
        {
            var input = "2 - 3";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("-1", output);
        }

        [TestMethod]
        public void ImproperFraction()
        {
            var input = "9/2 - 1/5";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("4_3/10", output);
        }

        [TestMethod]
        public void FractionDoubleDigit()
        {
            var input = "1/2 - 31/81";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("19/162", output);
        }

        [TestMethod]
        public void Fraction()
        {
            var input = "1/2 - 3/8";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1/8", output);
        }

        [TestMethod]
        public void Multiple_Fractions()
        {
            var input = "2/3 - 3/4 - 30/90";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("-5/12", output);
        }

        [TestMethod]
        public void Multiple_WholeNumberWithFractions()
        {
            var input = "4_1/2 - 3_3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("3/4", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberAndFraction()
        {
            var input = "2 - 3/4";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_1/4", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndFraction()
        {
            var input = "2_1/4 - 1/2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1_3/4", output);
        }

        [TestMethod]
        public void Mixed_WholeNumberWithFractionAndWholeNumber()
        {
            var input = "2_1/2 - 2";
            var output = Program.CalculateOperations(input);

            Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod() + "  - " + output);

            Assert.AreEqual("1/2", output);
        }
    }
    
}
