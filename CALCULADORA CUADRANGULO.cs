using System;

class Cuadrilatero {

static void Main() {
    
    
    double resultado;
    string respuesta; 
    double n1, n2;
    
    Calculadora C1 = new Calculadora(); // Creo mi objeto
    
    Console.Write("Escribe la altura de tu figura: "); // Pide un número
    respuesta = Console.ReadLine(); // Lee el valor tecleado por el usuario
    n1 = double.Parse(respuesta); // Convierte respuesta (string) a número double
    
    Console.Write("Escribe el ancho de tu figura: "); // Pide otro número
    respuesta = Console.ReadLine(); // Lee el valor tecleado por el usuario
    n2 = double.Parse(respuesta); // Convierte respuesta (string) a número double 
    
    resultado = C1.Multiplicar(n1,n2);
    Console.Write("El area de su figura es: ");
    Console.WriteLine(resultado);
    
    resultado = C1.Sumar(n1,n2);
    Console.Write("El perimetro de su figura es: ");
    Console.WriteLine(resultado);
    
    Console.WriteLine("este programador junior necesita asesorías :c ");
}
    
}
public class Calculadora
{

    
    public double Sumar( double n1, double n2 )
    {
        double n3;
        
        n3 = (n1 +  n2)*2 ;
        return  n3;
        
    }
    
    
    public double Multiplicar( double n1, double n2 )
    {
        double n3;
        
        n3 = n1 *  n2;
        return  n3;
    }
    
    

}
 