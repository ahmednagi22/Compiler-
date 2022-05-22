using Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
class LanguageParser
{
    static string[,] table = new string[45, 42];
    public static string[] input_splited;
    public static int indexOfInput = -1;
    public static string theNextWord;
    public static string topOfStack;
    static String[] terminals ={"STR","using","<","-","+","*","/","Number","ID","(",")",";","==","!=",
                     ">",">=","<=","terminatethis","Replywith","return","Continuewhen",
                     "Rotatewhen","and","or","if","{","}",",","Ilap","Silap","Clop",
                     "Series","Ilapf","Silapf","None","Logical","read","write","=",
                     "Category","Derive","$","End",".txt"
};
    static String[] nonTerminals ={"Program","Program`","ClassDeclaration","CD’","Class_Implementation","Var_Method","Var_Method`",
                       "MethodDeclaration","Me_Declaration","FuncDecl","Type","ParameterList","Non_Empty_List",
                       "Non_Empty_List`","VarDeclaration","ID_List","ID_List`","Statements","Statement",
                       "Assignment","Func_Call","Argument_List","NonEmpty_Argument_List","NonEmpty_Argument_List`",
                       "Block_Statements","If_Statement","Condition_Expression","Co_Expression","Condition_Op",
                       "Condition","Comparison_Op","Rotatewhen_Statement","Continuewhen_Statement",
                       "Replywith_Statement","terminatethis_Statement","Expression","Expression`","Add_Op",
                       "Term","Term`","Mul_Op","Factor","Comment","using_command","F_name"

 };
    public ArrayList parserOutput = new ArrayList();
    public LanguageParser(string input)
    {

        input_splited = input.Split(' ');
        Fill_ParseTable(ref table);
        parseStack stack = new parseStack();


        theNextWord = getNextWord();
        if (checkIfEqual(theNextWord, "Program"))
        {
            theNextWord = getNextWord();
        }
        else
        {
            parserOutput.Add("Missing start Program");
            return;
        }
        stack.Push("$");
        stack.Push("Program");
        do
        {
            topOfStack = stack.Pop();
            if (isNonTerminal(topOfStack))
            {
                String rule = getRule(topOfStack, theNextWord);
                String[] Rule = rule.Split(' ');
                for (int i = Rule.Length - 1; i >= 0; i--)
                {
                    stack.Push(Rule[i]);
                }

            }
            else if (isTerminal(topOfStack))
            {
                if (!(checkIfEqual(topOfStack, theNextWord)))
                {
                    parserOutput.Add("this token is not correct , By Grammer rule . Token : (" + theNextWord + ")");
                }
                else
                {
                    parserOutput.Add("Matching: Terminal :( " + theNextWord + " )");
                    theNextWord = getNextWord();
                    //top=pop();

                }
            }
            else
            {
                parserOutput.Add("Never Happens , Because top : ( " + topOfStack + " )");
                break;

            }
            if (checkIfEqual(theNextWord, "$"))
            {
                break;
            }



        } while (true);//out when reach $

        if (checkIfEqual(theNextWord, "$"))
        {
            parserOutput.Add("Input is Accepted by LL1");
        }
        else
        {
            parserOutput.Add("Input is not Accepted by LL1");
        }
    }
    public static void Fill_ParseTable(ref string[,] table)
    {
        for (int i = 0; i < 45; i++)
        {
            for (int j = 0; j < 42; j++)
            {
                table[i, j] = null;

            }
        }


        //Program
        table[0, 39] = "Program`";
        //Program`
        table[1, 39] = "ClassDeclaration End Program`";
        table[1, 41] = "";
        //ClassDeclaration
        table[2, 39] = "Category ID CD’";
        //CD`
        table[3, 40] = "Derive { Class_Implementation }";
        table[3, 25] = "{ Class_Implementation }";
        //Class_Implementation
        table[4, 1] = "using_command Class_Implementation";
        table[4, 2] = "Comment Class_Implementation";
        table[4, 3] = "Comment Class_Implementation";
        table[4, 8] = "Func _Call Class_Implementation";
        table[4, 26] = "";//empty
        table[4, 28] = "Type Var_Method Class_Implementation";
        table[4, 29] = "Type Var_Method Class_Implementation";
        table[4, 30] = "Type Var_Method Class_Implementation";
        table[4, 31] = "Type Var_Method Class_Implementation";
        table[4, 32] = "Type Var_Method Class_Implementation";
        table[4, 33] = "Type Var_Method Class_Implementation";
        table[4, 34] = "Type Var_Method Class_Implementation";
        table[4, 35] = "Type Var_Method Class_Implementation";
        //Var_Method
        table[5, 8] = "ID Var_Method`";
        //Var_Method `
        table[6, 9] = "MethodDeclaration";
        table[6, 27] = "ID_List ; VarDeclaration";
        //MethodDeclaration
        table[7, 9] = "Func_Decl  Me_Declaration";
        //Me_Declaration
        table[8, 11] = ";";
        table[8, 25] = "{VarDeclaration Statements}";
        //Func Decl
        table[9, 9] = "(ParameterList)";
        //Type
        table[10, 28] = "Ilap";
        table[10, 29] = "Silap";
        table[10, 30] = "Clop";
        table[10, 31] = "Series";
        table[10, 32] = "Ilapf";
        table[10, 33] = "Silapf";
        table[10, 34] = "None";
        table[10, 35] = "Logical";
        //ParameterList
        table[11, 10] = "+";//empty
        table[11, 28] = "Non_Empty_List";
        table[11, 29] = "Non_Empty_List";
        table[11, 30] = "Non_Empty_List";
        table[11, 31] = "Non_Empty_List";
        table[11, 32] = "Non_Empty_List";
        table[11, 33] = "Non_Empty_List";
        table[11, 34] = "Non_Empty_List";
        table[11, 35] = "Non_Empty_List";
        //Non-EmptyList
        table[12, 28] = "Type ID Non_Empty_List`";
        table[12, 29] = "Type ID Non_Empty_List`";
        table[12, 30] = "Type ID Non_Empty_List`";
        table[12, 31] = "Type ID Non_Empty_List`";
        table[12, 32] = "Type ID Non_Empty_List`";
        table[12, 33] = "Type ID Non_Empty_List`";
        table[12, 34] = "Type ID Non_Empty_List`";
        table[12, 35] = "Type ID Non_Empty_List`";
        //Non-EmptyList`
        table[13, 10] = "";
        table[13, 35] = ", Type ID Non_Empty_List`";
        //VarDeclaration
        table[14, 1] = "";
        table[14, 2] = "";
        table[14, 3] = "";
        table[14, 8] = "";
        table[14, 17] = "";
        table[14, 18] = "";
        table[14, 19] = "";
        table[14, 20] = "";
        table[14, 21] = "";
        table[14, 24] = "";
        table[14, 28] = "Type ID_List ; VarDeclaration";
        table[14, 29] = "Type ID_List ; VarDeclaration";
        table[14, 30] = "Type ID_List ; VarDeclaration";
        table[14, 31] = "Type ID_List ; VarDeclaration";
        table[14, 32] = "Type ID_List ; VarDeclaration";
        table[14, 33] = "Type ID_List ; VarDeclaration";
        table[14, 34] = "Type ID_List ; VarDeclaration";
        table[14, 35] = "Type ID_List ; VarDeclaration";
        table[14, 36] = "";
        table[14, 37] = "";
        table[14, 38] = "";
        //ID_List
        table[15, 8] = "ID ID_List`";
        //ID_List`
        table[16, 11] = "";
        table[16, 27] = ", ID ID_List";
        //Statements
        table[17, 17] = "Statement Statements";
        table[17, 18] = "Statement Statements";
        table[17, 19] = "Statement Statements";
        table[17, 20] = "Statement Statements";
        table[17, 21] = "Statement Statements";
        table[17, 24] = "Statement Statements";
        table[17, 26] = "";
        table[17, 28] = "Statement Statements";
        table[17, 29] = "Statement Statements";
        table[17, 30] = "Statement Statements";
        table[17, 31] = "Statement Statements";
        table[17, 32] = "Statement Statements";
        table[17, 33] = "Statement Statements";
        table[17, 34] = "Statement Statements";
        table[17, 35] = "Statement Statements";
        table[17, 36] = "Statement Statements";
        table[17, 37] = "Statement Statements";
        table[17, 38] = "Statement Statements";
        table[17, 8] = "Statement Statements";
        //Statement
        table[18, 17] = "terminatethis_Statement";
        table[18, 18] = "Replywith_Statement";
        table[18, 19] = "Replywith_Statement";
        table[18, 20] = "Continuewhen_Statement";
        table[18, 21] = "Rotatewhen_Statement";
        table[18, 24] = "If_Statement";
        table[18, 28] = "Assignment";
        table[18, 29] = "Assignment";
        table[18, 30] = "Assignment";
        table[18, 31] = "Assignment";
        table[18, 32] = "Assignment";
        table[18, 33] = "Assignment";
        table[18, 34] = "Assignment";
        table[18, 35] = "Assignment";
        table[18, 38] = "Assignment";
        table[18, 8] = "Assignment";
        table[18, 37] = "write ( Expression ) ;";
        table[18, 36] = "read ( ID ) ;";
        //Assignment
        table[19, 8] = "VarDeclaration = Expression ;";
        table[19, 28] = "VarDeclaration = Expression ;";
        table[19, 29] = "VarDeclaration = Expression ;";
        table[19, 30] = "VarDeclaration = Expression ;";
        table[19, 31] = "VarDeclaration = Expression ;";
        table[19, 32] = "VarDeclaration = Expression ;";
        table[19, 33] = "VarDeclaration = Expression ;";
        table[19, 34] = "VarDeclaration = Expression ;";
        table[19, 35] = "VarDeclaration = Expression ;";
        table[19, 38] = "VarDeclaration = Expression ;";
        //Func _Call
        table[20, 8] = "ID ( Argument_List ) ;";
        //Argument_List
        table[21, 7] = "NonEmpty_Argument_List";
        table[21, 8] = "NonEmpty_Argument_List";
        table[21, 10] = "";
        //NonEmpty_Argument_List
        table[22, 7] = "VarDeclaration = Expression ;";
        table[22, 8] = "VarDeclaration = Expression ;";
        //NonEmpty_Argument_List`
        table[23, 10] = "";
        table[23, 27] = ", Expression NonEmpty_Argument_List`";
        //Block Statements
        table[24, 10] = "{ statements }";
        //If _Statement
        table[25, 24] = "if ( Condition_Expression ) Block_Statements";
        //Condition _Expression
        table[26, 7] = "Condition Co_Expression";
        table[26, 8] = "Condition Co_Expression";
        //Co_Expression
        table[27, 22] = "Condition_Op Condition";
        table[27, 23] = "Condition_Op Condition";
        //Condition _Op
        table[28, 22] = "and";
        table[28, 23] = "or";
        //Condition
        table[29, 7] = "Expression Comparison_Op Expression";
        table[29, 8] = "Expression Comparison_Op Expression";
        //Comparison _Op
        table[30, 2] = "<";
        table[30, 12] = "==";
        table[30, 13] = "!=";
        table[30, 14] = ">";
        table[30, 15] = ">=";
        table[30, 16] = "<=";
        //Rotatewhen _Statement
        table[31, 21] = " Rotatewhen ( Condition_Expression ) Block_Statements";
        //Continuewhen _Statement
        table[32, 20] = "Continuewhen ( expression ; expression ; expression ) Block_Statements";
        //Replywith _Statement
        table[33, 18] = "Replywith Expression ;";
        table[33, 19] = "return ID ;";
        //terminatethis _Statement
        table[34, 17] = "terminatethis ;";
        //Expression
        table[35, 7] = "Term Expression`";
        table[35, 8] = "Term Expression`";
        //Expression`
        table[36, 2] = "";
        table[36, 3] = "Add_Op Term Expression`";
        table[36, 4] = "Add_Op Term Expression`";
        table[36, 10] = "";
        table[36, 11] = "";
        table[36, 12] = "";
        table[36, 13] = "";
        table[36, 14] = "";
        table[36, 15] = "";
        table[36, 16] = "";
        table[36, 27] = "";
        //Add_Op
        table[37, 4] = "+";
        table[37, 3] = "-";
        //Term
        table[38, 7] = "Factor Term`";
        table[38, 8] = "Factor Term`";
        //Term`
        table[39, 2] = "";
        table[39, 3] = "";
        table[39, 4] = "";
        table[39, 5] = "Mul_Op Factor Term`";
        table[39, 6] = "Mul_Op Factor Term`";
        table[39, 10] = "";
        table[39, 11] = "";
        table[39, 12] = "";
        table[39, 13] = "";
        table[39, 14] = "";
        table[39, 15] = "";
        table[39, 16] = "";
        table[39, 27] = "";
        //Mul_Op
        table[40, 5] = "*";
        table[40, 6] = "/";
        //Factor
        table[41, 7] = "Number";
        table[41, 8] = "ID";
        //Comment
        table[42, 2] = "< * STR * >";
        table[42, 3] = "- - STR";
        //using_command
        table[43, 1] = "using ( F_name .txt ) ;";
        //F_name
        table[44, 0] = "STR";



    }
    public bool isTerminal(string s)
    {
        for (int i = 0; i < terminals.Length; i++)
        {
            if (checkIfEqual(s, terminals[i]))
            {
                return true;
            }

        }
        return false;
    }
    public bool isNonTerminal(string s)
    {
        for (int i = 0; i < nonTerminals.Length; i++)
        {
            if (checkIfEqual(s, nonTerminals[i]))
            {
                return true;
            }

        }
        return false;
    }
    public String getRule(String NonTerminal, String Terminal)
    {

        int row = getRawIndex(NonTerminal);
        int column = getColumnIndex(Terminal);
        String rule = table[row, column];
        if (rule == null)
        {
            parserOutput.Add("There is no Rule by this , Non-Terminal(" + NonTerminal + ") ,Terminal(" + Terminal + ") ");
        }
        return rule;
    }
    public int getRawIndex(String nonTerminal)
    {
        for (int raw = 0; raw < nonTerminals.Length; raw++)
        {
            if (checkIfEqual(nonTerminal, nonTerminals[raw]))
            {
                return raw;
            }
        }
        parserOutput.Add(" is not NonTerminal");
        return -1;
    }

    public int getColumnIndex(String terminal)
    {
        for (int coulmn = 0; coulmn < terminals.Length; coulmn++)
        {
            if (checkIfEqual(terminal, terminals[coulmn]))
            {
                return coulmn;
            }
        }
        parserOutput.Add(" is not Terminal");
        return -1;
    }
    public string getNextWord()
    {
        indexOfInput++;
        return input_splited[indexOfInput];
    }
    public Boolean checkIfEqual(string a, string b)
    {
        if (a != null && b != null)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
        }
        return true;
    }
    public string[] splitOnSpace(string text)
    {
        int numberOfSpaces = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                numberOfSpaces++;
            }
        }
        string[] words = new string[numberOfSpaces];
        int wordIndex = 0;
        int pastWordIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                if (text[i + 1] == ' ')
                {
                    continue;
                }
                string word = "";
                for (int j = pastWordIndex; j < i; j++)
                {
                    word += text[j];
                }
                words[wordIndex] = word;
                wordIndex++;
                pastWordIndex = i + 1;
            }
        }
        return words;
    }

}