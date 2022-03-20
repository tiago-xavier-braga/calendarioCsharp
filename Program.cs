using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
    Inicio:
        Calendario c = new Calendario();
        Ano:
        Console.WriteLine("Insira o ano desejado: ");
        c.Ano = Convert.ToUInt16(Console.ReadLine());
        Boolean anovalidate = c.isAnoValido();
        if (anovalidate == false)
        {
            Console.WriteLine("Insira um ano válido de 1 a 9999");
            goto Ano;
        }
        else
        {
        }
        Mes:
        Console.WriteLine("Insira o mes desejado: ");
        c.Mes = Convert.ToByte(Console.ReadLine());
        Boolean mesvalidate = c.isMesValido();
        if (mesvalidate == false)
        {
            Console.WriteLine("Insira um mes de 1 a 12");
            goto Mes;
        }
        else { }
        DateTime dateTime = new DateTime(c.Ano, c.Mes, 1);
        string nameMonth = dateTime.ToString("MMMM");
        string nameMes = nameMonth.Substring(0, 1).ToUpper() + nameMonth.Substring(1);
        Console.WriteLine("\n \t \t" + nameMes + " de " + c.Ano);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("D\tS\tT\tQ\tQ\tS\tS");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine(c.gerarCalendario());
        // estrutura usada para decidir se o usuario ira repetir
        String rep;
        Console.WriteLine("Deseja iniciar o programa novamente(y/n): ");
        rep = Console.ReadLine();
        if (rep == "y")
        {
            goto Inicio;
        }
        else { }

    }
}