using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RomanNumberParser
{
    public class NumberParser
    {
        public int parseRomanNumer(string Numerals)
        {
            // set up the break variables
            int I = 1;
            int V = 5;
            int X = 10;
            int L = 50;
            int C = 100;
            int D = 500;
            int M = 1000;
            int returnResult = -1; // set default fail

            //all the invalid combinations in a collection
            var notValid = new List<string> { "LL", "DD", "VV", "IIIII", "XXXXX", "CCCCC", "IL", "IC", "ID", "IM", "VX", "VL", "VC", "VD", "VM", "XD", "XM", "LC", "LD", "LM", "DM" };

            // set default return vairable
            bool validNumeral = false;

            //need to apply the rules 2 and 3 against the invalid combinations
            foreach (string test in notValid)
            {
                validNumeral = ((Numerals.IndexOf(test) > -1) ? false : true);
                //discover an invalid string leave loop.
                if (!validNumeral)
                {
                    break;
                }
            }
                        

            //if valid Numeral is false then the Roman Number string is invalid no need to to do this
            if (validNumeral)
            {
                //generate value
                int totalValue = 0;
                for (int i = 0; i < Numerals.Length; i++)
                {

                    //get the character at position i
                    char z = Numerals[i];
                    
                    // 1.b deal with I
                    if (z == 'I')
                    {
                        //is it leading V or X
                        if (i < (Numerals.Length - 1))
                        {
                            if (Numerals[i + 1] == 'V')
                            {
                                totalValue += (V - I);
                                i++; //advance the counter
                            }
                            else if (Numerals[i + 1] == 'X')
                            {
                                totalValue += (X - I);
                                i++; //advance the counter
                            }
                            else
                            {
                                totalValue += I;
                            }
                        }
                        else
                        {
                            totalValue += I;
                        }
                    }

                    // deal with V
                    if (z == 'V')
                    {
                        totalValue += V;
                    }

                    // 1.c deal with X
                    if (z == 'X')
                    {
                        if (i < (Numerals.Length - 1))
                        {
                            //is it leading  C or L
                            if (Numerals[i + 1] == 'C')
                            {
                                totalValue += (C - X);
                                i++; //advance the counter
                            }
                            else if (Numerals[i + 1] == 'L')
                            {
                                totalValue += (L - X);
                                i++; //advance the counter
                            }
                            else
                            {
                                totalValue += X;
                            }
                        }
                        else
                        {
                            totalValue += X;
                        }
                    }

                    // deal with L           
                    if (z == 'L')
                    {
                        totalValue += L;
                    }

                    // 1.d deal with C
                    if (z == 'C')
                    {
                        if (i < (Numerals.Length - 1))
                        {
                            //is it leading D or M
                            if (Numerals[i + 1] == 'D')
                            {
                                totalValue += (D - C);
                                i++; //advvance the counter
                            }
                            else if (Numerals[i + 1] == 'M')
                            {
                                totalValue += (M - C);
                                i++; //advvance the counter
                            }
                            else
                            {
                                totalValue += C;
                            }
                        }
                        else
                        {
                            totalValue += C;
                        }
                    }

                    if (z == 'D')
                    {
                        totalValue += D;
                    }

                    if (z == 'M')
                    {
                        totalValue += M;
                    }
                }
                returnResult = totalValue;
            }

            //send back the result
            return returnResult;
        }

    }
}