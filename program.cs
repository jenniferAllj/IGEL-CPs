using System;

class Program
{
    static void Main(string[] args)
    {
        string continuar = "S";

        while (continuar.ToUpper() == "S")
        {
            try
            {
                double num1, num2;
                string clave;

                // Solicitar el primer numero
                while (true)
                {
                    Console.Write("Ingrese el primer numero real: ");
                    string entrada1 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada1))
                    {
                        Console.WriteLine("Error: Debe ingresar un dato.");
                        continue;
                    }

                    if (double.TryParse(entrada1, out num1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Debe ingresar un numero valido.");
                    }
                }

                // Solicitar el segundo numero
                while (true)
                {
                    Console.Write("Ingrese el segundo numero real: ");
                    string entrada2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada2))
                    {
                        Console.WriteLine("Error: Debe ingresar un dato.");
                        continue;
                    }

                    if (double.TryParse(entrada2, out num2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Debe ingresar un numero valido.");
                    }
                }

                // Solicitar la clave de operacion
                Console.WriteLine("\nSeleccione la operacion:");
                Console.WriteLine("+  Suma");
                Console.WriteLine("-  Resta");
                Console.WriteLine("*  Multiplicacion");
                Console.WriteLine("/  Division");
                Console.WriteLine("R  Raiz cuadrada");
                Console.WriteLine("E  Potencia");

                Console.Write("Ingrese la clave: ");
                clave = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(clave))
                {
                    Console.WriteLine("Error: Debe ingresar una clave.");
                }
                else
                {
                    double resultado;

                    switch (clave.ToUpper())
                    {
                        case "+":
                            resultado = num1 + num2;
                            Console.WriteLine("Resultado de la suma: " + resultado);
                            break;

                        case "-":
                            resultado = num1 - num2;
                            Console.WriteLine("Resultado de la resta: " + resultado);
                            break;

                        case "*":
                            resultado = num1 * num2;
                            Console.WriteLine("Resultado de la multiplicacion: " + resultado);
                            break;

                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: No se puede dividir entre cero.");
                            }
                            else
                            {
                                resultado = num1 / num2;
                                Console.WriteLine("Resultado de la division: " + resultado);
                            }
                            break;

                        case "R":
                            if (num1 < 0 || num2 < 0)
                            {
                                Console.WriteLine("Error: No se puede obtener la raiz cuadrada de un numero negativo.");
                            }
                            else
                            {
                                Console.WriteLine("Raiz cuadrada del primer numero: " + Math.Sqrt(num1));
                                Console.WriteLine("Raiz cuadrada del segundo numero: " + Math.Sqrt(num2));
                            }
                            break;

                        case "E":
                            resultado = Math.Round(Math.Pow(num1, num2), 3);
                            Console.WriteLine("Resultado de la potencia: " + resultado);
                            break;

                        default:
                            Console.WriteLine("Error: La clave ingresada no es valida.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }

            // Preguntar si desea continuar
            Console.Write("\n¿Desea realizar otra operacion? (S/N): ");
            continuar = Console.ReadLine();

            while (continuar.ToUpper() != "S" && continuar.ToUpper() != "N")
            {
                Console.WriteLine("Respuesta incorrecta. Escriba S para continuar o N para salir.");
                Console.Write("¿Desea realizar otra operacion? (S/N): ");
                continuar = Console.ReadLine();
            }

            Console.WriteLine();
        }

        Console.WriteLine("Programa finalizado. ¡Hasta pronto!");
    }
}