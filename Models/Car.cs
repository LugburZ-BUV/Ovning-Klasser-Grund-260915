using System;
using System.Collections.Generic;
using System.Text;

namespace Ovningar_09_15_convert_class.Models
{
    public class Car
    {

        // Fields for Make,Model,Year in class Car
        public string Make {  get; set; }
        public string Model {  get; set; }
        public int Year {  get; set; }

        // Constructor for new object in class Car
        public Car(string make,string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Print the info of the object in class Car
        public void PrintInfo()
        {
            Console.WriteLine($"Din Bil:" +
                $"\nMärke: {Make} " +
                $"\nModell: {Model}" +
                $"\nÅrsmodell: {Year}");
            
        }

    }
}
