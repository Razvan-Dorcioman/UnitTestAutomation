using System;
using System.Linq;

namespace AutomationTests
{
    public class Calculator
    {
        private readonly char[] multiplyAndDivideOperators = {'*', '/'};
        private readonly char[] operators;
        private readonly char[] sumAndSubstractOperators = {'+', '-'};

        public Calculator()
        {
            operators = sumAndSubstractOperators.Concat(multiplyAndDivideOperators).ToArray();
        }

        // expression validation
        public bool validateConsistency(string str)
        {
            if (str.Length == 0) return false;
            for (var i = 0; i < str.Length; i++)
            {
                var actualChar = str.ElementAt(i);
                if (!(isDigit(actualChar) || operators.Contains(actualChar))) return false;
            }

            return true;
        }

        public bool validateOperationSigns(string str)
        {
            if (str.Length == 0) return false;
            for (var i = 0; i < str.Length; i++)
            {
                var beforeChar = str.ElementAtOrDefault(i - 1);
                var actualChar = str.ElementAt(i);
                var afterChar = str.ElementAtOrDefault(i + 1);

                if (sumAndSubstractOperators.Contains(actualChar))
                    if (!(isDigit(beforeChar) && isDigit(afterChar) ||
                          '\0'.Equals(beforeChar) && isDigit(afterChar)))
                        return false;
                if (multiplyAndDivideOperators.Contains(actualChar))
                    if (!(isDigit(beforeChar) && isDigit(afterChar)))
                        return false;
            }

            return true;
        }

        // Util
        public bool isDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        // Process
        public string processOperands(int indexOfOperatorInStr, string str)
        {
            int a = 0, b = 0;
            var leftOpIndex = 0;
            var operatorInStr = str.ElementAtOrDefault(indexOfOperatorInStr);

            if (!operators.Contains(operatorInStr)) return str;

            if (multiplyAndDivideOperators.Contains(operatorInStr) &&
                sumAndSubstractOperators.Contains(str.ElementAt(0)))
            {
                str = "0" + str;
                indexOfOperatorInStr += 1;
            }

            try
            {
                leftOpIndex = str.LastIndexOfAny(operators, indexOfOperatorInStr - 1, indexOfOperatorInStr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                a = int.Parse(str.Substring(leftOpIndex + 1, indexOfOperatorInStr - leftOpIndex - 1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            var rightOpIndex =
                str.IndexOfAny(operators, indexOfOperatorInStr + 1, str.Length - indexOfOperatorInStr - 1);
            if (rightOpIndex == -1) rightOpIndex = str.Length;

            b = int.Parse(str.Substring(indexOfOperatorInStr + 1, rightOpIndex - indexOfOperatorInStr - 1));

            var result = 0;
            var leftOp = str.ElementAtOrDefault(leftOpIndex);

            switch (operatorInStr)
            {
                case '+':
                    if ('-'.Equals(leftOp))
                        result = -a + b;
                    else
                        result = a + b;
                    break;
                case '-':
                    if ('-'.Equals(leftOp))
                        result = -a - b;
                    else
                        result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
            }

            var partialResolved = "";

            try
            {
                partialResolved = str.Substring(0, leftOpIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (partialResolved != "")
                partialResolved += leftOp + result.ToString();
            else
                partialResolved += result.ToString();

            partialResolved += str.Substring(rightOpIndex, str.Length - rightOpIndex);

            return partialResolved;
        }

        public string calculateMultiplyAndDivideInOrder(string str)
        {
            var indexOfOperatorInStr = str.IndexOfAny(multiplyAndDivideOperators);

            while (indexOfOperatorInStr != -1)
            {
                str = processOperands(indexOfOperatorInStr, str);
                indexOfOperatorInStr = str.IndexOfAny(multiplyAndDivideOperators);
            }

            return str;
        }

        public string calculateSumAndSubstractInOrder(string str)
        {
            var strToSearchOperators = str;
            var result = strToSearchOperators;
            var indexOfOperatorInStr = strToSearchOperators.IndexOfAny(sumAndSubstractOperators);

            while (indexOfOperatorInStr != -1)
            {
                strToSearchOperators = processOperands(indexOfOperatorInStr, result);
                result = strToSearchOperators;
                indexOfOperatorInStr = strToSearchOperators.IndexOfAny(sumAndSubstractOperators);
                if (sumAndSubstractOperators.Contains(strToSearchOperators.ElementAtOrDefault(0)))
                {
                    strToSearchOperators = strToSearchOperators.Substring(1);
                    indexOfOperatorInStr = strToSearchOperators.IndexOfAny(sumAndSubstractOperators);
                    if (indexOfOperatorInStr != -1) indexOfOperatorInStr += 1;
                }
            }

            return result;
        }

        public string calculateBasic(string str)
        {
            if (!(validateConsistency(str) && validateOperationSigns(str))) return "Invalid expression";
            var result1 = calculateMultiplyAndDivideInOrder(str);
            return calculateSumAndSubstractInOrder(result1);
        }
    }
}