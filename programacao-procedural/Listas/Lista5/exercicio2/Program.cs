﻿using System;

class Program
{
  static void Main(string[] args)
  {
    for (int i = 10; i > 0; i--)
    {
      for (int j = 0; j <= 10; j++)
      {
        Console.WriteLine($"{i} x {j} = {i * j}");
      }
      Console.WriteLine();
    }
  }
}