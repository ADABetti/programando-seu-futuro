﻿using System;

class Program
{
  static void Main(string[] args)
  {
    System.Console.WriteLine("Qual o tamanho do quadrado?");
    int tamanhoQuadrado = int.Parse(Console.ReadLine());

    for (int linha = 0; linha < tamanhoQuadrado; linha++)
    {
      for (int coluna = 0; coluna < tamanhoQuadrado; coluna++)
      {
        Console.Write("*"); //Imprime todos os asteriscos de uma coluna na mesma linha
      }
      Console.WriteLine(); //Pula linha depois de sair do primeiro laço de repetição;

    }
  }
}