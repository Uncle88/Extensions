using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CustomSequence cs = new CustomSequence();

            foreach (Car c in cs)
            {
                Console.WriteLine("{0}\t{1}", c.Id, c.Model);
            }

            Console.WriteLine("==========");

            foreach (Car c in cs.customGetEnumerator())
            {
                Console.WriteLine("{0}\t{1}", c.Id, c.Model);
            }

            Console.WriteLine("applying LINQ to my sequence\n");

            var selectedItem = cs.noMatterWho.Where(s => s.Id > 3).Select(s => s.Model.Count());

            foreach (var item in selectedItem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("use indexer to my sequence\n");

            var it = cs.noMatterWho[1];
         
                Console.WriteLine("{0}  {1}", it.Id, it.Model);
            Console.WriteLine("-------------------------------------------------------------------");

            string srt = "абабагаламага";
            srt.CharInString();
            Console.WriteLine(";;;;;;;;;;;;;;;;;;;;;;");

            //srt.PairedCharsInString();

            string chars = ExtensionClass.PairedCharsInString("Proskura");
            Console.WriteLine(chars);
        }
    }

    public static class ExtensionClass
    {
        public static char[] CharInString(this string str)
        {
            char[] arrChars = str.ToCharArray();
            return arrChars;
        }

        public static string PairedCharsInString(this string str)
        {
            char[] massChars = str.ToCharArray();
            var outMassChars = massChars.AsEnumerable().Select((v, i) => new { Index = i, Value = v }).Where(p => p.Index % 2 == 0).Select(p => p.Value).ToArray();
            string outStr = new string(outMassChars);
            return outStr;
        }
    }
}
