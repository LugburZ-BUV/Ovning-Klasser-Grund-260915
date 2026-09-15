using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ovningar_09_15_convert_class.Models
{
    public class Person
    {
        // Fields for firstName,lastName,Age in class Person
        public string firstName {  get; set; }
        public string lastName {  get; set; }
        public int Age { get; set; }

        // Constructor for new object in class Person
        public Person (string firstname, string lastname, int age)
        {
            firstName = firstname;
            lastName = lastname;
            Age = age;
        }

        // Method to check if object is over 18
        public bool MayHaveDriversLicense()
        {
            if (this.Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to print the info of the object in class Person
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}" +
                $"\nAge: {Age}");
            Console.WriteLine(MayHaveDriversLicense());
        }

        // Method to increase the Age of the object in class Person
        public void Birthday()
        {
            this.Age++;
        }
    }


}
