using System;
using System.Collections.Generic;
using System.Text;

namespace Ovningar_09_15_convert_class.Models
{
    public class Car
    {
        public string Make {  get; set; }
        public string Model {  get; set; }
        public int Year {  get; set; }
        public Car(string make,string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Your Car:" +
                $"\nMärke: {Make} " +
                $"\nModell: {Model}" +
                $"\nÅrsmodell: {Year}");
            
        }

    }
}
