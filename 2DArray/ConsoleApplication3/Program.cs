using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDimArray = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //Elements in straight direction
            Console.Write("1) ");
            foreach (int value in twoDimArray)
            {
                Console.Write("{0} ", value);
            }

            //Elements in reverse direction
            Console.Write("\n2) ");
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 2; j >= 0; j--)
                {
                    Console.Write("{0} ", twoDimArray[i, j]);
                } 
            }

            //Elements from columns in straight direction
            Console.Write("\n3) ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++ )
                {
                    Console.Write("{0} ", twoDimArray[j, i]);
                }
            }

            //Elements from columns in straight direction
            Console.Write("\n4) ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", twoDimArray[2 - j, 2 - i]);
                }
            }
            

            //Elements from reverse diagonal
            Console.Write("\n5) ");
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                Console.Write("{0} ", twoDimArray[2 - i, j]);
            }

            //Elements from straight diagonal
            Console.Write("\n6) ");
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                Console.Write("{0} ", twoDimArray[i, j]);
            }

            Console.ReadKey();
           
        }
    }
}