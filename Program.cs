using System;    

public class Program {
    public static void Main (string[] args) {    

        DateTime dateTimeExemple = new DateTime(2020, 8, 1);
        

        int yearDate = dateTimeExemple.Year;
        int monthDate = dateTimeExemple.Month; 
        int dayInMonth = System.DateTime.DaysInMonth(yearDate, monthDate);
        int dayInMonthNumber = 0;
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("D\tS\tT\tQ\tQ\tS\tS");
        Console.WriteLine("---------------------------------------------------");
        
        if(dateTimeExemple.ToString("dddd") == "segunda-feira"){
          Console.Write("\t");
          dayInMonthNumber = 2;
        } else if (dateTimeExemple.ToString("dddd") == "terça-feira"){
          Console.Write("\t\t");
          dayInMonthNumber = 3;
        } else if (dateTimeExemple.ToString("dddd") == "quarta-feira"){
          Console.Write("\t\t\t");
          dayInMonthNumber = 4;
        } else if (dateTimeExemple.ToString("dddd") == "quinta-feira"){
          Console.Write("\t\t\t\t");
          dayInMonthNumber = 5;
        } else if (dateTimeExemple.ToString("dddd") == "sexta-feira"){
          Console.Write("\t\t\t\t\t");
          dayInMonthNumber = 6;
        } else if (dateTimeExemple.ToString("dddd") == "sábado"){
          Console.Write("\t\t\t\t\t\t");
          dayInMonthNumber = 7;
        } else {
          dayInMonthNumber = 1;
        }

        int j = dayInMonthNumber; 
        for(int i = 1; i <= dayInMonth; i++){
          Console.Write(i);
          Console.Write("\t");

          if(j % 7 == 0){
            Console.Write("\n");
          }
          j+=1;
        }
        
        Console.Write("\n");
        //Console.WriteLine(dateTimeExemple.ToString("dddd"));
        //Console.WriteLine(dayInMonth);
  }
}  