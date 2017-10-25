﻿using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine("applying LINQ to my sequence\n");

            var selectedItem = cs.noMatterWho.Where(s => s.id > 3).Select(s => s.model.Count());

            foreach (var item in selectedItem)
            {
                Console.WriteLine(item);
            }
        }
    }
}
