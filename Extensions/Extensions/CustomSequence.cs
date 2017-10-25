using System;
using System.Collections;
using System.Collections.Generic;

namespace Extensions
{
    public class CustomSequence //: IEnumerable
    {
        object[] noMatterWho = { 1, "car", 'a', 2.5, 565647383 };

        List<car> myListGeneric = new List<car>
        {
            new car{ id = 1, model = "subaru"},
            new car{ id = 2, model = "volvo"},
            new car{ id = 3, model = "WV"},
            new car{ id = 4, model = "skoda"},
            new car{ id = 5, model = "opel"}
        };

        public IEnumerator GetEnumerato(int a)
        {
            if (a<10)
            {
                for (int i = 0; i < myListGeneric.Count; i++)
                {
                    yield return myListGeneric[i];
                }
            }
            else{
                foreach (var item in myListGeneric)
                {
                    yield return item;
                }
            }
        }
    }
}
