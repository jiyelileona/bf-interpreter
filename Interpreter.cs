using System;

namespace bfInterpreter
{
  class Interpreter
  {
    public char[] input { get; set; }
    public byte[] tape { get; set; }
    public int pointer { get; set; }
    public Interpreter(string input)
    {
      this.input = input.ToCharArray();
      this.tape = new byte[30000];
    }
  }
}
