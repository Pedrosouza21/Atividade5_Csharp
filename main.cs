using System;

class MainClass{
  public static void Main (string[] args) 
    
  {
   // variavel utilizada
   double a,b,c;
   Console.WriteLine("Calculadora para calcular a troca de variável.");
   Console.WriteLine("Digite o valor da variavel a: ");
   a = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o valor da variavel b: ");
   b = double.Parse(Console.ReadLine());
   c = a;
   a = b;
   b = c;

   Console.WriteLine("variavel a: {0} ",a);
   Console.WriteLine("variavel b: {0} ", b);
   
   
  }
}
  



    

