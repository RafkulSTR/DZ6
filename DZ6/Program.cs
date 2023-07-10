namespace DZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad41();
            Zad43();
        }

        static void Zad41()
        {
            Console.WriteLine("Введите размер чисел");
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            int[] array = new int[m];
            for (int i = 0; i < m; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > 0 ) { count++; }
            }
            Console.WriteLine($"Массив - {string.Join(",", array)}");
            Console.WriteLine($"Всего введеных чисел больше нуля = {count}");
        }

        static void Zad43()
        {
            Console.WriteLine("Введите b1");
            double b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k1");
            double k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b2");
            double b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k2");
            double k2 = int.Parse(Console.ReadLine());
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}