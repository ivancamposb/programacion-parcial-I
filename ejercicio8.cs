using System; 
class ejercicio8
{
static void Main ()
{
string salario;
double a, b;

aguinaldo1 a1 = new aguinaldo1 ();

Console.WriteLine("Hola usuario! Soy charles un sistema inteligente de conversión, déjame ayudarte");
Console.WriteLine("Introduzca su salario mensual");
salario = Console.ReadLine();
a = double.Parse(salario);

   b = a1.conversion(a);
   Console.WriteLine("Su aguinaldo correspondiente para el mes de diciembre es:  ");
   Console.WriteLine(b + " mxn ");

   Console.WriteLine("Feliz Navidad!");

}

}

public class aguinaldo1
{

public double conversion (double a)

{
 double j;
 j = a / 2;
 return j;
}

}