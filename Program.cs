using System;

public class Program
{
    public static void Main(string[] args)
    {


    Inicio:
        // variavel usada para repetição
        String rep;
        Calendario c = new Calendario();
        Console.WriteLine("Insira o ano desejado: ");
        c.Ano = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Insira o mes desejado: ");
        c.Mes = Convert.ToByte(Console.ReadLine());
        DateTime dateTimeExemple = new DateTime(2005, 3, 1);
        string nameMonth = dateTimeExemple.ToString("MMMM");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("D\tS\tT\tQ\tQ\tS\tS");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine(c.gerarCalendario());
        // estrutura usada para decidir se o usuario ira repetir
        Console.WriteLine("Deseja iniciar o programa novamente(y/n): ");
        rep = Console.ReadLine();
        if (rep == "y")
        {
            goto Inicio;
        }
        else { }

    }
}