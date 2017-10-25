using System;
using System.Collections.Generic;

namespace Extensions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CustomSequence cs = new CustomSequence();

            foreach (car c in cs)
            {
                Console.WriteLine("{0}\t{1}", c.id, c.model);
            }

            Console.WriteLine("==========");

            foreach (car c in cs.customGetEnumerator())
            {
                Console.WriteLine("{0}\t{1}", c.id, c.model);
            }
        }
    }
}
