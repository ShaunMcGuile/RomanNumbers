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

            // set default return vairable
            bool validNumeral = false;

            //need to apply the rules

            // 3. count rule if only 0  or 1 occurence of D, L, V
            if (Numerals.Count(x => x == 'D') < 2)
            {
                validNumeral = true;
            }

            if (Numerals.Count(x => x == 'L') < 2)
            {
                validNumeral = true;
            }

            if (Numerals.Count(x => x == 'V') < 2)
            {
                validNumeral = true;
            }

            // rule 2 makes no sense as written - what it actually means is that you can't have more than four of I, X, or C in sequence in the Roman Number
            //if valid Numeral is false then the Roman Number  string is invalid no need to check further
            // check I
            if (validNumeral)
            {
                string lI = "IIIII";
                validNumeral = ((Numerals.IndexOf(lI) > 0) ? false : true);
            }
                //Check V only if still valid
                
            if (validNumeral)
            {
                string lX = "XXXXX";
                validNumeral = ((Numerals.IndexOf(lX) > 0) ? false : true);
            }


            // check L only if still valid
            if (validNumeral)
            {
                string lC = "CCCCC";
                validNumeral = ((Numerals.IndexOf(lC) > 0) ? false : true);
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

                    // deal with V
                    if (z == 'V')
                    {
                        totalValue += V;
                    }

                    // 1.c deal with X
                    if (z == 'X')
                    {
                        //is it leading V or X
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

                    // deal with L           
                    if (z == 'L')
                    {
                        totalValue += L;
                    }

                    // 1.d deal with C
                    if (z == 'C')
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