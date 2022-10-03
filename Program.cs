int numero;
Console.Write("\nDigite um número para análise: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nPositivo\n");
        Console.ResetColor();
    }
else if (numero < 0)
     {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNegativo\n");
            Console.ResetColor();

      }
else if (numero == 0)
            {

                Console.WriteLine("\nZero\n");
            }
            