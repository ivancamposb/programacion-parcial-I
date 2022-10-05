using System;
class PROGRAM
 {

static void Main ()

{
    
    
    double resultado;
    string respuesta; 
    double n1, n2, S1, S2, S3, BT, AT, Radio;
    
    Calculadora C1 = new Calculadora(); 
    CalculadoraT C2 = new CalculadoraT();
    CalculadoraC C3 = new CalculadoraC();
    
    Console.WriteLine("Hi user! Let's calculate");
    
    Console.Write("Enter the heigh of a quadrilateral: ");
    respuesta=Console.ReadLine(); 
    n1 = double.Parse(respuesta); 
    
    Console.Write("Enter the base of a quadrilateral: ");
    respuesta=Console.ReadLine(); 
    n2 = double.Parse(respuesta);  

    Console.WriteLine("Enter the first side of a triangle");
    respuesta=Console.ReadLine();
    S1 = double.Parse(respuesta);

    Console.WriteLine("Enter the second side of a triangle ");
    respuesta=Console.ReadLine();
    S2 = double.Parse(respuesta);

    Console.WriteLine("Enter the third side of a triangle");
    respuesta=Console.ReadLine();
    S3 = double.Parse(respuesta);

    Console.WriteLine("Enter the height of a triangle");
    respuesta=Console.ReadLine();
    AT = double.Parse(respuesta);

    Console.WriteLine("Enter the base of a triangle");
    respuesta=Console.ReadLine();
    BT = double.Parse(respuesta);

    Console.WriteLine("Enter the radius of a circle");
    respuesta=Console.ReadLine();
    Radio = double.Parse(respuesta);

    
    resultado = C1.Sumar(n1,n2);
    Console.Write("The perimeter of a quadrilateral is: ");
    Console.WriteLine(resultado);
    
    resultado = C1.Multiplicacion(n1,n2);
    Console.Write(" The area of a quadrilateral is:  ");
    Console.WriteLine(resultado);

    resultado = C2.PerimetroT(S1,S2,S3);
    Console.Write("The perimeter of a quadrilateral is:  ");
    Console.WriteLine(resultado);

    resultado = C2.AreaT(BT,AT);
    Console.Write("The area of a triangle is:  ");
    Console.WriteLine(resultado);

    resultado = C3.AreaC(Radio);
    Console.Write("The area of a circle is: ");
    Console.WriteLine(resultado);

   resultado = C3.PerimetroC(Radio);
    Console.Write("The perimeter of a circle is:  ");
    Console.WriteLine(resultado);
    
    Console.WriteLine("Awesome user, see u around! ");
    
}
    
}


public class Calculadora
{
    double memoria;
    
    public double Sumar ( double n1, double n2 )
    {
        double n3;
        
        n3 = (n1 +  n2)*2;
        return  n3;
        
    }
    
    
    public double Multiplicacion ( double n1, double n2 )
    {
        double n3;
        
        n3 = n1 * n2;
        return  n3;
    }
    
}
public class CalculadoraT
{
   public double PerimetroT(double S1, double S2, double S3)
   {
      double n3;

      n3 = S1+S2+S3;
      return n3;

   }

  public double AreaT(double BT, double AT)
  {
   double n3;

   n3 = (BT*AT)/2;
   return n3;

  }

   

}
public class CalculadoraC
{
   public double AreaC(double Radio)
   {
      double n3;

      n3 = (Radio*Radio)*Math.PI;
      return n3;
   }
   public double PerimetroC(double Radio)
   {
      double n3;

      n3 = (2*Radio)*Math.PI;
      return n3;
   }


}
