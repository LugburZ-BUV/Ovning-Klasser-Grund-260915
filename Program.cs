namespace Ovningar_09_15_convert_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Nils = new Person("Nils","Olmås",30);
            Person Kalle = new Person("Kalle", "Anka", 70);

            Kalle.PrintInfo();
            Nils.PrintInfo();

            Nils.Birthday();

            Nils.PrintInfo();
        }
    }
}
