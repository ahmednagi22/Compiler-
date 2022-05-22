using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;


namespace Compiler_project.Models
{
    internal class States
    {
        public const int NO_STATE = -1;
        public const int A = 0;
        public const int B = 1;
        public const int C = 2;
        public const int D = 3;
        public const int E = 4;
        public const int F = 5;
        public const int G = 6;
        public const int H = 7;
        public const int I = 8;
        public const int J = 9;
        public const int K = 10;
        public const int L = 11;
        public const int M = 12;
        public const int N = 13;
        public const int O = 14;
        public const int P = 15;
        public const int Q = 16;
        public const int R = 17;
        public const int S = 18;
        public const int T = 19;
        public const int U = 20;
        public const int V = 21;
        public const int W = 22;
        public const int X = 23;
        public const int Y = 24;
        public const int Z = 25;
        public const int AA = 26;
        public const int AB = 27;
        public const int AC = 28;
        public const int AD = 29;
        public const int AE = 30;
        public const int AF = 31;
        public const int AG = 32;
        public const int AH = 33;
        public const int AI = 34;
        public const int AJ = 35;
        public const int AK = 36;
        public const int AL = 37;
        public const int AM = 38;
        public const int AN = 39;
        public const int AO = 40;
        public const int AP = 41;
        public const int AQ = 42;
        public const int AR = 43;
        public const int AS = 44;
        public const int AT = 45;
        public const int AU = 46;
        public const int AV = 47;
        public const int AW = 48;
        public const int AX = 49;
        public const int AY = 50;
        public const int AZ = 51;
        public const int BA = 52;
        public const int BB = 53;
        public const int BC = 54;
        public const int BD = 55;
        public const int BE = 56;
        public const int BF = 57;
        public const int BG = 58;
        public const int BH = 59;
        public const int BI = 60;
        public const int BJ = 61;
        public const int BK = 62;
        public const int BL = 63;
        public const int BM = 64;
        public const int BN = 65;
        public const int BO = 66;
        public const int BP = 67;
        public const int BQ = 68;
        public const int BR = 69;
        public const int BS = 70;
        public const int BT = 71;
        public const int BU = 72;
        public const int BV = 73;
        public const int BW = 74;
        public const int BX = 75;
        public const int BY = 76;
        public const int BZ = 77;
        public const int CA = 78;
        public const int CB = 79;
        public const int CC = 80;
        public const int CD = 81;
        public const int CE = 82;
        public const int CF = 83;
        public const int CG = 84;
        public const int CH = 85;
        public const int CI = 86;
        public const int CJ = 87;
        public const int CK = 88;
        public const int CL = 89;
        public const int CM = 90;
        public const int CN = 91;
        public const int CO = 92;
        public const int CP = 93;
        public const int CQ = 94;
        public const int CR = 95;
        public const int CS = 96;
        public const int CT = 97;
        public const int CU = 98;
        public const int CV = 99;
        public const int CW = 100;
        public const int CX = 101;
        public const int CY = 102;
        public const int CZ = 103;
        public const int DA = 104;
        public const int DB = 105;
        public const int DC = 106;
        public const int DD = 107;
        public const int DE = 108;
        public const int DF = 109;
        public const int DG = 110;
        public const int DH = 111;
        public const int DI = 112;
        public const int DJ = 113;
        public const int DK = 114;
        public const int DL = 115;
        public const int DM = 116;
        public const int DN = 117;
        public const int DO = 118;
        public const int DP = 119;
        public const int DQ = 120;
        public const int DR = 121;
        public const int DS = 122;
        public const int DT = 123;
        public const int DU = 124;
        public const int DV = 125;
        public const int DW = 126;
        public const int DX = 127;
        public const int DY = 128;
        public const int DZ = 129;
        public const int EA = 130;
        public const int EB = 131;
        public const int EC = 132;
        public const int ED = 133;
        public const int EE = 134;
        public const int EF = 135;
        public const int EG = 136;
        public const int EH = 137;
        public const int EI = 138;
        public const int EJ = 139;
        public const int EK = 140;
        public const int EL = 141;
        public const int EM = 142;
        public const int EN = 143;
        public const int EO = 144;
        public const int EP = 145;
        public const int EQ = 146;
        public const int ER = 147;
        public const int ES = 148;
        public const int ET = 149;
        public const int EU = 150;
        public const int EV = 151;
        public const int EW = 152;
        public const int EX = 153;
        public const int EY = 154;
        public const int EZ = 155;
        public const int FA = 156;
        public const int FB = 157;
        public const int FC = 158;
        public const int FD = 159;
        public const int FE = 160;
        public const int FF = 161;
        public const int FG = 162;
        public const int FH = 163;
        public const int FI = 164;
        public const int FJ = 165;
        public const int FK = 166;
        public const int FL = 167;
        public const int FM = 168;
        public const int FN = 169;
        public const int FO = 170;
        public const int FP = 171;

    }
    internal class Inputs
    {
        public const int expl = '!';//expl:!
        public const int bar = '|';//bar:|
        public const int ampr = '&';//ampr:&
        public const int dash = '-';//dash:-
        public const int dot = '.';//dot:.
        public const int div = '/';//div:/
        public const int zero = '0';
        public const int one = '1';
        public const int two = '2';
        public const int three = '3';
        public const int four = '4';
        public const int five = '5';
        public const int six = '6';
        public const int seven = '7';
        public const int eight = '8';
        public const int nine = '9';
        public const int less = '<';//less:<
        public const int eq = '=';//eq:=
        public const int greater = '>';//greater:>
        public const int mul = '*';//mul:*
        public const int C = 'C';
        public const int D = 'D';
        public const int E = 'E';
        public const int I = 'I';
        public const int L = 'L';
        public const int N = 'N';
        public const int P = 'P';
        public const int R = 'R';
        public const int S = 'S';
        public const int U = 'U';
        public const int Lbrac = '[';//Lbrac:[
        public const int Rbrac = ']';//Lbrac:]
        public const int plus = '+';//plus:+
        public const int a = 'a';
        public const int c = 'c';
        public const int d = 'd';
        public const int e = 'e';
        public const int f = 'f';
        public const int g = 'g';
        public const int h = 'h';
        public const int i = 'i';
        public const int k = 'k';
        public const int l = 'l';
        public const int m = 'm';
        public const int n = 'n';
        public const int o = 'o';
        public const int p = 'p';
        public const int r = 'r';
        public const int s = 's';
        public const int t = 't';
        public const int u = 'u';
        public const int v = 'v';
        public const int w = 'w';
        public const int y = 'y';
        public const int LCbrace = '{';//Lpren:{
        public const int RCbrace = '}';//Rpren:}
        public const int Lpren = '(';//Lpren:(
        public const int Rpren = ')';//Rpren:)
        public const int telda = '~';//telda:~
        public const int singleQ = 39;//singleQ:’
        public const int doubleQ = 34;//doubleQ:“
    }

