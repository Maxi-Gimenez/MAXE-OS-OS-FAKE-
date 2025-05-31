using System;

namespace MAXEOS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Inicio();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("> ");
                Console.ResetColor();
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "/home":
                        MostrarHome();
                        break;

                    case "/apps":
                        MostrarAPPs();
                        Console.Write("\nSelecciona una aplicación (o escribe 'back' para volver): ");
                        string selectedApp = Console.ReadLine();

                        switch (selectedApp.ToLower())
                        {
                            case "calculadora":
                                Calculadora();
                                break;
                            case "notepad":
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(">>> Bloc de notas abierto (funcionalidad en desarrollo) <<<");
                                Console.ResetColor();
                                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                                Console.ReadKey();
                                break;
                            case "lista":
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(">>> Lista de tareas abierta (funcionalidad en desarrollo) <<<");
                                Console.ResetColor();
                                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                                Console.ReadKey();
                                break;
                            case "back":
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Aplicación desconocida. Escribe el nombre exacto.");
                                Console.ResetColor();
                                break;
                        }
                        break;

                    case "/help":
                        MostrarHelp();
                        break;

                    case "/exit":
                        Console.WriteLine("Volviendo al inicio...");
                        break;

                    case "/off":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("¿Estás seguro que quieres apagar el sistema? (S/N): ");
                        Console.ResetColor();
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "s")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n🛑 Apagando sistema... ¡Hasta pronto!");
                            Console.ResetColor();
                            return;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagado cancelado.");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando desconocido. Usa /help para ayuda.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void Inicio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╔═════════════════════════════════╗");
            Console.WriteLine("║           MAXE OS              ║");
            Console.WriteLine("╚═════════════════════════════════╝\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Comandos disponibles: /home | /apps | /help | /exit | /off\n");
            Console.ResetColor();
        }

        static void MostrarHome()
        {
            Console.Clear();
            Inicio();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************************************");
            Console.WriteLine("         🌟 BIENVENIDO A MAXE OS 🌟");
            Console.WriteLine("****************************************\n");
            Console.ResetColor();

            Console.WriteLine(">>> Un sistema operativo experimental <<<");
            Console.WriteLine(">>> Interfaz basada en consola <<<");

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void MostrarAPPs()
        {
            Console.Clear();
            Inicio();
            Console.WriteLine("Aplicaciones disponibles:\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("📱 - Calculadora");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("📝 - Bloc de notas");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("🗂️ - Lista de tareas");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("🎮 - Juegos (próximamente)");
            Console.ResetColor();
        }

        static void MostrarHelp()
        {
            Console.Clear();
            Inicio();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("📘 COMANDOS DISPONIBLES:");
            Console.WriteLine("/home     → Ir a la pantalla de inicio");
            Console.WriteLine("/apps     → Listar aplicaciones disponibles");
            Console.WriteLine("/help     → Mostrar esta ayuda");
            Console.WriteLine("/exit     → Volver al menú principal");
            Console.WriteLine("/off      → Apagar el sistema");
            Console.ResetColor();

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void Calculadora()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("🔢 MODO CALCULADORA");
            Console.ResetColor();
            Console.WriteLine("1: Sumar");
            Console.WriteLine("2: Restar");
            Console.WriteLine("3: Multiplicar");
            Console.WriteLine("4: Dividir");
            Console.WriteLine("5: Volver al menú");

            Console.Write("\nSelecciona operación: ");
            if (!int.TryParse(Console.ReadLine(), out int operation) || operation < 1 || operation > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Opción inválida!");
                Console.ResetColor();
                return;
            }

            if (operation == 5) return;

            Console.Write("Introduce el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Número inválido!");
                Console.ResetColor();
                return;
            }

            Console.Write("Introduce el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Número inválido!");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            switch (operation)
            {
                case 1:
                    Console.WriteLine($"\n✅ Resultado: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"\n✅ Resultado: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"\n✅ Resultado: {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n❌ Error: ¡No se puede dividir por cero!");
                        break;
                    }
                    Console.WriteLine($"\n✅ Resultado: {num1 / num2}");
                    break;
            }
            Console.ResetColor();
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
