using System;

class TempoDoDobby 
{
    public static void Main (string[] args) 
    {
    int n = int.Parse(Console.ReadLine());
    string[] texto = Console.ReadLine().Split(" ");
    
    int x = int.Parse(texto[0]), y = int.Parse(texto[1]);
    int calc = x + y;
    
    if (calc > n) 
    {
      Console.Write("Deixa para amanha!");
    } 
    else 
    {
      Console.Write("Farei hoje!");
    }   
  }
}