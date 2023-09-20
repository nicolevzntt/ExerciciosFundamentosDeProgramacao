using System;

class Program {
  public static void Main (string[] args) {

   
   // DECLARAÇÃO DE VARIAVEIS
  double a= 0;
  double b= 0;
  double c= 0;
  double d= 0;
  double x1= 0;
  double x2= 0;

  // ENTRADA DE DADOS
    Console.WriteLine ( "Informe o valor de a:");
    a= double.Parse(Console.ReadLine());
    Console.WriteLine ( "Informe o valor de b:");
    b= double.Parse(Console.ReadLine());
    Console.WriteLine ( "Informe o valor de c:");
    c= double.Parse(Console.ReadLine());

  // PROCESSAMENTO
    d= (b*b - 4 * a *c);
    x1 = (-b + Math.Sqrt(d)) /(2*a);
    x2 = (-b - Math.Sqrt(d)) / (2*a);

  // SAIDA
    Console.WriteLine("a={0}, b= {1}, c={2}", a,b,c);
    Console.WriteLine("x1={0}",x1);
    Console.WriteLine("x2={0}",x2);

  }
}
