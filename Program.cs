using System;    

public class Program {
    public static void Main (string[] args) {    

        DateTime dateTimeExemple = new DateTime(2008, 6, 11);
        DateTime dateValue = dateTimeExemple;
        DateTime dayInMonth = System.DateTime.DaysInMonth(ConvertToInt32(dateTimeExemple.Year), ConvertToInt32(dateTimeExemple.Month));
        Console.WriteLine(dateValue.ToString("dddd"));
  }
}  