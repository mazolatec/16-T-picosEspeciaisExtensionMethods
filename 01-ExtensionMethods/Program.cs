namespace _01_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}