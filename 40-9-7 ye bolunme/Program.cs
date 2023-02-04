namespace _40_9_7_ye_bolunme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reqem = int.Parse(Console.ReadLine());
            if (reqem % 40 == 0 && reqem % 9 == 0 && reqem % 7 == 0)

                Console.WriteLine("Hamisina bolunur");
            else if (reqem % 40 == 0 & reqem % 9 == 0 & reqem % 7 > 0)
                Console.WriteLine("7 ye bolunmur");
            else if ((reqem % 40 == 0 & reqem % 9 > 0 & reqem % 7 > 0))
                Console.WriteLine("yalniz 40 a bolunur");
            else if ((reqem % 40 > 0 & reqem % 9 == 0 & reqem % 7 > 0))
                Console.WriteLine("yalniz 9 a bolunur");
            else if ((reqem % 40 > 0 & reqem % 9 > 0 & reqem % 7 == 0))
                Console.WriteLine("yalniz 7 ye bolunur");
            else
                Console.WriteLine("hec birine bolunmur");


            Console.WriteLine("hello");
            Console.WriteLine("Salam");
        }
    }
}