/* Se requiere hacer un algoritmo que sea capaz de calcular cuantas calorías ha perdido o ganado 
una persona luego de salir a correr y luego desayunar. Al correr la persona pierde 150 calorías por 
cada 2 kilómetros que recorre. El desayuno, dependiendo del alimento tiene una cantidad variable 
de calorías. */

using System;

class ejercicio11 
{
static void Main()
{

string d, calorias, kilometros;
double alimento, km, resultado, resultadoa;

maquina m1 = new maquina ();
desayuno d1 = new desayuno ();

Console.WriteLine("Fitness Center System");
Console.WriteLine("Introduzca los km recorridos esta mañana");
kilometros = Console.ReadLine();
km = double.Parse(kilometros);

Console.WriteLine("¿Cuántas calorías ha consumido hoy en el desayuno?");
calorias = Console.ReadLine();
alimento = double.Parse(calorias);

resultado = m1.perdida(km);
Console.Write("Usted ha perdido corriendo: ");
Console.WriteLine(resultado + " Kcal");

resultadoa = d1.ganancia(alimento, resultado);
if (resultadoa <= -1)
{
    Console.WriteLine("Usted ha perdido en total " + resultadoa + "  Kcal");
}
else if (resultadoa >= 1)
{
Console.WriteLine("Usted ha ganando en total " + resultadoa + " Kcal");
}


}
}

public class maquina 
{
public double perdida (double km)
{
double h;
h = (km * 75);
return h; 
}

}

public class desayuno 
{

public double ganancia(double alimento, double resultado)
{
double f;
f = (alimento - resultado);
return f;
}

}

