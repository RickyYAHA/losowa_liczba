using System;

class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int losowa = rnd.Next(1, 10);
        while (true)
        {
            Console.Write("Podaj liczbe: ");
            int co = Int32.Parse(Console.ReadLine());
            if (co == losowa)
            {
                Console.WriteLine("Gratuluje, trafiles prawidlowa liczbe!");
                Environment.Exit(0);
            }
            else if (co > losowa)
            {
                Console.WriteLine("Podana liczba jest zbyt wysoka");
            }
            else if (co < losowa)
            {
                Console.WriteLine("Podana liczba jest zbyt niska");
            }
        }
    }
}
