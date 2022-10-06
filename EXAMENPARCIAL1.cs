/* Se requiere hacer un programa en C# usando clases, que sea capaz de calcular el costo de viajar en un 
crucero por el caribe. El costo del viaje es de $1,900 pesos por persona por día de viaje, si son adultos, y de 
$1,100 pesos por día si son menores de edad. Adicional se requiere que el mismo programa calcule la 
cantidad de camarotes que necesitan ocupar. El cupo máximo de cada camarote es de 5 personas sin 
importar si son adultos o menores. Por ejemplo, 7 adultos y 4 menores implican 3 habitaciones ya que en 
cada una alcanzan un máximo de 5 personas. Se requiere que el resultado de las habitaciones se dé en cifras 
enteras. No se puede dar como resultado, por ejemplo, 2.1 camarotes. Se debe indicar el siguiente entero 
mayor, es decir, 3 para este ejemplo.*/

using System;

class parcial
{

    static void Main ()
    {
        string dias, adultos, niños;
        double resultadoa, resultadob, resultadoc, a, b;

        agencia a1 = new agencia ();
        camarote b2 = new camarote ();

        Console.WriteLine("Caribbean Travel Agency");
        Console.WriteLine("Introduzca el nº de días de su viaje");
        dias = Console.ReadLine();
        resultadoa = double.Parse(dias);

        Console.WriteLine("Introduza el nº de adultos en su viaje");
        adultos = Console.ReadLine();
        resultadob = double.Parse(adultos);

        Console.WriteLine("Introduzca el nº de niños en su viaje");
        niños = Console.ReadLine();
        resultadoc = double.Parse (niños);

    a = a1.convert(resultadoa, resultadob, resultadoc);
    Console.Write("Su tarifa total de viaje será de: ");
    Console.WriteLine(a + " Mxn");

    b = b2.cuartos(resultadob, resultadoc);
    Console.Write("Usted requerirá de: ");
    Console.WriteLine(b + " Camarote");

Console.WriteLine("Feliz porque fuí de las pocas personas que no le pasaron el código y no buscó pretender saber hacer las cosas");

    }

}

public class agencia 
{

public double convert (double resultadoa, double resultadob, double resultadoc)
{

double a, b, c, f; 
b = (resultadob * 1900);
c = (resultadoc * 1100);
a = b + c;
f = a * resultadoa;
return f; 

}

}
 
public class camarote 
{
public double cuartos (double resultadob, double resultadoc)
{

double c, d; 
c = resultadob + resultadoc;
d = (Math.Ceiling(c / 5));
return d; 

}

}
