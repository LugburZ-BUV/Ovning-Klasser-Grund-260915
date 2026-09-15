using Ovningar_09_15_convert_class.Models;

namespace Ovningar_09_15_convert_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create new object in class Person
            Person Nils = new Person("Nils","Olmås",30);
            Person Kalle = new Person("Kalle", "Anka", 70);

            // Create new object in class Car
            Car V7an = new Car("Volvo", "V70", 1997);

            // Call method to PrintInfo of Kalle,Nils in class Person
            Kalle.PrintInfo();
            Nils.PrintInfo();

            // Call method to increase Nils age by +1 in class Person
            Nils.Birthday();

            // Call method to PrintInfo of Nils in class Person after increasing age
            Nils.PrintInfo();

            // Call method to PrintInfo of V7an in class Car
            V7an.PrintInfo();
        }
    }
}
