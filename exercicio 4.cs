using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("<-----Atividade 1----->");
    Console.WriteLine ("Nicole Vargas Zanotto");

    Console.WriteLine ("<-----Atividade 2: subtração de dois números----->");

  // DECLARAÇÃO DE VARIAVEIS
    double num1=0, num2=0, sub=0, m=0;
    
  // ENTRADA DE DADOS
    Console.WriteLine ("Digite o primeiro numero : ");
    num1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o segundo numero : ");
    num2 = double.Parse(Console.ReadLine());
    
  // PROCESSAMENTO
    sub = num1 - num2;

  // SAÍDA
     Console.WriteLine ("O resultado da subtração dos dois números é: {0} - {1} = {2}", num1, num2, sub);

    Console.WriteLine ("<-----Atividade 2: O quadrado de cada número----->");

    // DECLARAÇÃO DE VARIAVEIS
    double quadrado1=0, quadrado2=0;

    //PROCESSAMENTO
    quadrado1 = num1*num1;
    quadrado2 = num2*num2;

  // SAIDA
    Console.WriteLine("O quadrado de {0} é igual {1}", num1, quadrado1);
    Console.WriteLine("O quadrado de {0} é igual a {1}", num2, quadrado2);

  Console.WriteLine ("<-----Atividade 2: A média dos dois números----->");

     //PROCESSAMENTO
      m = (num1+num2) / 2;
    
    // SAIDA DE DADOS
  Console.WriteLine("Então, a média dos números digitados é igual a {0}", m);
    
    
  }
}
