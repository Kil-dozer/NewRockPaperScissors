using System;

namespace NewRockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 0;
      // Welcome User and user var
      Console.WriteLine("Greetings! Please tell me your name");
      var user = Console.ReadLine();
      // Do they know how to play?
      Console.WriteLine("Thanks " + user + ", do you know how to play rock-paper-scissors? Yes or no?");
      var answer = Console.ReadLine();
      if (answer == "no")
      {
        Console.WriteLine("Bummer! Well that's my purpose, so I guess we're done here.");
      }
      else
        // While attempt 
        while (n == 0)
        {
          // Select Difficulty 
          Console.WriteLine("Please Select a difficulty mode, easy, normal, or impossible.");
          var gameMode = Console.ReadLine();
          Console.WriteLine("Game on! You've chosen " + gameMode + " mode. Choose rock, paper, or scissors.");
          // Store user selection
          var hFight = (Console.ReadLine());
          // Confirm user choice
          Console.WriteLine("You've chosen " + hFight);
          string[] choices = { "rock", "paper", "scissors" };
          // Easy mode
          if (gameMode == "easy")
          {
            if (hFight == "rock")
              Console.WriteLine("Let's fight! I picked scissors");
            if (hFight == "scissors")
              Console.WriteLine("Let's fight! I picked paper");
            if (hFight == "paper")
              Console.WriteLine("Let's fight! I picked rock");
            Console.WriteLine("You win!");
          }
          // Cheating Mode
          else if (gameMode == "impossible")
          {
            if (hFight == "rock")
              Console.WriteLine("Let's fight! I picked paper");
            if (hFight == "scissors")
              Console.WriteLine("Let's fight! I picked rock");
            if (hFight == "paper")
              Console.WriteLine("Let's fight! I picked scissors");
            Console.WriteLine("I win! Better luck next time!");
          }
          else
          {
            // Create computer choice
            Random rnd = new Random();
            int cIndex = rnd.Next(choices.Length);
            var cFight = (choices[cIndex]);
            // To battlestations!
            Console.WriteLine("Lets fight! I picked " + cFight + ".");
            if (hFight == "rock" && cFight == "paper")
              Console.WriteLine("I win! Better luck next time.");
            if (hFight == "rock" && cFight == "scissors")
              Console.WriteLine("You win!");
            if (hFight == "rock" && cFight == "rock")
              Console.WriteLine("We're equally matched!");
            if (hFight == "paper" && cFight == "rock")
              Console.WriteLine("You win!");
            if (hFight == "paper" && cFight == "scissors")
              Console.WriteLine("I win! Better luck next time.");
            if (hFight == "paper" && cFight == "paper")
              Console.WriteLine("We're equally matched!");
            if (hFight == "scissors" && cFight == "paper")
              Console.WriteLine("You win!");
            if (hFight == "scissors" && cFight == "scissors")
              Console.WriteLine("We're equally matched!");
            if (hFight == "scissors" && cFight == "rock")
              Console.WriteLine("I win! Better luck next time.");
          }
          Console.WriteLine("Would you like to play again? Yes or no.");
          var donePlaying = Console.ReadLine();
          if (donePlaying == "no")
          {
            n = n + 1;
            Console.WriteLine("Thanks for playing!");
          }
        }
    }
  }
}