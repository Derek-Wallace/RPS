using System;

namespace RPS
{
  class Game
  {
    private string _compChoice = " ";
    private bool _playing = true;
    private int _wins = 0;
    private int _loses = 0;
    public string UserChoice { get; set; } = " ";
    public void Start()
    {
      Console.Clear();
      var r = new Random();
      int num = r.Next(0, 10);
      if (num <= 4) 
      {
        _compChoice = "Rock";
      }
      else if(num < 7)
      {
        _compChoice = "Paper";
      }
      else if (num <= 10)
      {
        _compChoice = "Scissors";
      }
      Console.WriteLine("Rock Paper Scissors");
      Console.WriteLine($"Record: {_wins} - {_loses}");
      PlayGame();
    }
    public void PlayGame()
    {
      while(_playing)
      {
        Console.Write("Choice: ");
        UserChoice = Console.ReadLine().ToUpper();

        if (UserChoice == "QUIT")
        {
          _playing = false;
          Console.WriteLine("bye");
          return;
        }
        if (UserChoice == "ROCK" && _compChoice == "Scissors" || UserChoice == "PAPER" && _compChoice == "Rock" || UserChoice == "SCISSORS" && _compChoice == "Paper")
        {
          Console.WriteLine("You Win");
          _wins++;
          Console.ReadKey();
          Start();
        }
        else Console.WriteLine("You Lose");
        _loses++;
        Console.ReadKey();
        Start();
      }
    }
  }
}