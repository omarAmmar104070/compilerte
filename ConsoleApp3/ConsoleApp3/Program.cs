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
            //define stremreader to read from file
            StreamReader sR = new StreamReader("test.txt");
            //define line to read from file char by char 
            char line;
            int numberOfLine = 1;
            int numberOftoken = 1;
            //define string to save the char array and chek is keyword or any thing else 
            string str = "";
            
            line = (char)sR.Read();
            do
            {
                
                str = "";
                //check keyword or identifier
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
                //check digit
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
                        str += line ; 
                        line = (char)sR.Read();
                       Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "StartMutiLinecomment");
                       
                        while (line != '-'&& (char)sR.Read()!='/') { if (line == '\n') numberOfLine++; line = (char)sR.Read();}
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + "-/" + "\t" + "EndMutiLinecomment");
                        line = (char)sR.Read(); line = (char)sR.Read(); continue;
                    }
                    else 
                        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + "/" + "\t" + "ArithmaticOperator");
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

            
            
