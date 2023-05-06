namespace ERR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = factorial_recursivo(n);
            Console.WriteLine("El factorial de {0} es {1}", n, resultado);
 
        }

        public static int factorial_recursivo(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * factorial_recursivo(n - 1);
            
        }
    }
}