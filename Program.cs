using System;

namespace RPS
{
  class Program
  {
    static void Main(string[] args)
    {
      var game = new Game();
      Console.Clear();
      game.Start();
    }
  }
}
