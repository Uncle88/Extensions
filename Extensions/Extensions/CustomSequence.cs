using System;
using System.Collections;
using System.Collections.Generic;

namespace Extensions
{
    public class CustomSequence : IEnumerable
    {
        public List<car> noMatterWho = new List<car>()
        {
            new car(1, "subaru"),
            new car(2, "wv"),
            new car(3, "skoda"),
            new car(4, "iveco"),
            new car(5, "opel")
        };

        public IEnumerable customGetEnumerator()
        {
            for (int i = 0; i < noMatterWho.Count; i++)
          {
                yield return noMatterWho[i];
          }
        }

        public IEnumerator GetEnumerator()
        {
            return noMatterWho.GetEnumerator();
        }

        public car  this [int index]
        {
            get => noMatterWho[index]; 
            set => noMatterWho[index] = value; 
        }
    }
}