    struct Token
    {
        public string tokenName;
        public string tokenValue;
    }

    struct TokenWithLineNumber
    {
        public int lineNumber;
        public Token token;
    }

    public class LanguageScanner
    {
        public int total_number_of_errors = 0;
        private int[,] transitionTable;
        private string[] acceptStates;
        public ArrayList tokensWithLineNumber;

        public LanguageScanner(string input)
        {
            transitionTable = MakeTransitionTable();
            acceptStates = MakeAcceptanceStatesArray();
            tokensWithLineNumber = Scanner(transitionTable, acceptStates, input);
        }

        private ArrayList Scanner(int[,] transitionTable, string[] accept_states, string input)
        {
            ArrayList tokensWithLineNumber = new ArrayList();
            int Number_of_current_line = 1;
            int postion_of_current_char = 0;

            for (int i = 0; i < input.Length; i = postion_of_current_char)
            {
                bool Error = false;
                bool Single_comment = false;
                bool Multi_comment = false;
                string lexeim = "";
                TokenWithLineNumber tokenWithLineNumber = new TokenWithLineNumber();
                tokenWithLineNumber.token = new Token();
                string tokenValue = "";
                int current_state = States.A;
                int next_state = current_state;
                while (accept_states[next_state] == null || !(input[postion_of_current_char] == (' ') || input[postion_of_current_char] == ('\n') || input[postion_of_current_char] == (';') || input[postion_of_current_char] == ('\r')) || Single_comment || Multi_comment)
                {

                    if (Single_comment)
                    {
                        while (Single_comment)
                        {
                            if (input[postion_of_current_char] != '\r')
                                postion_of_current_char++;
                            else
                            {
                                Single_comment = false;
                                next_state = States.A;
                                lexeim = "";
                            }
                            if (postion_of_current_char == input.Length)
                            {
                                lexeim = "";
                                next_state = States.A;
                                break;
                            }
                        }
                    }
                    if (Multi_comment)
                    {
                        lexeim = "";
                        while (Multi_comment)
                        {
                            if (input[postion_of_current_char] == '*' || input[postion_of_current_char] == '>')
                                lexeim = lexeim + input[postion_of_current_char];
                            if (input[postion_of_current_char] == ('\n'))
                            {
                                Number_of_current_line++;
                            }
                            if (input[postion_of_current_char - 1] == '*' && input[postion_of_current_char] == '>')
                            {
                                Multi_comment = false;
                                next_state = States.A;
                                lexeim = "";
                                postion_of_current_char++;
                            }
                            else
                            {
                                postion_of_current_char++;
                            }
                            if (postion_of_current_char == input.Length)
                            {
                                next_state = States.A;
                                lexeim = "";
                                break;
                            }
                        }
                    }
                    if (postion_of_current_char == input.Length)
                    {
                        break;
                    }
                    if (!(input[postion_of_current_char] == (' ') || input[postion_of_current_char] == ('\n') || input[postion_of_current_char] == ('\r') || input[postion_of_current_char] == (';')))
                    {
                        lexeim += input[postion_of_current_char];
                        next_state = transitionTable[next_state, input[postion_of_current_char]];
                    }
                    if (input[postion_of_current_char] == ('\n'))
                    {
                        Number_of_current_line++;
                    }
                    if (lexeim.Length != 0 && (next_state == States.NO_STATE || input[postion_of_current_char] == ' ' || input[postion_of_current_char] == ('\n') || input[postion_of_current_char] == (';') || input[postion_of_current_char] == ('\r')/*||postion_of_current_char == input.Length - 1*/))
                    {
                        next_state = States.EX;
                        current_state= States.EX;
                        if (is_identifier(lexeim, transitionTable,input,postion_of_current_char))
                        {
                            tokenValue = "ID";
                            Error = false;


                        }
                        else
                        {
                            tokenValue = "Error";
                            Error = true;
                            //total_number_of_errors++;
                        }


                        tokenWithLineNumber.lineNumber = Number_of_current_line;
                        tokenWithLineNumber.token.tokenName = lexeim;
                        tokenWithLineNumber.token.tokenValue = tokenValue;

                        next_state = States.EX;

                        if (input[postion_of_current_char] == ';' || input[postion_of_current_char] == '\n')
                        {
                            //tokenWithLineNumber.lineNumber = Number_of_current_line - 1;
                            tokensWithLineNumber.Add(tokenWithLineNumber);
                            lexeim = "";
                        }
                    }
                    if (input[postion_of_current_char] == (' ') || input[postion_of_current_char] == '\r')
                    {
                        postion_of_current_char++;
                        break;
                    }
                    if (lexeim == "--" || lexeim == "--")
                    {
                        Single_comment = true;
                    }
                    if (lexeim == "<*" || lexeim == "<* ")
                            Multi_comment = true;
                    postion_of_current_char++;

                    if (postion_of_current_char == input.Length)
                    {
                        break;
                    }

                }
                if (postion_of_current_char <= input.Length)
                {
                    if (lexeim.Length != 0)
                    {
                        if (accept_states[next_state] != null)
                        {
                            tokenWithLineNumber.lineNumber = Number_of_current_line;
                            tokenWithLineNumber.token.tokenName = lexeim;

                            if (tokenWithLineNumber.token.tokenValue == null)
                            {
                                tokenValue = accept_states[next_state];
                            }
                            tokenWithLineNumber.token.tokenValue = tokenValue;
                            tokensWithLineNumber.Add(tokenWithLineNumber);
                        }
                        else
                        {
                            if (tokenValue == "Error")
                                total_number_of_errors++;
                            tokenWithLineNumber.lineNumber = Number_of_current_line;
                            tokenWithLineNumber.token.tokenName = lexeim;
                            tokenWithLineNumber.token.tokenValue = tokenValue;
                            tokensWithLineNumber.Add(tokenWithLineNumber);
                        }
                    }
                }
            }

            return tokensWithLineNumber;
        }

