namespace Singelton_design_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singelton s1 = Singelton.getInstatnt();
            Singelton s2 = Singelton.getInstatnt();

            if (s1 == s2)
            {
                Console.WriteLine("SingelTon Work");
            }
            else
            {
                Console.WriteLine("Oopss Singelton dosnt work");
            }


        }
    }
}
