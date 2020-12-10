using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class Figuras
    {
        double lado = 0;
        double radio = 0;
        double ancho = 0; 
        double area = 0;

        //para crear una función o m´ñetodo tenemos que añadir la visibilidad, seguida del tipo de
       //valor que va a devolver o retornar nuestra función (si no devuelve nada es de tipo void), más el nombre de la función seguida de los
       //argumentos que tengan y se cierra con las llaves.

        public void areaCuadrado()
        {

            Console.WriteLine("Ingresa el valor del lado de un cuadrado cualquiera:");
            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El área del cuadrado es:" + area);
        }

        public void areaCirculo()
        {

            Console.WriteLine("Ingresa el valor del radio de un circulo cualquiera:");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI*Math.Pow(radio,2);
            Console.WriteLine("El área del circulo es:" + area);
        }

        public void areaRectangulo()
        {

            Console.WriteLine("Ingresa el valor de la base de un rectangulo cualquiera:");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la base de un rectangulo cualquiera:");
            ancho = Convert.ToDouble(Console.ReadLine());
            area = lado * ancho;
            Console.WriteLine("El área del rectángulo es: " + area);
        }
    }
}
