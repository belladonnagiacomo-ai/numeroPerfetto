namespace numeroPerfetto
{
    internal class Program
    {
        static bool numeroP(int n)
        {
            int somma = 0;
            for (int i = 1; n > i; i++)
            {
                if (n%i == 0)
                {
                    somma = i + somma;
                }

            }
            if (somma == n)
            {
                Console.WriteLine("il numero e perfetto");
                return true;
            }
            
            
            Console.WriteLine("il numero non e perfetto");
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("dammi un numero da analizzare");
            int n = Convert.ToInt32(Console.ReadLine());
            numeroP(n);
           
        }
    }
}
