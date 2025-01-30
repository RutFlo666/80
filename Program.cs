
namespace _170125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string frNumber = Console.ReadLine();
            float Fr = float.Parse(frNumber);


            string scdNumber = Console.ReadLine();
            float Scd = float.Parse(scdNumber);

            string dog = Console.ReadLine();


            if (dog == "+")
            {
                Console.WriteLine(Fr + Scd);

            }
            else if (dog == "-")
            {
                Console.WriteLine(Fr - Scd);
            }
            if (dog == "*")
            {
                Console.WriteLine(Fr * Scd);

            }
            else if (dog == "/")
            {
                Console.WriteLine(Fr / Scd);
            }







        }
    }
}