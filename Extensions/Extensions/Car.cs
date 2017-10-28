using System;
namespace Extensions
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public Car(int currentValue, string Name)
        {
            this.Id = currentValue;
            this.Model = Name;
        }
    }
}
