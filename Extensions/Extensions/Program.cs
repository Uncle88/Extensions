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

            Console.WriteLine("use indexer to my sequence\n");

            var it = cs.noMatterWho[1];
         
                Console.WriteLine("{0}  {1}", it.id, it.model);
            Console.WriteLine("-------------------------------------------------------------------");

            string srt = "абабагаламага";
            srt.CharInString();
            Console.WriteLine(";;;;;;;;;;;;;;;;;;;;;;");

            srt.PairedCharsInString();

            IEnumerable<char> chars = ExtensionClass.PairedCharsInString("Proskura");
        }
    }

    public static class ExtensionClass
    {
        public static char[] CharInString(this string str)
        {
            char[] arrChars = str.ToCharArray();
            return arrChars;
        }

        public static IEnumerable<char> PairedCharsInString(this string str)
        {
            IEnumerable<char> massChars = str.ToCharArray();
            var outMassChars = massChars.Select((v, i) => new { Index = i, Value = v }).Where(p => p.Index % 2 == 0).Select(p => p.Value);
            return outMassChars;
        }
    }
}
