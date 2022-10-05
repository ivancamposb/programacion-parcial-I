using System; 
class ejercicio7
{
static void Main ()
 
 {
   string gramos, viaje;
   double kilogramos, conver, r;
  
  conversion c1 = new conversion ();

  Console.WriteLine("Hola! Soy charles, un sistema inteligente de conversión, déjame ayudarte");
  Console.WriteLine("Introduzca el tiempo de viaje");
  viaje = Console.ReadLine();
  conver = double.Parse(viaje);

  Console.WriteLine("Introduzca en gramos el consumo de su mascota");
  gramos = Console.ReadLine();
  kilogramos = double.Parse(gramos);
  
  r = c1.kilo(kilogramos, conver);
  Console.Write("Usted debe dejarle a su mascota  ");
  Console.WriteLine(r + " Kilos " + "De acuerdo a su relación de viaje");

  Console.WriteLine("Disfrute su viaje!");


 }

}
public class conversion {

  public double kilo(double kilogramos, double conver)
  {
     double h;
     h = (conver * kilogramos)* 0.001;
     return h;
  }

}