using CalcClass;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnalaizerClass
{
    public class Brain
    {
        private static string buffer = string.Empty;

        private static ArrayList bufferStack = new ArrayList();

        private static int erposition = 0;

        public static string expression = "";

        public static bool ShowMessage = true;

        #region Public methods
        public static bool CheckCurrency()
        {
            if (expression.Length > 65536)
            {
                HandleOverlongExpressionError();

                return false;
            }

            var bracketsAccordanceCounter = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    bracketsAccordanceCounter++;

                    if (bracketsAccordanceCounter > 3)
                    {
                        HandleWrongStructureInBracketsError(i);

                        return false;
                    }
                }
                else
                if (expression[i] == ')')
                {
                    if (bracketsAccordanceCounter > 0)
                    {
                        bracketsAccordanceCounter--;
                    }
                    else
                    {
                        HandleWrongSyntacticConstructionError(i);

                        return false;
                    }
                }
            }

            if (bracketsAccordanceCounter != 0)
            {
                HandleIncompleteExpressionError();

                return false;
            }

            return true;
        }
        
        public static string Format()
        {
            var outputBuilder = new StringBuilder();

            var lastReadSymbolType = SymbolType.Null;

            var lastWrittenSymbolType = SymbolType.Null;

            var isLastSpaceWritten = false;

            for (int i = 0; i < expression.Length; i++)
            {
                var isError = false;

                lastReadSymbolType = RecogniseSymbolType(expression, i);

                switch (lastReadSymbolType)
                {
                    case SymbolType.NotRecognised:
                        HandleUnknownOperatorError(i);

                        isError = true;

                        break;


                    case SymbolType.Number:
                        ProcessNumberDetected(i, outputBuilder,
                            ref lastWrittenSymbolType, ref isLastSpaceWritten, ref isError);

                        break;


                    case SymbolType.UnaryOperator:
                        ProcessUnaryOperatorDetected(i, outputBuilder,
                            ref lastWrittenSymbolType, ref isLastSpaceWritten, ref isError);

                        break;


                    case SymbolType.BinaryOperator:
                        ProcessBinaryOperatorDetected(i, outputBuilder,
                            ref lastWrittenSymbolType, ref isLastSpaceWritten, ref isError);

                        break;


                    case SymbolType.ModOperator:
                        ProcessModOperatorDetected(i, outputBuilder,
                            ref lastWrittenSymbolType, ref isLastSpaceWritten, ref isError);

                        // After incrementation in for-loop, 'mod' must be behind index 'i'.
                        i += 2;

                        break;


                    case SymbolType.OpeningBracket:
                        ProcessOpeningBracketDetected(i, outputBuilder,
                            ref lastWrittenSymbolType, ref isLastSpaceWritten, ref isError);

                        break;


                    case SymbolType.ClosingBracket:
                        ProcessClosingBracketDetected(i, outputBuilder,
                            ref lastWrittenSymbolType, ref isLastSpaceWritten, ref isError);

                        break;


                    case SymbolType.Space:
                        ProcessSpaceDetected(i, outputBuilder,
                            lastWrittenSymbolType, ref isLastSpaceWritten);

                        break;
                }
                
                if (isError)
                {
                    return string.Format("&{0}", buffer);
                }
            }

            if (lastWrittenSymbolType == SymbolType.UnaryOperator
                || lastWrittenSymbolType == SymbolType.BinaryOperator
                || lastWrittenSymbolType == SymbolType.ModOperator)
            {
                HandleIncompleteExpressionError();

                return string.Format("&{0}", buffer);
            }

            buffer = outputBuilder.ToString().TrimEnd();

            return buffer;
        }
        
        public static ArrayList CreateStack()
        {
            var output = new ArrayList();

            var stack = new Stack<string>();

            var tokens = buffer.Split(' ');

            for (int i = 0; i < tokens.Length; i++)
            {
                long number;
                if (long.TryParse(tokens[i], out number))
                {
                    output.Add(number);

                    continue;
                }

                int tokenOperatorPriority;
                if(IsOperator(tokens[i], out tokenOperatorPriority))
                {
                    if (stack.Count > 0 && stack.Peek() != "(")
                    {
                        int stackOperatorPriority;
                        while (IsOperator(stack.Peek(), out stackOperatorPriority))
                        {
                            if (stackOperatorPriority > tokenOperatorPriority)
                            {
                                break;
                            }
                            else
                            {
                                output.Add(stack.Pop());

                                if (stack.Count < 1)
                                {
                                    break;
                                }
                            }
                        }
                    }

                    stack.Push(tokens[i]);

                    continue;
                }

                if (tokens[i] == "(")
                {
                    stack.Push(tokens[i]);

                    continue;
                }

                if (tokens[i] == ")")
                {
                    while (stack.Peek() != "(")
                    {
                        output.Add(stack.Pop());
                    }

                    stack.Pop();
                }
            }

            while (stack.Count > 0)
            {
                output.Add(stack.Pop());
            }

            return output;
        }

        public static string RunEstimate()
        {
            var stack = new Stack<long>();

            for (int i = 0; i < bufferStack.Count; i++)
            {
                var element = bufferStack[i].ToString();

                long number;
                if (long.TryParse(element, out number))
                {
                    stack.Push(number);
                }
                else
                // If element is unary operator.
                if (element == "p" || element == "m")
                {
                    var result = ExecuteUnaryOperator(element, stack.Pop());

                    stack.Push(result);
                }
                else
                // If element is binary operator.
                if (element == "+" || element == "-" || element == "*" || element == "/" || element == "mod")
                {
                    var rightOperand = stack.Pop();

                    var result = ExecuteBinaryOperator(element, stack.Pop(), rightOperand);

                    stack.Push(result);
                }
            }
            
            return stack.Pop().ToString();
        }

        public static string Estimate()
        {
            var isValid = CheckCurrency();

            if (!isValid)
            {
                return ReturnError();
            }

            var result = Format();

            if (result[0] == '&')
            {
                return ReturnError();
            }

            bufferStack = CreateStack();

            if (bufferStack.Count > 30)
            {
                HandleOvermuchNumbersAndOperatorsError();

                return ReturnError();
            }

            result = RunEstimate();

            if (!string.IsNullOrEmpty(Math.lastError))
            {
                return ReturnError(Math.lastError);
            }

            return result;
        }
        #endregion

        #region Private methods
        private static SymbolType RecogniseSymbolType(string symbols, int index)
        {
            if (char.IsDigit(symbols[index]))
            {
                return SymbolType.Number;
            }
            else
            if (IsBinaryOperator(symbols[index]))
            {
                return SymbolType.BinaryOperator;
            }
            else
            if (IsModOperator(symbols, index))
            {
                return SymbolType.ModOperator;
            }
            else
            if (IsUnaryOperator(symbols[index]))
            {
                return SymbolType.UnaryOperator;
            }
            else
            if (symbols[index] == '(')
            {
                return SymbolType.OpeningBracket;
            }
            else
            if (symbols[index] == ')')
            {
                return SymbolType.ClosingBracket;
            }
            else
            if (symbols[index] == ' ')
            {
                return SymbolType.Space;
            }

            return SymbolType.NotRecognised;
        }

        private static bool IsBinaryOperator(char symbol)
        {
            var isBinaryOperator = symbol == '+'
                || symbol == '-'
                || symbol == '*'
                || symbol == '/';

            return isBinaryOperator;
        }

        private static bool IsModOperator(string symbols, int index)
        {
            var isModOperator = symbols.Length > index + 2
                && symbols.Substring(index, 3) == "mod";

            return isModOperator;
        }

        /// <summary>
        /// Must be called after method 'IsModOperator'.
        /// In other cases, there is could be wrong return value.
        /// Operators 'm' and 'mod' has the same first symbol.
        /// </summary>
        private static bool IsUnaryOperator(char symbol)
        {
            var isUnaryOperator = symbol == 'p'
                || symbol == 'm';

            return isUnaryOperator;
        }

        private static bool IsOperator(string token, out int priority)
        {
            var isOperator = token == "p"
                || token == "m";

            if (isOperator)
            {
                priority = 1;

                return true;
            }

            isOperator = token == "*"
                || token == "/"
                || token == "mod";

            if (isOperator)
            {
                priority = 2;

                return true;
            }

            isOperator = token == "+"
                || token == "-";

            if (isOperator)
            {
                priority = 3;

                return true;
            }

            priority = 0;

            return false;
        }

        private static string ReturnError()
        {
            return ReturnError(buffer);
        }

        private static string ReturnError(string error)
        {
            return ShowMessage
                ? error
                : "Error. For more details contact your administrator.";
        }

        #region Symbol processors
        private static void ProcessNumberDetected(int index, StringBuilder outputBuilder,
            ref SymbolType lastWrittenSymbolType, ref bool isLastSpaceWritten, ref bool isError)
        {
            switch (lastWrittenSymbolType)
            {
                case SymbolType.Null:
                    outputBuilder.Append(expression[index]);

                    break;


                case SymbolType.Number:
                    if (isLastSpaceWritten)
                    {
                        HandleWrongSyntacticConstructionError(index);

                        isError = true;

                        return;
                    }
                    else
                    {
                        outputBuilder.Append(expression[index]);

                        break;
                    }


                case SymbolType.UnaryOperator:
                case SymbolType.BinaryOperator:
                case SymbolType.ModOperator:
                case SymbolType.OpeningBracket:
                    if (isLastSpaceWritten)
                    {
                        outputBuilder.Append(expression[index]);

                        isLastSpaceWritten = false;
                    }
                    else
                    {
                        outputBuilder.Append($" {expression[index]}");
                    }

                    break;


                case SymbolType.ClosingBracket:
                    HandleWrongSyntacticConstructionError(index);

                    isError = true;

                    return;
            }

            lastWrittenSymbolType = SymbolType.Number;
        }

        private static void ProcessUnaryOperatorDetected(int index, StringBuilder outputBuilder,
            ref SymbolType lastWrittenSymbolType, ref bool isLastSpaceWritten, ref bool isError)
        {
            switch (lastWrittenSymbolType)
            {
                case SymbolType.Null:
                    outputBuilder.Append(expression[index]);

                    break;


                case SymbolType.Number:
                case SymbolType.UnaryOperator:
                case SymbolType.BinaryOperator:
                case SymbolType.ModOperator:
                case SymbolType.OpeningBracket:
                    if (isLastSpaceWritten)
                    {
                        outputBuilder.Append(expression[index]);

                        isLastSpaceWritten = false;
                    }
                    else
                    {
                        outputBuilder.Append($" {expression[index]}");
                    }

                    break;


                case SymbolType.ClosingBracket:
                    HandleWrongStructureInBracketsError(index);

                    isError = true;

                    return;
            }

            lastWrittenSymbolType = SymbolType.UnaryOperator;
        }

        private static void ProcessBinaryOperatorDetected(int index, StringBuilder outputBuilder,
            ref SymbolType lastWrittenSymbolType, ref bool isLastSpaceWritten, ref bool isError)
        {
            switch (lastWrittenSymbolType)
            {
                case SymbolType.Null:
                    HandleWrongSyntacticConstructionError(index);

                    isError = true;

                    return;


                case SymbolType.Number:
                case SymbolType.ClosingBracket:
                    if (isLastSpaceWritten)
                    {
                        outputBuilder.Append(expression[index]);

                        isLastSpaceWritten = false;
                    }
                    else
                    {
                        outputBuilder.Append($" {expression[index]}");
                    }

                    break;


                case SymbolType.UnaryOperator:
                case SymbolType.BinaryOperator:
                case SymbolType.ModOperator:
                    HandleTwoConsecutiveOperatorsError(index);

                    isError = true;

                    return;


                case SymbolType.OpeningBracket:
                    HandleWrongStructureInBracketsError(index);

                    isError = true;

                    return;
            }

            lastWrittenSymbolType = SymbolType.BinaryOperator;
        }

        private static void ProcessModOperatorDetected(int index, StringBuilder outputBuilder,
            ref SymbolType lastWrittenSymbolType, ref bool isLastSpaceWritten, ref bool isError)
        {
            switch (lastWrittenSymbolType)
            {
                case SymbolType.Null:
                    HandleWrongSyntacticConstructionError(index);

                    isError = true;

                    return;


                case SymbolType.Number:
                case SymbolType.ClosingBracket:
                    if (isLastSpaceWritten)
                    {
                        outputBuilder.Append("mod");

                        isLastSpaceWritten = false;
                    }
                    else
                    {
                        outputBuilder.Append($" mod");
                    }

                    break;


                case SymbolType.UnaryOperator:
                case SymbolType.BinaryOperator:
                case SymbolType.ModOperator:
                    HandleTwoConsecutiveOperatorsError(index);

                    isError = true;

                    return;


                case SymbolType.OpeningBracket:
                    HandleWrongStructureInBracketsError(index);

                    isError = true;

                    return;
            }

            lastWrittenSymbolType = SymbolType.ModOperator;
        }

        private static void ProcessOpeningBracketDetected(int index, StringBuilder outputBuilder,
            ref SymbolType lastWrittenSymbolType, ref bool isLastSpaceWritten, ref bool isError)
        {
            switch (lastWrittenSymbolType)
            {
                case SymbolType.Null:
                    outputBuilder.Append(expression[index]);

                    break;


                case SymbolType.Number:
                case SymbolType.UnaryOperator:
                case SymbolType.ClosingBracket:
                    HandleWrongSyntacticConstructionError(index);

                    isError = true;

                    return;


                case SymbolType.BinaryOperator:
                case SymbolType.ModOperator:
                case SymbolType.OpeningBracket:
                    if (isLastSpaceWritten)
                    {
                        outputBuilder.Append(expression[index]);

                        isLastSpaceWritten = false;
                    }
                    else
                    {
                        outputBuilder.Append($" {expression[index]}");
                    }

                    break;
            }

            lastWrittenSymbolType = SymbolType.OpeningBracket;
        }

        private static void ProcessClosingBracketDetected(int index, StringBuilder outputBuilder,
            ref SymbolType lastWrittenSymbolType, ref bool isLastSpaceWritten, ref bool isError)
        {
            switch (lastWrittenSymbolType)
            {
                case SymbolType.Number:
                case SymbolType.ClosingBracket:
                    if (isLastSpaceWritten)
                    {
                        outputBuilder.Append(expression[index]);

                        isLastSpaceWritten = false;
                    }
                    else
                    {
                        outputBuilder.Append($" {expression[index]}");
                    }

                    break;


                case SymbolType.UnaryOperator:
                case SymbolType.BinaryOperator:
                case SymbolType.ModOperator:
                case SymbolType.OpeningBracket:
                    HandleWrongStructureInBracketsError(index);

                    isError = true;

                    return;
            }

            lastWrittenSymbolType = SymbolType.ClosingBracket;
        }

        private static void ProcessSpaceDetected(int index, StringBuilder outputBuilder,
            SymbolType lastWrittenSymbolType, ref bool isLastSpaceWritten)
        {
            if (isLastSpaceWritten)
            {
                return;
            }

            switch (lastWrittenSymbolType)
            {
                case SymbolType.Null:
                    return;

                case SymbolType.Number:
                case SymbolType.UnaryOperator:
                case SymbolType.BinaryOperator:
                case SymbolType.ModOperator:
                case SymbolType.OpeningBracket:
                case SymbolType.ClosingBracket:
                    outputBuilder.Append(expression[index]);

                    break;
            }

            isLastSpaceWritten = true;
        }
        #endregion

        #region Error handlers
        /// <summary>
        /// Error #1.
        /// </summary>
        private static void HandleWrongStructureInBracketsError(int index)
        {
            // index: index, position: i + 1.
            erposition = index + 1;

            buffer = string.Format("Error 01 at {0} - Неправильна структура в дужках, помилка на {0} символі.", erposition);
        }

        /// <summary>
        /// Error #2.
        /// </summary>
        private static void HandleUnknownOperatorError(int index)
        {
            // index: index, position: i + 1.
            erposition = index + 1;

            buffer = string.Format("Error 2 - Невідомий оператор на {0} символі.", erposition);
        }

        /// <summary>
        /// Error #3.
        /// </summary>
        private static void HandleWrongSyntacticConstructionError(int index)
        {
            // index: index, position: i + 1.
            erposition = index + 1;

            buffer = "Error 03 - Невірна синтаксична конструкція вхідного виразу.";
        }

        /// <summary>
        /// Error #4.
        /// </summary>
        private static void HandleTwoConsecutiveOperatorsError(int index)
        {
            // index: index, position: i + 1.
            erposition = index + 1;

            buffer = string.Format("Error 04 at {0} - Два підряд оператори на {0} символі.", erposition);
        }

        /// <summary>
        /// Error #5.
        /// </summary>
        private static void HandleIncompleteExpressionError()
        {
            // index: expresion.Length, position: expresion.Length.
            erposition = expression.Length;

            buffer = "Error 05 - Незавершений вираз.";
        }

        /// <summary>
        /// Error #7.
        /// </summary>
        private static void HandleOverlongExpressionError()
        {
            // index: expresion.Length, position: expresion.Length.
            erposition = expression.Length;

            buffer = "Error 07 - Дуже довгий вираз. Максмальна довжина - 65536 символів.";
        }

        /// <summary>
        /// Error #8.
        /// </summary>
        private static void HandleOvermuchNumbersAndOperatorsError()
        {
            // index: expresion.Length, position: expresion.Length.
            erposition = expression.Length;

            buffer = "Error 08 - Сумарна кількість чисел і операторів перевищує 30.";
        }
        #endregion

        #region Operator executors
        private static int ExecuteUnaryOperator(string element, long input)
        {
            // There are only two unary operators: "m" and "p".
            var result = element == "m"
                ? Math.IABS(input)
                : Math.ABS(input);

            return result;
        }

        private static int ExecuteBinaryOperator(string element, long leftOperand, long rightOperand)
        {
            int result = 0;

            switch (element)
            {
                case "+":
                    result = Math.Add(leftOperand, rightOperand);
                    break;

                case "-":
                    result = Math.Sub(leftOperand, rightOperand);
                    break;

                case "*":
                    result = Math.Mult(leftOperand, rightOperand);
                    break;

                case "/":
                    result = Math.Div(leftOperand, rightOperand);
                    break;

                case "mod":
                    result = Math.Mod(leftOperand, rightOperand);
                    break;
            }

            return result;
        }
        #endregion
        #endregion

        private enum SymbolType
        {
            Null = 0,
            NotRecognised = 9,
            Number = 11,
            UnaryOperator = 23,
            BinaryOperator = 24,
            ModOperator = 25,
            OpeningBracket = 67,
            ClosingBracket = 68,
            Space = 99,
        }
    }
}