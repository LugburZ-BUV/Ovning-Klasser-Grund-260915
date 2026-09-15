using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ovningar_09_15_convert_class
{
    public class Person
    {
        // First name, last name, and age for class person
        public string firstName {  get; set; }
        public string lastName {  get; set; }
        public int Age { get; set; }

        public Person (string firstname, string lastname, int age)
        {
            firstName = firstname;
            lastName = lastname;
            Age = age;
        }
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

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}" +
                $"\nAge: {Age}");
            Console.WriteLine(MayHaveDriversLicense());
        }
        public void Birthday()
        {
            this.Age++;
        }
    }


}
