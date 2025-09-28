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
















        ////test();
        //Console.WriteLine("Hur hög ska den vara?");
        //int height = int.Parse(Console.ReadLine());
        //int level = 1;
        //int turn = 1;
        //while(level < height + 1)
        //{
        //    int amount = level * 2 - 1;
        //    int turns = amount;
        //    while (turns > 0)
        //    {
        //        Console.WriteLine("*");
        //        turns--;
        //    }

        //}




        //int build = level * 2 - 1;
        //while (level < height + 1)
        //{
        //    while (true)
        //    {
        //        Console.Write("*");
        //        break;
        //    }
        //    //Console.Write("*");
        //    //Console.WriteLine($"Level {level}");
        //    //Console.WriteLine($"height {height}");
        //    level++;
        //}