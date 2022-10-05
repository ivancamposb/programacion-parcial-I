/* Se requiere hacer un algoritmo que sea capaz de calcular el tiempo que un piloto de Fórmula 1 
pierde al entrar a los boxes para cambio de neumáticos. Se sabe que todo el recorrido de los boxes 
tanto al entrar como al salir le lleva 28 segundos. El cambio de neumáticos es variable. */

using System;
class ejercicio10
{

static void Main () 
{

string pilot;
double pits, veces; 

maquinadeconversion m1 = new maquinadeconversion (); 
Console.WriteLine("Formula I");
Console.WriteLine("Su registro de hoy, ha sido de 28 segundos en los pits");

Console.WriteLine("Introduzca Nº veces que ha ingresado durante la carrera al cambio de neumáticos");
pilot = Console.ReadLine();
veces = double.Parse(pilot);

pits = m1.suma(veces);
Console.Write("Su registro por cambio de neumaticos es de : ");
Console.WriteLine(pits + " Segundos ");

Console.WriteLine("Excelente carrera piloto!");


}

}

public class maquinadeconversion
{
public double suma (double veces)
{
    double j;
    j = (Math.Ceiling(28 / veces));
    return j;

}

}
