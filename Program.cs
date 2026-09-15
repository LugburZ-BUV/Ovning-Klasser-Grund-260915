using Ovningar_09_15_convert_class.Models;

namespace Ovningar_09_15_convert_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Nils = new Person("Nils","Olmås",30);
            Person Kalle = new Person("Kalle", "Anka", 70);

            Car V7an = new Car("Volvo", "V70", 1997);

            Kalle.PrintInfo();
            Nils.PrintInfo();

            Nils.Birthday();

            Nils.PrintInfo();

            V7an.PrintInfo();
        }
    }
}
