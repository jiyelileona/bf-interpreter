﻿using System;

namespace bfInterpreter
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = System.IO.File.ReadAllText(@".\input.bf");

      System.Console.WriteLine(str);
    }
  }
}
