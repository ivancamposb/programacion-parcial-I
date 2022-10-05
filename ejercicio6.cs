using System;

class ejercicio6
{
    static void Main()
    {
        string recibo;
        double litros, metros;

        maquinadeconversion m1 = new maquinadeconversion();

        Console.WriteLine("Conoce tu consumo en litros!");
        Console.WriteLine("Hola derechohabiente");
        Console.WriteLine("Digite su consumo mensual del agua, que aparece en su recibo");
        recibo = Console.ReadLine();
        metros = double.Parse(recibo);

        litros = m1.conversion(metros);
        Console.Write("Su consumo en litros fue de:  ");
        Console.WriteLine(litros + " Litros ");

        Console.WriteLine("Gracias por su preferencia");
    }

}

public class maquinadeconversion
{
    public double conversion(double metros)
    {
        double c;
        c = metros * 1000;
        return c;
    }
}
