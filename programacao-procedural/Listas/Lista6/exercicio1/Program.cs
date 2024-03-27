﻿using System;
using System.Security.AccessControl;

class Program
{
  static void Main(string[] args)
  {
    const int QUANTIDADE_NOMES = 10;
    string[] nomes = new string[QUANTIDADE_NOMES];

    for (int contador = 0; contador < QUANTIDADE_NOMES; contador++)
    {
      Console.WriteLine("Digite o nome da pessoa: ");
      nomes[contador] = Console.ReadLine();
    }
    Console.WriteLine("Consulte o nome de alguem: ");
    string nomeConsultado = Console.ReadLine();
    bool nomeNaLista = false;

    for (int contador = 0; contador < QUANTIDADE_NOMES; contador++)
    {
      if (nomes[contador] == nomeConsultado)
      {
        nomeNaLista = true;
      }
    }

    if (nomeNaLista)
    {
      Console.WriteLine("ACHEI");
    }
    else
    {
      Console.WriteLine("NAO ACHEI");
    }
  }
}
