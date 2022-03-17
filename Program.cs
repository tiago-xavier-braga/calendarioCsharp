using System;    

public class Program {
    public static void Main (string[] args) {    

        DateTime dateTimeExemple = new DateTime(2020, 8, 1);
        

        int yearDate = dateTimeExemple.Year;
        int monthDate = dateTimeExemple.Month; 
        int dayInMonth = System.DateTime.DaysInMonth(yearDate, monthDate);

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("D\tS\tT\tQ\tQ\tS\tS");
        Console.WriteLine("---------------------------------------------------");
        
        if(dateTimeExemple.ToString("dddd") == "segunda-feira"){
          Console.Write("\t");
        } else if (dateTimeExemple.ToString("dddd") == "terça-feira"){
          Console.Write("\t\t");
        } else if (dateTimeExemple.ToString("dddd") == "quarta-feira"){
          Console.Write("\t\t\t");
        } else if (dateTimeExemple.ToString("dddd") == "quinta-feira"){
          Console.Write("\t\t\t\t");
        } else if (dateTimeExemple.ToString("dddd") == "sexta-feira"){
          Console.Write("\t\t\t\t\t");
        } else if (dateTimeExemple.ToString("dddd") == "sábado"){
          Console.Write("\t\t\t\t\t\t");
        }

        for(int i = 1; i <= dayInMonth; i++){

          Console.Write(i);
          Console.Write("\t");

          if(i % 7 == 0){
            Console.Write("\n");
          }
        }

        Console.Write("\n");
        Console.WriteLine(dateTimeExemple.ToString("dddd"));
        //Console.WriteLine(dayInMonth);
  }
}  