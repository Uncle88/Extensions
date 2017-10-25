using System;
namespace Extensions
{
    public class car
    {
        public int id { get; set; }
        public string model { get; set; }

        public car(int a, string str)
        {
            this.id = a;
            this.model = str;
        }
    }
}
