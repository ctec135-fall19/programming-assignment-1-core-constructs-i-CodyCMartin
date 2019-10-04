/*
Author: Cody Martin
Date:   10/4/19
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations
            // Double variables declared 3 different ways


            System.Double v1 = 1;
            double v2 = 2;
            Double v3 = new double(); 


            #endregion

            #region Variable Initialization/print
            // CLS compliant numeric type variables

            byte var1 = 1;
            short var2 = 2;
            int var3 = 33_33_33;
            long var4 = 4;
            float var5 = 5;
            double var6 = 6;
            decimal var7 = 77;

            Console.WriteLine("var1: {0:c}", var1);
            Console.WriteLine("var2: {0}", var2);
            Console.WriteLine("var3: {0:g}", var3);
            Console.WriteLine("var4: {0}", var4);
            Console.WriteLine("var5: {0}", var5);
            Console.WriteLine("var6: {0}", var6);
            Console.WriteLine("var7: {0}", var7);



            #endregion

         

            #region min/max printout for int16
            // min/max values print for int16

            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(Int16.MaxValue);


            #endregion


        }
    }
}
