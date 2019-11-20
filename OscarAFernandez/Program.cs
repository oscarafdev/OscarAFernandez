using System;

namespace OscarAFernandez
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Control control = new Control();
            control.Start(); // Iniciamos la lista de carácteres disponibles

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ejercicio C# Sofrecom - Oscar Fernández");
            Console.ResetColor();
            Console.WriteLine("Ingresa el comando /help para más ayuda");
            while (true) // Bucle infinito
            {
                Console.WriteLine("Escribe algo:");
                String input = Console.ReadLine();
                if(input.ToLower() == "/exit") // Comando de salida
                {
                    Console.WriteLine("¡Hasta pronto! Presiona una tecla para salir");
                    break;
                }
                
                if(input.ToLower() == "/help" || input == "") { // Comando de ayuda
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ejercicio C# Sofrecom - Oscar Alejandro Fernandez");
                    Console.ResetColor();
                    Console.WriteLine("Al ingresar una oración el software imprime la secuencia de teclas que debes presionar para armar la oración.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("-- Comandos disponibles: ");
                    Console.ResetColor();
                    Console.WriteLine("/help - Muestra este menú de ayuda.");
                    Console.WriteLine("/exit - Salir de la aplicación.");
                    Console.WriteLine("Software desarrollado por Oscar Fernandez");
                    Console.WriteLine("");
                }
                else {
                    if(control.IsLetter(input)) { // Verifica si es un caracter válido
                        control.findString(input);
                    }
                    else { 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Ingresa caracteres válidos (Aa-Zz)."); 
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
