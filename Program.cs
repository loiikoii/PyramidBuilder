namespace PyramidBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Välkommen till pyramidbyggaren!");
                Console.Write("Hur hög ska den vara?: ");
                int height = int.Parse(Console.ReadLine());

                for (int i = 1; i <= height; i++)
                {
                    int block = 2 * i - 1;
                    int space = height - i;

                    Console.Write(new string(' ', space));
                    Console.WriteLine(new string('*', block));
                }
            }
        }
    }
}