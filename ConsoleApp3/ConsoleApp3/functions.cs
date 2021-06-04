using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class functions
    {
        //check the char is Arithmatic Operator
        public static bool isArithmaticOperator(char tooken)
        {
            return tooken == '+' || tooken == '*';
        }
        //check the char is Tooken Delimiter         
        public static bool isTookenDelimiter(char tooken)
        {
            return tooken == '#';
        }
        //check the char is Start Sympol 
        public static bool isStartSympol(char tooken)
        {
            return tooken == '@';
        }
        //check the char is End Sympol
        public static bool isEndSympol(char tooken)
        {
            return tooken == '$';
        }
        //check the char is Assiment Operator 
        public static bool isAssimentOperator(char tooken)
        {
            return tooken == '=';
        }
        //check the char is Braces
        public static bool isBraces(char tooken)
        {
            return tooken == '[' || tooken == ']' || tooken == '{' || tooken == '}' || tooken == '(' || tooken == ')';
        }
        //check the char is Quatation Mark
        public static bool isQuatationMark(char tooken)
        {
            return tooken == '\"' || tooken == '\'' || tooken == ',';
        }
        //check the char is Line Delimiter
        public static bool isLineDelimiter(char tooken)
        {
            return tooken == '^'|| tooken == '.';
        }
        //check the char is Logical Operator
        public static bool isLogicalOperator(char tooken)
        {
            return tooken == '~';
        }
        //check the char is Relational Operator
        public static bool isRelationalOperator(char tooken)
        {
            return tooken == '<' || tooken == '>';
        }
        //check the string is Logical Operator
        public static bool isLogicalOperator(String tooken)
        {
            return tooken == "||" || tooken == "&&";
        }
        //check the string is Relational Operator
        public static bool isRelationalOperator(String tooken)
        {
            return tooken == "=<" || tooken == "=>" || tooken == "==" || tooken == "!=";
        }
        //check the String is Access Operator
        public static bool isAccessOperator(String tooken)
        {
            return tooken == "->";
        }
        //check the string is Start Comment
        public static bool isStartComment(String tooken)
        {
            return tooken == "/-";
        }
        //check the string is End Comment
        public static bool isEndComment(String tooken)
        {
            return tooken == "-/";
        }
        //check the String is Comment
        public static bool isComment(String tooken)
        {
            return tooken == "--";
        }
        //check the char is Digit
        public static bool isDigit(char tooken)
        {
            return tooken == '0' || tooken == '1' || tooken == '2' || tooken == '3'
                   || tooken == '4' || tooken == '5' || tooken == '6' || tooken == '7'
                   || tooken == '8' || tooken == '9';
        }
        public static bool isAlphapet(char tooken)
        {
            return (tooken >= 'a' && tooken <= 'z') || (tooken >= 'A' && tooken <= 'Z');

        }

          
    }
}
