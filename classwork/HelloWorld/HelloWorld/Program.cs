/*
 * File Header
 * Luisalberto Castaneda
 * ITSE 1430 Fall 2021
 */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
        {
            static void DemoLogicalOperators()
            {
                // Logical AND - true if both are true
                // Logical OR - true if either is true
                //     X    Y    &&   ||
                //  -----------------------
                //     F    F    F     F
                //     F    T    F     T
                //     T    F    F     T
                //     T    T    T     T
                //

                // NOT 
                //     F  !F  = T
                //     T  !T  = F

            }

            static void DemoRelationalOperators()
            {
                int x = 10, y = 20;

                bool isLessThen = x < y;
                bool isLessThenOrEqualTo = x <= y;

                bool isGreaterThen = x > y;
                bool isLessGreaterOrEqualTo = x >= y;

                bool isEqual = x == y;
                bool isNotEqual = x != y;

            }

            static void DemoCombinationOperators ()
            {
                // works for more than just arithmetic
                int x = 10;

                x += 10;    // x = x + 10
                x-= 20;     // x = x - 20
                x *= 3;     // x = x * 3
                x /= 5;     // x = x / 5
                x %= 2;     // x = x % 2
            }

            static void DemoPrefixPostfixOperators ()
            {
                int x = 10, y;

                // Prefix Increment
                //  1. Take current value of x and increment by 1
                //  2. Store new value back to x
                //  3. Expression value is current of x
                y = ++x; // x = 11, y = 11

                // Prefix decrement
                //  1. Take current value of x and decrement by 1
                //  2. Store new value back to x
                //  3. Expression value is current of x
                y = --x; // x = 10 , y = 10

                // Postfix Increment
                //  1. Take current value of x and increment by 1
                //  2. Store new value back to x
                //  3. Expression value is current of temp (orginal value of x)
                y = x++;

                // Postfix Decrement
                //  1. Take current value of x and Decrement by 1
                //  2. Store new value back to x
                //  3. Expression value is current of temp (orginal value of x)
                y = x--;
            }

            static void DemoAssignmentOperator ()
            {
                int x;
                int y;
                int z;

                x = 10;
                y = 10;
                z = 10;

                // left assoiciative (E1 op E2) => E1, E2, op
                // right associative operator (E1 op E2) => E2, E1, op

                x = y = z = 20; // x = (y = (z = 20));
            }

            static void ConditionalOperator ()
            {
                int grade = 70;
                string passStatus;

                if (grade < 60)
                    passStatus = "Not Passing";
                else
                    passStatus = "Passing";

                // Terninary - 3 operands
                // E(bool) ? E(true) : E(false)

                string passStatus2 = (grade > 60) ? "Not Passing" : "Passing";
            }

            static void DemoString ()
            {
                string firstName = "Bob";

                // relationals work, case sensitive
                bool isbob = firstName == "Bob";

                // String Literals
                string literal1 = "Hello World";

                // Escape Sequence - \? only work in literals
                // \n => newline
                // \t => horizontal tab
                // \\ => slash
                // \" => double quote
                // \' character literal, single quote
                literal1 = "Hello \nWorld";
                string quoteString = "Hello \"Bob\"";
                
                string filePath = "C:\\windows\\system32\\tasks";
                string verbatimString = @"C:\windows\system32\tasks";

                // String length .Length => how many Characters
                int length = literal1.Length;

                // Empty String
                string emptyString = ""; // length = 0
                string emptyString2 = String.Empty; // length = 0
                bool areEmptyStringsEqual = String.Empty == ""; // True

                // null != empty string
                // Default value for strings is null
                string nullString = null;
                bool areEqualNull = "" == null; // False

                // string is the universal type in c#
                // all expressions are convertable to string using .ToString
                string asString = length.ToString(); // legnth as a string
                asString = 10.ToString(); // "10"
                asString = areEqualNull.ToString(); // "False"
            }
        } // do not pass go
    }
}
