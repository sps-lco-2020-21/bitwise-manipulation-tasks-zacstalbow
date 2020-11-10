using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BitwiseOperators.app
{
    class Program
    {
     static int removeLast(int i)
        {
            return i & (i - 1);
            
        }
    static int removeLast3(int i)
        {
            return i & (i - 111);
        }

        static int countSetBits(int i)
        {
            int count = 0;
            while (count != 0)
            {
                count++;

        /* not really sure what to do here in order to add to the count when there is a 1 or a 0 */        
            }
            return count;

        }


        static void Main(string[] args)
        {
            int i = 30;
            Console.WriteLine(removeLast(i));
            Console.WriteLine(removeLast3(i));
            Console.WriteLine(countSetBits(i));




        }
    }
}
