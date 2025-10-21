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
               
                return true;
            }
            
            
           
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("dammi un numero da analizzare");
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            for (int c = 2; c < 50; c++)
            {
                if (numeroP(c) == true)
                {
                    cont++;
                }
            }
            Console.WriteLine("i numeri perfetti da 1 a 50 sono:" + cont);
                if (numeroP(n) == true)
                {
                    Console.WriteLine("il numero e perfetto");
                }
                else
                {
                    Console.WriteLine("il numero non e perfetto");
                }
            
        }
    }
}
