using System;

namespace OscarAFernandez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Control prueba = new Control();
            
            prueba.Start();
            Console.WriteLine("Ejercicio C# Sofrecom - Oscar Fernández");
            Console.ResetColor();
            Console.WriteLine("Ingresa el comando /help para más ayuda");
            Console.WriteLine("Presiona ESC para salir..");
            while (true) // Bucle infinito
            {
                Console.WriteLine("Escribe algo:");
                if(Console.ReadKey(true).Key == ConsoleKey.Escape) // Si presiona Escape termina el bucle
                {
                    Console.WriteLine("¡Hasta pronto! Presiona una tecla para salir");
                    break;
                }
                String input = Console.ReadLine();
                if(input.ToLower() == "/help" || input == "") {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ejercicio C# Sofrecom - Oscar Alejandro Fernandez");
                    Console.ResetColor();
                    Console.WriteLine("Al ingresar una oración el software imprime la secuencia de teclas que debes presionar para armar la oración.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("-- Comandos disponibles: ");
                    Console.ResetColor();
                    Console.WriteLine("/help - Muestra este menú de ayuda.");
                    Console.WriteLine("Presiona ESC para salir");
                    Console.WriteLine("Software desarrollado por Oscar Fernandez");
                    Console.WriteLine("");
                }
                else {
                    prueba.findString(input);
                }
            }
        }
    }
}
