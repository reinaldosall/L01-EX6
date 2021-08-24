using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    6- O restaurante  a  quilo  Bem-Bão  cobra R$12,00  por  cada quilo  de  refeição. 
     Escreva um programa em  C# que leia o peso do prato montado pelo cliente (em quilos) 
     e imprima o valor a pagar. Assuma que a balança já desconte o peso do prato. 
    */
    
    Console.WriteLine ("Digite o peso do prato");
    float pesoServido = float.Parse(Console.ReadLine());

    float valorTotal = pesoServido * 12.0f;

    Console.WriteLine ($"O valor total da refeição é: R$ {valorTotal} ");
  }
}