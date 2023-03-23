namespace DesafioDiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int numero, espacos, xis;

                
                Console.WriteLine( " DIAMANTE DE X ");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine("Insira um número ímpar: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 != 0)
                {

                    
                    xis = 1;
                    espacos = (numero - 1) / 2;
                    for (int linha = 1; espacos > 0; linha++)
                    {
                        
                        for (int i = 1; i <= espacos; i++)
                        {
                            Console.Write(" ");
                        }
                        
                        for (int i = 1; i <= xis; i++)
                        {
                            Console.Write("X");
                        }
                        espacos--;
                        xis += 2;
                        Console.WriteLine();
                    }

                    
                    for (int linha = 1; xis > 0; linha++)
                    {

                        
                        for (int i = 1; i <= espacos; i++)
                        {
                            Console.Write(" ");
                        }

                        
                        for (int i = 1; i <= xis; i++)
                        {
                            Console.Write("X");
                        }
                        espacos++;
                        xis -= 2;
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Não é ímpar!");
                }
            }
    }
}