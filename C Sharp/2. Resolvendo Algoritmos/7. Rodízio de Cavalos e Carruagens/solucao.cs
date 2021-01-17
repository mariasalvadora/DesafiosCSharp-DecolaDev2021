using System;
using System.Text.RegularExpressions;

class RodizioDeCavalosECarruagens 
{
  public static void Main (string[] args) 
  {
    var N = int.Parse(Console.ReadLine());

    Regex rgx = new Regex(@"^[A-Z][A-Z][A-Z]-[0-9][0-9][0-9][0-9]$");

    for (var i = 1; i <= N; i++)
    {
      string placa = Console.ReadLine();

      if (rgx.IsMatch(placa) == false)
      {
        Console.WriteLine("FALHA");
      }
      else
      {
        switch (placa[7])
        {
            case '1':
            case '2':
              Console.WriteLine("SEGUNDA");
              break;
            case '3':
            case '4':
                Console.WriteLine("TERCA");
                break;
            case '5':
            case '6':
                Console.WriteLine("QUARTA");
                break;
            case '7':
            case '8':
                Console.WriteLine("QUINTA");
                break;
            case '9':
            case '0':
                Console.WriteLine("SEXTA");
                break;
        }
      }
    }
  }
}