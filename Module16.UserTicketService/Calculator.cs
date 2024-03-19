using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.UserTicketService
{
    public class Calculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiplication (int a, int b)
        { 
            return a * b; 
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Division(int a, int b)
        {
            return a / b;

            //try
            //{
            //    return a / b;
            //}
            //catch (Exception e)
            //{
            //    return 0;
            //}
        }
    }
}
