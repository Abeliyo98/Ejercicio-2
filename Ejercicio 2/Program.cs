using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Figuras figuras = new Figuras(); // Instanciar clase figuras
                int contador = 1;
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine("¿Desea calcular el área de una figura? S/N");
                    string opcion = Console.ReadLine();
                    if (opcion.ToUpper() == "S")
                    {
                        contador++;
                        Console.WriteLine("Elija una figura para calcular su area: \n" +
                            "1.Área de un cuadrado \n" + "2.Área de un círculo \n" + "3. Área de un rectángulo");
                        char figurasElegida = Convert.ToChar(Console.ReadLine());

                        switch (figurasElegida)
                        {
                            case '1': figuras.areaCuadrado(); break;
                            case '2': figuras.areaCirculo(); break;
                            case '3': figuras.areaRectangulo(); break;
                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gracias por utilizar la aplicación");
                        Console.WriteLine("     3...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("     2...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("     1...");
                        System.Threading.Thread.Sleep(1000);
                        return;
                    }
                }

               

                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Ha ocurrido un error inesperado. Error: " + ex.Message);
                Console.ReadLine();
            }
            
        }
    }
}