        private static bool is_identifier(string lexeim , int[,] transitionTable , string input ,int postion_of_current_char)
        {
            int next_state = States.EX;
            char firstChar = lexeim[0];
            for (int i = 0; i < lexeim.Length; i++)
            {
                next_state = transitionTable[next_state, lexeim[i]];
                if (next_state == States.NO_STATE)
                {
                    return false;
                }

                //if (i == 0)
                //{
                //    if (firstChar < 'A' || firstChar < 'a' && firstChar > 'Z' && firstChar != '_' || firstChar > 'z')
                //        return false;
                //}
                //else
                //{
                //    if (lexeim[i] < 'A' && lexeim[i] > '9' || lexeim[i] < 'a' && lexeim[i] > 'Z' && lexeim[i] != '_' || lexeim[i] < '0' || lexeim[i] > 'z')
                //        return false;
                //}
            }

            return true;
        }

        private string[] MakeAcceptanceStatesArray()
        {
            string[] accept_states = new string[172];
            for (int i = 0; i < 172; i++)
            {
                accept_states[i] = null;
            }
            accept_states[States.E] = "Arithmetic Operation";
            accept_states[States.F] = "Access Operator";
            accept_states[States.G] = "Arithmetic Operation";
            accept_states[States.H] = "Constant";
            accept_states[States.I] = "relational operators";
            accept_states[States.J] = "Assignment operator";
            accept_states[States.K] = "relational operators";
            accept_states[States.L] = "Arithmetic Operation";
            accept_states[States.W] = "Braces";
            accept_states[States.X] = "Braces";
            accept_states[States.Y] = "Arithmetic Operation";
            accept_states[States.AB] = "Braces";
            accept_states[States.AC] = "Braces";
            accept_states[States.AD] = "Logic operators";
            accept_states[States.AE] = "Quotation Mark";
            accept_states[States.AF] = "Quotation Mark";
            accept_states[States.AI] = "relational operators";
            accept_states[States.AJ] = "Logic operators";
            accept_states[States.AK] = "Logic operators";
            accept_states[States.AL] = "single comment";
            accept_states[States.AM] = "relational operators";
            accept_states[States.AN] = "multi comment";
            accept_states[States.AO] = "relational operators";
            accept_states[States.AP] = "relational operators";
            accept_states[States.AQ] = "multi comment";
            accept_states[States.AY] = "Condition";
            accept_states[States.BQ] = "End Statement";
            accept_states[States.CF] = "Character";
            accept_states[States.CI] = "Condition";
            accept_states[States.CJ] = "Integer";
            accept_states[States.CL] = "Void";
            accept_states[States.CP] = "Struct";
            accept_states[States.CW] = "Switch";
            accept_states[States.CZ] = "Float";
            accept_states[States.DF] = "SInteger";
            accept_states[States.DG] = "Inclusion";
            accept_states[States.DL] = "Inheritance";
            accept_states[States.DQ] = "String";
            accept_states[States.DR] = "SFloat";
            accept_states[States.DW] = "Boolean";
            accept_states[States.DX] = "Start Statement";
            accept_states[States.EC] = "Class";
            accept_states[States.EJ] = "Return";
            accept_states[States.EO] = "Loop";
            accept_states[States.ES] = "Switch";
            accept_states[States.EU] = "Loop";
            accept_states[States.EW] = "Break";
            accept_states[States.EY] = "ID";
            accept_states[States.EZ] = "ID";
            accept_states[States.AG] = "Braces";
            accept_states[States.AH] = "Braces";
            return accept_states;
        }

