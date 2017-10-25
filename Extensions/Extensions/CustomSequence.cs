using System;
using System.Collections;
using System.Collections.Generic;

namespace Extensions
{
    public class CustomSequence : IEnumerable
    {
        private car[] noMatterWho = new car[5];

        public CustomSequence()
        {
            noMatterWho[0] = new car(1, "subaru");
            noMatterWho[1] = new car(2, "wv");
            noMatterWho[2] = new car(3, "skoda");
            noMatterWho[3] = new car(4, "iveco");
            noMatterWho[4] = new car(5, "opel");
        }
        List<car> myListGeneric = new List<car>();

        public IEnumerable customGetEnumerator()
        {
            for (int i = 0; i < noMatterWho.Length; i++)
          {
                yield return noMatterWho[i];
          }
        }

        public IEnumerator GetEnumerator()
        {
            return noMatterWho.GetEnumerator();
        }
    }
}
