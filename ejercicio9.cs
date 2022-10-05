using System; 

class ejercicio9
{
static void Main ()
{

string salario; 
double resultado, diario;

maquinadeconversion m1 = new maquinadeconversion ();

Console.WriteLine("Hola, soy charle un sistema inteligente de conversión déjame ayudarte");
Console.WriteLine("Introduzca su salario diario bruto");
salario = Console.ReadLine();
diario = double.Parse(salario);

resultado = m1.monto(diario);
Console.Write("Su salario Mensual neto es:  ");
Console.WriteLine( resultado + " mxn " + "  Tomando en cuenta el ISPT menos el préstamo quincenal  ");

Console.WriteLine("Gracias por sus servicios");


}


}

public class maquinadeconversion 
{
 public double monto ( double diario)
 {
    double a, b , c;
    a = (diario * 30); 
    b = a * .75;
    c = b - 400;
    return c; 
 }
}
