using System;

class Program
{
    static void Main()
    {
        int opcion;
        
        do
        {
            Console.WriteLine("Elija un ejercicio:");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
            
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
            }
            
            Console.WriteLine();
        } while (opcion != 5);
    }

    static void Ejercicio1()
    {
        Console.Clear();
        int numero;

        Console.Write("Ingrese un número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
        {
            int opcion;
            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Calcular el factorial del número.");
                Console.WriteLine("2. Calcular la raíz cuadrada del número.");
                Console.WriteLine("3. Salir del programa.");
                Console.Write("Opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // Calcular y mostrar el factorial del número
                            long factorial = CalcularFactorial(numero);
                            Console.WriteLine($"El factorial de {numero} es: {factorial}");
                            break;
                        case 2:
                            // Calcular y mostrar la raíz cuadrada del número
                            double raizCuadrada = Math.Sqrt(numero);
                            Console.WriteLine($"La raíz cuadrada de {numero} es: {raizCuadrada}");
                            break;
                        case 3:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                            break;
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                }
            } while (opcion != 3);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
        }
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalcularFactorial(n - 1);
    }

    static void Ejercicio2()
    {
        Console.Clear();
        int num1, num2;
        char operador;
        double resultado;

        Console.Write("Ingrese el primer número entero: ");
        if (int.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Ingrese el segundo número entero: ");
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Ingrese un operador (+, -, *, /): ");
                if (char.TryParse(Console.ReadLine(), out operador))
                {
                    switch (operador)
                    {
                        case '+':
                            resultado = num1 + num2;
                            Console.WriteLine($"El resultado de la suma es: {resultado}");
                            break;
                        case '-':
                            resultado = num1 - num2;
                            Console.WriteLine($"El resultado de la resta es: {resultado}");
                            break;
                        case '*':
                            resultado = num1 * num2;
                            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                resultado = (double)num1 / num2;
                                Console.WriteLine($"El resultado de la división es: {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("Error: división por cero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Operador inválido.");
                            break;
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un operador válido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        }
    }

    static void Ejercicio3()
    {
        Console.Clear();
        int numero;

        Console.Write("Ingrese un número entero: ");
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        }
    }

    static void Ejercicio4()
    {
        Console.Clear();
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intento, intentosRealizados = 0;

        Console.WriteLine("Adivina el número secreto (entre 1 y 100):");

        do
        {
            Console.Write("Introduce tu número: ");
            if (int.TryParse(Console.ReadLine(), out intento))
            {
                intentosRealizados++;

                if (intento < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es mayor.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("El número secreto es menor.");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! ¡Adivinaste el número secreto en {intentosRealizados} intentos!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
        } while (intento != numeroSecreto);
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
}
