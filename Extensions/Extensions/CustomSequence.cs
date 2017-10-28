using System;
using System.Collections;
using System.Collections.Generic;

namespace Extensions
{
    public class CustomSequence : IEnumerable
    {
        public List<Car> noMatterWho = new List<Car>()
        {
            new Car(1, "subaru"),
            new Car(2, "wv"),
            new Car(3, "skoda"),
            new Car(4, "iveco"),
            new Car(5, "opel")
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

        public Car  this [int index]
        {
            get => noMatterWho[index]; 
            set => noMatterWho[index] = value; 
        }
    }
}
