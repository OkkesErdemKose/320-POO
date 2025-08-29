using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace escargot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SNAIL = "_@_ö";
            const string DEAD_SNAIL = "____";
            const string NO_SNAIL = "    ";

            Console.CursorVisible = false;


            for (int i = 0; i < 20; i++)
            {

                Console.CursorLeft = i + 4;
                Console.Write(SNAIL);

                Console.CursorLeft = i;
                Console.Write(NO_SNAIL);


                Thread.Sleep(100);
            }

            Console.Write(DEAD_SNAIL);




            Console.ReadKey();

        }
    }
}
