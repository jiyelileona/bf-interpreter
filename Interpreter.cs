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
    public void Start()
    {
      int count = 0;
      for (int i = 0; i < this.input.Length; i++)
      {
        switch (input[i])
        {
          case '>':
            this.pointer++;
            break;
          case '<':
            this.pointer--;
            break;
          case '+':
            tape[pointer]++;
            break;
          case '-':
            tape[pointer]--;
            break;
          case '.':
            Console.Write(Convert.ToChar(tape[pointer]));
            break;
          case ',':
            tape[pointer] = (byte)Console.ReadKey().KeyChar;
            break;
          case '[':
            if (tape[pointer] == 0)
            {
              count++;
              while (input[i] != ']' || count != 0)
              {
                i++;
                if (input[i] == '[') count++;
                else if (input[i] == ']') count--;
              }
            }
            break;
          case ']':
            if (tape[pointer] != 0)
            {
              count++;
              while (input[i] != '[' || count != 0)
              {
                i--;
                if (input[i] == ']') count++;
                else if (input[i] == '[') count--;
              }
            }
            break;
        }
      }
    }
  }
}
