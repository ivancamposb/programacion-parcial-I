using System; 

class ejercicio4

{
    
    static void Main () 
   
    {
        string Nombres, Apellidos, Cambio; 
        
        Alreves A = new Alreves();
        
        Console.WriteLine("Escribe tu nombre");
        Nombres = Console.ReadLine();
        
        Console.WriteLine("Escribe tu apellido");
        Apellidos = Console.ReadLine(); 
        
        Cambio = A.Cambiar(Nombres, Apellidos);
        Console.Write("Tu nombre completo es: ");
        Console.WriteLine(Cambio);
        
        
        Cambio = A.Kambiar(Nombres, Apellidos);
        Console.Write ("Tu nombre al revés es: ");
        Console.WriteLine(Cambio);
        
        
        
    }
    
    public class Alreves {
    
    public string Cambiar(string Nombres, string Apellidos) 
    
    {
        
        string Cambio; 
        
        Cambio = (Nombres + Apellidos);
        return Cambio;
        
    }
    
    public string Kambiar(string Nombres, string Apellidos)
   
    {
        
    
    string Kambio;
    
    Kambio = (Apellidos + Nombres);
    return Kambio;
       }
     
    }
}
    


