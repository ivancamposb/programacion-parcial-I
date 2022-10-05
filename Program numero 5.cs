using System;

class Ejercicio5
{

    static void Main()
    {

        double a, b;
        string articulo, efectivo;
        double cambio;

        maquinadecambio M1 = new maquinadecambio();

        Console.WriteLine("Introduzca el precio del artículo");
        articulo = Console.ReadLine();
        a = double.Parse(articulo);

        Console.WriteLine("Efectivo a introducir");
        efectivo = Console.ReadLine();
        b = double.Parse(efectivo);

        cambio = M1.Restar(a, b);
        Console.Write("Su cambio es ");
        Console.WriteLine(cambio);

        Console.WriteLine("Gracias por su compra en oxxo");

    }

    public class maquinadecambio

    {
        public double Restar(double a, double b)

        {

            double c;
            c = b - a;
            return c;

        }


    }
















}
