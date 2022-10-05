using System;

class Primerdiadeclases {

    static void Main() {
    
    
    double resultado;
    string respuesta; 
    double n1, n2;
    
    Calculadora C1 = new Calculadora(); // Creo mi objeto 
    
    Console.WriteLine("Teclea un número: "); // Pide un número
    respuesta = Console.ReadLine(); // Lee el valor tecleado por el usuario
    n1 = double.Parse(respuesta); // Convierte respuesta (string) a número double
    
    Console.WriteLine("Teclea otro número: "); // Pide otro número
    respuesta = Console.ReadLine(); // Lee el valor tecleado por el usuario
    n2 = double.Parse(respuesta); // Convierte respuesta (string) a número double 
    
    resultado = C1.Sumar(n1,n2);
    Console.Write("El resultado de la suma es: ");
    Console.WriteLine(resultado);
    
    resultado = C1.Restar(n1,n2);
    Console.Write("El resultado de la resta es: ");
    Console.WriteLine(resultado);
    
    resultado = C1.Multiplicar(n1,n2);
    Console.Write("El resultado de la multiplicacion es: ");
    Console.WriteLine(resultado);
    
    resultado = C1.Dividir(n1,n2);
    Console.Write("El resultado de la division es: ");
    Console.WriteLine(resultado);

        Console.WriteLine("Paciencia");
}
    
}
public class Calculadora
{
    
    public double Sumar ( double n1, double n2 )
    {
        double n3;
        
        n3 = n1 +  n2;
        return  n3;
        
    }
    
    
    public double Restar( double n1, double n2 )
    {
        double n3;
        
        n3 = n1 -  n2;
        return  n3;
    }
    
    
    public double Multiplicar( double n1, double n2 )
    {
        double n3;
        
        n3 = n1 *  n2;
        return  n3;
    }
    
    
    public double Dividir ( double n1, double n2 )
    {
        double n3;
        
        n3 = n1 /  n2;
        return  n3;
    }
}