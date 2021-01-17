using System;

class PizzaAntesDoFinalDoAno 
{
    static void Main()
    {  
        string[] line = Console.ReadLine().Split(" ");
        
        int N = int.Parse(line[0]);
        int D = int.Parse(line[1]);
        
        string data = "";
        
        int qtd = 0;
        
        bool achou = false;

        for (int dt=0; dt<D; dt++) 
        {
          qtd = 0;

          string[] dados = Console.ReadLine().Split(" ");
          
          data =  dados[0];
          
          for (int p=1; p<N+1; p++)
          {
              qtd += int.Parse( dados[p] );
          }

          achou = ( qtd == N);
          
          if (achou) 
          { 
              break; 
          }
        } 
        
        if (achou)
        { 
            Console.Write(data); 
        }
        else 
        { 
            Console.Write("Pizza antes de FdA"); 
        }
    }
}