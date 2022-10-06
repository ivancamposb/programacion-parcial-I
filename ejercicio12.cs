/* Se requiere hacer un algoritmo que sea capaz de calcular en cuanto tiempo (en horas) una persona 
puede ingresar a una clínica para recibir su vacuna contra COVID-19 a partir de lo siguiente:
-En la cola hay una cantidad variable de personas delante del sujeto del problema
- Las personas ingresan a la clínica en grupos de 15 cada hora */
using System; 

class ejercicio12
{
static void Main ()
{
 string personas;
 double horas, covid;

 clinica c1 = new clinica ();


 Console.WriteLine("COVID-19 TIEMPO ESTIMADO DE ESPERA");
 Console.WriteLine("Introduzca el nº de personas delante de usted");
 personas = Console.ReadLine();
 covid = double.Parse(personas);

horas = c1.espera(covid);
Console.Write("Su tiempo estimado de espera será de:  ");
Console.WriteLine(horas + "  Hrs.");

Console.WriteLine("COVID-19 @");
 

}




}

public class clinica 
{
public double espera (double covid)
{
double a; 
a = (Math.Ceiling(covid / 15)) * 1;
return a;

}


}
