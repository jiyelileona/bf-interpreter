using System;

namespace bfInterpreter
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = System.IO.File.ReadAllText(@".\input.bf");

      Interpreter bf = new Interpreter(str);
      
      bf.Start();
    }
  }
}