        private int[,] MakeTransitionTable()
        {
            int[,] transitionTable = new int[172, 128];
            for (int i = 0; i < 172; i++)
            {
                for (int j = 0; j < 128; j++)
                {
                    transitionTable[i, j] = States.NO_STATE;
                }
            }
            transitionTable[States.A, Inputs.expl] = States.B;
            transitionTable[States.A, Inputs.bar] = States.C;
            transitionTable[States.A, Inputs.ampr] = States.D;
            transitionTable[States.A, Inputs.dash] = States.E;
            transitionTable[States.A, Inputs.dot] = States.F;
            transitionTable[States.A, Inputs.div] = States.G;
            for (int i = Inputs.zero; i <= Inputs.nine; i++)
            {
                transitionTable[States.A, i] = States.H;
            }
            transitionTable[States.A, Inputs.less] = States.I;
            transitionTable[States.A, Inputs.eq] = States.J;
            transitionTable[States.A, Inputs.greater] = States.K;
            transitionTable[States.A, Inputs.mul] = States.L;
            transitionTable[States.A, Inputs.C] = States.M;
            transitionTable[States.A, Inputs.D] = States.N;
            transitionTable[States.A, Inputs.E] = States.O;
            transitionTable[States.A, Inputs.I] = States.P;
            transitionTable[States.A, Inputs.L] = States.Q;
            transitionTable[States.A, Inputs.N] = States.R;
            transitionTable[States.A, Inputs.P] = States.S;
            transitionTable[States.A, Inputs.R] = States.T;
            transitionTable[States.A, Inputs.S] = States.U;
            transitionTable[States.A, Inputs.U] = States.V;
            transitionTable[States.A, Inputs.Lbrac] = States.W;
            transitionTable[States.A, Inputs.Rbrac] = States.X;
            transitionTable[States.A, Inputs.plus] = States.Y;
            transitionTable[States.A, Inputs.s] = States.Z;
            transitionTable[States.A, Inputs.t] = States.AA;
            transitionTable[States.A, Inputs.LCbrace] = States.AB;
            transitionTable[States.A, Inputs.RCbrace] = States.AC;
            transitionTable[States.A, Inputs.telda] = States.AD;
            transitionTable[States.A, Inputs.singleQ] = States.AE;
            transitionTable[States.A, Inputs.doubleQ] = States.AF;
            transitionTable[States.A, Inputs.Lpren] = States.AG;
            transitionTable[States.A, Inputs.Rpren] = States.AH;


            transitionTable[States.B, Inputs.eq] = States.AI;

            transitionTable[States.C, Inputs.bar] = States.AJ;

            transitionTable[States.D, Inputs.ampr] = States.AK;

            transitionTable[States.E, Inputs.dash] = States.AL;

            for (int i = Inputs.zero; i <= Inputs.nine; i++)
            {
                transitionTable[States.H, i] = States.H;
            }

            transitionTable[States.I, Inputs.eq] = States.AM;
            transitionTable[States.I, Inputs.mul] = States.AN;

            transitionTable[States.J, Inputs.eq] = States.AO;

            transitionTable[States.K, Inputs.eq] = States.AP;

            transitionTable[States.L, Inputs.greater] = States.AQ;

            transitionTable[States.M, Inputs.a] = States.AR;
            transitionTable[States.M, Inputs.h] = States.AS;
            transitionTable[States.M, Inputs.l] = States.AT;
            transitionTable[States.M, Inputs.o] = States.AU;

            transitionTable[States.N, Inputs.e] = States.AV;

            transitionTable[States.O, Inputs.l] = States.AW;
            transitionTable[States.O, Inputs.n] = States.AX;

            transitionTable[States.P, Inputs.f] = States.AY;
            transitionTable[States.P, Inputs.l] = States.AZ;

            transitionTable[States.Q, Inputs.o] = States.BA;

            transitionTable[States.R, Inputs.o] = States.BB;

            transitionTable[States.S, Inputs.r] = States.BC;

            transitionTable[States.T, Inputs.e] = States.BD;
            transitionTable[States.T, Inputs.o] = States.BE;

            transitionTable[States.U, Inputs.e] = States.BF;
            transitionTable[States.U, Inputs.i] = States.BG;

            transitionTable[States.V, Inputs.s] = States.BH;

            transitionTable[States.Z, Inputs.i] = States.BI;

            transitionTable[States.AA, Inputs.e] = States.BJ;


            transitionTable[States.AR, Inputs.t] = States.BK;

            transitionTable[States.AS, Inputs.e] = States.BL;

            transitionTable[States.AT, Inputs.o] = States.BM;

            transitionTable[States.AU, Inputs.n] = States.BN;

            transitionTable[States.AV, Inputs.r] = States.BO;

            transitionTable[States.AW, Inputs.s] = States.BP;

            transitionTable[States.AX, Inputs.d] = States.BQ;

            transitionTable[States.AZ, Inputs.a] = States.BR;

            transitionTable[States.BA, Inputs.g] = States.BS;

            transitionTable[States.BB, Inputs.n] = States.BT;

            transitionTable[States.BC, Inputs.o] = States.BU;

            transitionTable[States.BD, Inputs.p] = States.BV;

            transitionTable[States.BE, Inputs.t] = States.BW;

            transitionTable[States.BF, Inputs.o] = States.BX;
            transitionTable[States.BF, Inputs.r] = States.BY;

            transitionTable[States.BG, Inputs.l] = States.BZ;

            transitionTable[States.BH, Inputs.i] = States.CA;

            transitionTable[States.BI, Inputs.t] = States.CB;

            transitionTable[States.BJ, Inputs.r] = States.CC;

            transitionTable[States.BK, Inputs.e] = States.CD;

            transitionTable[States.BL, Inputs.c] = States.CE;

            transitionTable[States.BM, Inputs.p] = States.CF;

            transitionTable[States.BN, Inputs.t] = States.CG;

            transitionTable[States.BO, Inputs.i] = States.CH;

            transitionTable[States.BP, Inputs.e] = States.CI;


            ////////////////////////////////////////////////////
            transitionTable[States.BR, Inputs.p] = States.CJ;
            transitionTable[States.BS, Inputs.i] = States.CK;
            transitionTable[States.BT, Inputs.e] = States.CL;
            transitionTable[States.BU, Inputs.g] = States.CM;
            transitionTable[States.BV, Inputs.l] = States.CN;
            transitionTable[States.BW, Inputs.a] = States.CO;
            transitionTable[States.BX, Inputs.p] = States.CP;
            transitionTable[States.BY, Inputs.i] = States.CQ;
            transitionTable[States.BZ, Inputs.a] = States.CR;
            transitionTable[States.CA, Inputs.n] = States.CS;
            transitionTable[States.CB, Inputs.u] = States.CT;
            transitionTable[States.CC, Inputs.m] = States.CU;
            transitionTable[States.CD, Inputs.g] = States.CV;
            transitionTable[States.CE, Inputs.k] = States.CW;
            transitionTable[States.CG, Inputs.i] = States.CX;
            transitionTable[States.CH, Inputs.v] = States.CY;
            transitionTable[States.CJ, Inputs.f] = States.CZ;
            transitionTable[States.CK, Inputs.c] = States.DA;
            transitionTable[States.CM, Inputs.r] = States.DB;
            transitionTable[States.CN, Inputs.y] = States.DC;
            transitionTable[States.CO, Inputs.t] = States.DD;
            transitionTable[States.CQ, Inputs.e] = States.DE;
            transitionTable[States.CR, Inputs.p] = States.DF;
            transitionTable[States.CS, Inputs.g] = States.DG;
            transitionTable[States.CT, Inputs.a] = States.DH;
            transitionTable[States.CU, Inputs.i] = States.DI;
            transitionTable[States.CV, Inputs.o] = States.DJ;
            transitionTable[States.CX, Inputs.n] = States.DK;
            transitionTable[States.CY, Inputs.e] = States.DL;
            transitionTable[States.DA, Inputs.a] = States.DM;
            transitionTable[States.DB, Inputs.a] = States.DN;
            transitionTable[States.DC, Inputs.w] = States.DO;
            transitionTable[States.DD, Inputs.e] = States.DP;
            transitionTable[States.DE, Inputs.s] = States.DQ;
            transitionTable[States.DF, Inputs.f] = States.DR;
            transitionTable[States.DH, Inputs.t] = States.DS;
            transitionTable[States.DI, Inputs.n] = States.DT;
            transitionTable[States.DJ, Inputs.r] = States.DU;
            transitionTable[States.DK, Inputs.u] = States.DV;
            transitionTable[States.DM, Inputs.l] = States.DW;
            transitionTable[States.DN, Inputs.m] = States.DX;
            transitionTable[States.DO, Inputs.i] = States.DY;
            transitionTable[States.DP, Inputs.w] = States.DZ;
            transitionTable[States.DS, Inputs.i] = States.EA;
            transitionTable[States.DT, Inputs.a] = States.EB;
            transitionTable[States.DU, Inputs.y] = States.EC;
            transitionTable[States.DV, Inputs.e] = States.ED;
            transitionTable[States.DY, Inputs.t] = States.EE;
            transitionTable[States.DZ, Inputs.h] = States.EF;
            transitionTable[States.EA, Inputs.o] = States.EG;
            transitionTable[States.EB, Inputs.t] = States.EH;
            transitionTable[States.ED, Inputs.w] = States.EI;
            transitionTable[States.EE, Inputs.h] = States.EJ;
            transitionTable[States.EF, Inputs.e] = States.EK;
            transitionTable[States.EG, Inputs.n] = States.EL;
            transitionTable[States.EH, Inputs.e] = States.EM;
            transitionTable[States.EI, Inputs.h] = States.EN;
            transitionTable[States.EK, Inputs.n] = States.EO;
            transitionTable[States.EL, Inputs.o] = States.EP;
            transitionTable[States.EM, Inputs.t] = States.EQ;
            transitionTable[States.EN, Inputs.e] = States.ER;
            transitionTable[States.EP, Inputs.f] = States.ES;
            transitionTable[States.EQ, Inputs.h] = States.ET;
            transitionTable[States.ER, Inputs.n] = States.EU;
            transitionTable[States.ET, Inputs.i] = States.EV;
            transitionTable[States.EV, Inputs.s] = States.EW;
            for(char i='a';i<='z';i++)
            transitionTable[States.EX,i] = States.EY;
            for (char i = 'A'; i <= 'Z'; i++)
                transitionTable[States.EX, i] = States.EY;
            transitionTable[States.EX, '_'] = States.EY;
            for (char i = 'a'; i <= 'z'; i++)
                transitionTable[States.EY, i] = States.EZ;
            for (char i = 'A'; i <= 'Z'; i++)
                transitionTable[States.EY, i] = States.EZ;
            transitionTable[States.EY, '_'] = States.EZ;
            for (char i = '0'; i <= '9'; i++)
                transitionTable[States.EY, i] = States.EZ;

            for (char i = 'a'; i <= 'z'; i++)
                transitionTable[States.EZ, i] = States.EZ;
            for (char i = 'A'; i <= 'Z'; i++)
                transitionTable[States.EZ, i] = States.EZ;
            transitionTable[States.EZ, '_'] = States.EZ;
            for (char i = '0'; i <= '9'; i++)
                transitionTable[States.EZ, i] = States.EZ;

            return transitionTable;
        }

    }
}