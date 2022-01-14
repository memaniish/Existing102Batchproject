using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshTest102Project
{
    class SwapTwoNumbers
    {
        public static void SwapingNumbers()
        {
            //camel case for local variables and method parameters
            
            int firstNum, secondNum, temp;
            Console.WriteLine("Please enter the first number");
            firstNum=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            secondNum=Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Before exchanging values: first={0},second={1}", firstNum,secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("After exchanging values: first={0},second={1}", firstNum,secondNum);


        }
    }
}
