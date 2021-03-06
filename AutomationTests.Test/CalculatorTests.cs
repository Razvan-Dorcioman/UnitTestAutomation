﻿using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTests.Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void isDigit_isDigit()
        {
            // given
            var str = '5';
            // when
            var result = _calculator.isDigit(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void isDigit_lowerBound()
        {
            // given
            var str = '0';
            // when
            var result = _calculator.isDigit(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void isDigit_upperBound()
        {
            // given
            var str = '9';
            // when
            var result = _calculator.isDigit(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void isDigit_outOfLowerBound()
        {
            // given
            var str = '/';
            // when
            var result = _calculator.isDigit(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void isDigit_outOfUpperBound()
        {
            // given
            var str = ':';
            // when
            var result = _calculator.isDigit(str);
            // then
            Assert.IsFalse(result);
        }

        /// <summary>
        ///     /////////////////////////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateConsistency_strIsEmpty()
        {
            // given
            var str = "";
            // when
            var result = _calculator.validateConsistency(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateConsistency_strHasAnythingButDigitOrOperator()
        {
            // given
            var str = "a;`bc?~";
            // when
            var result = _calculator.validateConsistency(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateConsistency_strHasDigitAndOperatorPlusOther()
        {
            // given
            var str = "1+?~";
            // when
            var result = _calculator.validateConsistency(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateConsistency_strHasOnlyDigitAndOperator()
        {
            // given
            var str = "1+12-6/2*3***+++---///";
            // when
            var result = _calculator.validateConsistency(str);
            // then
            Assert.IsTrue(result);
        }


        /// <summary>
        ///     /////////////////////////////////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strIsEmpty()
        {
            // given
            var str = "";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasOnePlusOperatorOnly()
        {
            // given
            var str = "+";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasOneMinusOperatorOnly()
        {
            // given
            var str = "-";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasOneMultiplyOperatorOnly()
        {
            // given
            var str = "*";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasOneDivisionOperatorOnly()
        {
            // given
            var str = "/";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasPlusOperatorFollowedByDigit()
        {
            // given
            var str = "+1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasMinusOperatorFollowedByDigit()
        {
            // given
            var str = "-1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasMultiplyOperatorFollowedByDigit()
        {
            // given
            var str = "*1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasDivisionOperatorFollowedByDigit()
        {
            // given
            var str = "/1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitFollowedByPlusOperator()
        {
            // given
            var str = "1+";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitFollowedByMinusOperator()
        {
            // given
            var str = "1-";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitFollowedByMultiplyOperator()
        {
            // given
            var str = "1*";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitFollowedByDivisionOperator()
        {
            // given
            var str = "1/";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitPlusDigit()
        {
            // given
            var str = "1+1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitMinusDigit()
        {
            // given
            var str = "1-1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitMultiplyDigit()
        {
            // given
            var str = "1*1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void validateOperationSigns_strHasDigitDivideDigit()
        {
            // given
            var str = "1/1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsTrue(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasDuplicatedPlusOperator()
        {
            // given
            var str = "1++1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasDuplicatedMinusOperator()
        {
            // given
            var str = "1--1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasDuplicatedMultiplyOperator()
        {
            // given
            var str = "1**1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void validateOperationSigns_strHasDuplicatedDivisionOperator()
        {
            // given
            var str = "1//1";
            // when
            var result = _calculator.validateOperationSigns(str);
            // then
            Assert.IsFalse(result);
        }


        /// <summary>
        ///     /////////////////////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void processOperands_indexOfOperatorIsNotForAnOperator()
        {
            // given
            var str = "1+2";
            var expected = "1+2";
            var indexOfOperator = 0;
            // when
            var actual = _calculator.processOperands(indexOfOperator, str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void processOperands_plusOperatorFollowedByDigit()
        {
            // given
            var str = "+1";
            var expected = "1";
            // when
            var actual = _calculator.processOperands(0, str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void processOperands_minusOperatorFollowedByDigit()
        {
            // given
            var str = "-1";
            var expected = "-1";
            // when
            var actual = _calculator.processOperands(0, str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void processOperands_minusOneMinusOne()
        {
            // given
            var str = "-1-1";
            var expected = "-2";
            // when
            var actual = _calculator.processOperands(2, str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void processOperands_oneMinusOne()
        {
            // given
            var str = "1-1";
            var expected = "0";
            // when
            var actual = _calculator.processOperands(1, str);
            // then
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///     /////////////////////////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void calculateMultiplyAndDivideInOrderTest()
        {
            // given
            var str = "-4*2/2*3+1";
            var expected = "0-12+1";

            // when
            var actual = _calculator.calculateMultiplyAndDivideInOrder(str);

            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void calculateSumAndSubstractInOrder_OnePlusTwoPlusThree()
        {
            // given
            var str = "1+2+3";
            var expected = "6";
            // when
            var actual = _calculator.calculateSumAndSubstractInOrder(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void calculateSumAndSubstractInOrder_MinusOneMinusTwoMinusThree()
        {
            // given
            var str = "-1-2-3";
            var expected = "-6";
            // when
            var actual = _calculator.calculateSumAndSubstractInOrder(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void calculateSumAndSubstractInOrder_MinusThenPlus()
        {
            // given
            var str = "-1+2";
            var expected = "1";
            // when
            var actual = _calculator.calculateSumAndSubstractInOrder(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void calculateSumAndSubstractInOrder_OnlyPositiveNumber()
        {
            // given
            var str = "123";
            var expected = "123";
            // when
            var actual = _calculator.calculateSumAndSubstractInOrder(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void calculateSumAndSubstractInOrder_OnlyNegativeNumber()
        {
            // given
            var str = "-123";
            var expected = "-123";
            // when
            var actual = _calculator.calculateSumAndSubstractInOrder(str);
            // then
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///     ////////////////////////////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void calculateBasic_hasEmptyString()
        {
            // given
            var str = "";
            var expected = "Invalid expression";
            // when
            var actual = _calculator.calculateBasic(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void calculateBasic_hasInvalidConsistency()
        {
            // given
            var str = ";";
            var expected = "Invalid expression";
            // when
            var actual = _calculator.calculateBasic(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void calculateBasic_hasInvalidOperationSigns()
        {
            // given
            var str = ";";
            var expected = "Invalid expression";
            // when
            var actual = _calculator.calculateBasic(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("WhiteBox")]
        public void calculateBasic_hasInvalidConsistencyAndOperationSigns()
        {
            // given
            var str = ";+";
            var expected = "Invalid expression";
            // when
            var actual = _calculator.calculateBasic(str);
            // then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Owner("Ciprian Ghenceanu")]
        [TestCategory("BlackBox")]
        public void calculateBasic()
        {
            // given
            var str = "-1+2*3+4-1*2*3-4/2*8*2";
            var expected = "-29";
            // when
            var actual = _calculator.calculateBasic(str);
            // then
            Assert.AreEqual(expected, actual);
        }
    }
}