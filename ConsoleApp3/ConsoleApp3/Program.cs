using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            keywords[] keyWord;
            keyWord = new keywords[30];
            keyWord[0] = new keywords("Ity", "Integer");
            keyWord[1] = new keywords("Cwq", "Character");
            keyWord[2] = new keywords("Pattern", "Class");
            keyWord[3] = new keywords("Truefor", "Condition");
            keyWord[4] = new keywords("Logical", "Boolean");
            keyWord[5] = new keywords("Require", "Inclusion");
            keyWord[6] = new keywords("DerivedFrom", "Inheritance");
            keyWord[7] = new keywords("CwqSequence", "String");
            keyWord[8] = new keywords("RespondWith", "Return");
            keyWord[9] = new keywords("ConditionOf", "Switch");
            keyWord[10] = new keywords("Else", "Condition");
            keyWord[11] = new keywords("Sity", "Sinteger");
            keyWord[12] = new keywords("Srap", "Struct");
            keyWord[13] = new keywords("Scan", "Switch");
            keyWord[14] = new keywords("IfIty", "Float");
            keyWord[15] = new keywords("SIfIty", "SFloat");
            keyWord[16] = new keywords("Whatever", "Loop");
            keyWord[17] = new keywords("Valueless", "Void");
            keyWord[18] = new keywords("BreakFromThis", "Break");
            /*   //define keyWords with using array of class keyword that have 7 character
               keywords[] keyWord7Char;
               keyWord7Char = new keywords[4];
               keyWord7Char[0] = new keywords("Pattern", "Class");
               keyWord7Char[1] = new keywords("Truefor", "Condition");
               keyWord7Char[2] = new keywords("Logical", "Boolean");
               keyWord7Char[3] = new keywords("Require", "Inclusion");


               //define keyWords with using array of class keyword that have 11 character
               keywords[] keyWord11Char;
               keyWord11Char = new keywords[4];
               keyWord11Char[0] = new keywords("DerivedFrom", "Inheritance");
               keyWord11Char[1] = new keywords("CwqSequence", "String");
               keyWord11Char[2] = new keywords("RespondWith", "Return");
               keyWord11Char[3] = new keywords("ConditionOf", "Switch");

               //define keyWords with using array of class keyword that have 4 character
               keywords[] keyWord4Char;
               keyWord4Char = new keywords[4];
               keyWord4Char[0] = new keywords("Else", "Condition");
               keyWord4Char[1] = new keywords("Sity", "Sinteger");
               keyWord4Char[2] = new keywords("Srap", "Struct");
               keyWord4Char[3] = new keywords("Scan", "Switch");



               //define keyWord that have 5 character
               keywords keyWord5Char = new keywords("IfIty", "Float");

               //define keyWord that have 6 character
               keywords keyWord6Char = new keywords("SIfIty", "SFloat");

               //define keyWord that have 8 character
               keywords keyWord8Char = new keywords("Whatever", "Loop");

               //define keyWord that have 9 character
               keywords keyWord9Char = new keywords("Valueless", "Void");

               //define keyWord that have 13 character
               keywords keyWord13Char = new keywords("BreakFromThis", "Break");
               */
            String s = "#@";
            Console.WriteLine(functions.isTookenDelimiter(s[0]));
            Console.WriteLine(functions.isTookenDelimiter(s[1]));
            StreamReader sR = new StreamReader("test.txt");
            //define line to read from file line by line 
            char line;
            int numberOfLine = 1;
            
            //define current to know where are in the line 
            
            //to know number of character in substring
            

            int numberOftoken = 1;
            string str = "";
            
            line = (char)sR.Read();
            do
            {
                
                str = "";
                if (functions.isAlphapet(line) || line == '_')
                {
                    str += line;
                    line = (char)sR.Read();
                    while (functions.isAlphapet(line) || functions.isDigit(line) || line == '_')
                    {

                        str += line;
                        line = (char)sR.Read();
                    }

                    for (int num = 0; num < 19; num++)
                    {
                        if (str == keyWord[num].keywordName)
                        {
                            Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + keyWord[num].keywordMeaning);
                            str = null;
                            break;
                        }
                    }
                    if (str != null)
                    {
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "Identifier");

                    }


                }
                else if (functions.isDigit(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    while (functions.isDigit(line))
                    {

                        str += line;
                        line = (char)sR.Read();
                    }
                    if (functions.isAlphapet(line) || line == '_')
                    {
                        while (functions.isAlphapet(line) || functions.isDigit(line) || line == '_')
                        {

                            str += line;
                            line = (char)sR.Read();
                        }
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "const");


                }//end of check digit
                //check Tooken Delimiter
                else if (functions.isTookenDelimiter(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "TookenDelimiter");
                }
                //check Braces
                else if (functions.isBraces(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "Braces");
                }
                //check ArithmaticOperator
                else if (functions.isArithmaticOperator(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "ArithmaticOperator");
                }
                //check StartSympol
                else if (functions.isStartSympol(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "StartSympol");
                }
                //check EndSympol
                else if (functions.isEndSympol(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "EndSympol");
                }
                //check QuatationMark
                else if (functions.isQuatationMark(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "QuatationMark");
                }
                //check LineDelimiter
                else if (functions.isLineDelimiter(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LineDelimiter");
                }
                //check LogicalOperator
                else if (functions.isLogicalOperator(line))
                {
                    str += line;
                    line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LogicalOperator");
                }
                //check "=" is assigmentOperator or relationalOperator
                else if (line == '=')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '=')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationaltOperator");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "AsignmentOperator");
                }
                //check "<" is relationalOperator
                else if (line == '<')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '=')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationaltOperator");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationalOperator");
                }
                //check ">" is relationalOperator
                else if (line == '>')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '=')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationaltOperator");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationalOperator");
                }
                //check "|" is LogicalOperator
                else if (line == '|')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '|')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LogicalOperator");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                }
                //check "&" is LogicalOperator
                else if (line == '&')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '&')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LogicalOperator");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                }
                //check "!" is LogicalOperator
                else if (line == '!')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '=')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationalOperator");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                }
                //check "-" is arithmaticOperator or comment or accesOperator 
                else if (line == '-')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '-')
                    {
                        str += line; line = (char)sR.Read();
                        while (line != '\r') { line = (char)sR.Read(); continue; }
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "comment");
                    }
                    else if (line == '>')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "AccessOperator");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "ArithmaticOperator");
                }
                //detecct last of line and spaces and ignore them
                else if (line == '\r' || line == ' ') { line = (char)sR.Read(); continue; }
                //detict new line                
                else if (line == '\n')
                {
                    line = (char)sR.Read();
                    numberOfLine++;
                    numberOftoken = 1;
                }
                //check multy line comments
                else if (line == '/')
                {
                    str += line;
                    line = (char)sR.Read();
                    if (line == '-')
                    {
                        str += line; line = (char)sR.Read();
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "MutiLinecomment");
                        str = "";
                        while (line != '-'&& (char)sR.Read()!='/') { line = (char)sR.Read(); continue; }
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + "-/" + "\t" + "MutiLinecomment");
                    }
                    else
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + "-/" + "\t" + "ArithmaticOperator");
                }
                else
                {
                    str += line; line = (char)sR.Read();
                    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                }
            } while (!sR.EndOfStream);
        }
    }
}

            //loop to read the file kine by line
            /*do
            {
                //read line
                line = (char)sR.Read();
                current = 0;
                //loop for exit whin array is finish
                if (line != '\n')
                {
                    //current = 0;


                    //check alphapet 
                    if (functions.isAlphapet(line) || line == '_')
                    {
                        str += line;
                        counter++;
                        //;oop for continue the word
                        //while (functions.isAlphapet(line[current]) || line[current] == '_' || functions.isDigit(line[current]))

                        //{
                            //str += line[current++];

                            counter++;
                    }
                        //check keywords
                        if (counter == 3)
                        {
                            for (int z = 0; z < 2; z++) { if (str == keyWord3Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord3Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 4)
                        {
                            for (int z = 0; z < 4; z++) { if (str == keyWord4Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord4Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 7)
                        {
                            for (int z = 0; z < 4; z++) { if (str == keyWord7Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord7Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 11)
                        {
                            for (int z = 0; z < 4; z++) { if (str == keyWord11Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord11Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 5)
                        {
                            if (str == keyWord5Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord5Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 6)
                        {
                            if (str == keyWord6Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord6Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 8)
                        {
                            if (str == keyWord8Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord8Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 9)
                        {
                            if (str == keyWord9Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord9Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier\n");
                        }
                        else if (counter == 13)
                        {
                            if (str == keyWord5Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord5Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        //the word is not keyword but is identifier
                        else
                        {
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier\n\n");
                            numberOftoken++;
                        }
                    }//end first if
                    //check else alphapet
                    else if (functions.isBraces(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "braces\n");
                    }
                    else if (functions.isArithmaticOperator(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "ArithmaticOperator\n");
                    }
                    else if (functions.isTookenDelimiter(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "TookenDelimiter\n");
                    }
                    else if (functions.isStartSympol(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "StartSympol\n");
                    }
                    else if (functions.isEndSympol(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "EndSympol\n");
                    }
                    else if (functions.isQuatationMark(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "QuatationMark\n");
                    }
                    else if (functions.isQuatationMark(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "QuatationMark\n");

                    }
                    else if (functions.isLineDelimiter(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "lineDelimiter\n");

                    }
                    else
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "error\n");
                    }
                }


                    Console.WriteLine(line+i);

           } while (line == null);
           
        }*/
            
