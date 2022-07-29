using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      StartGame();
    }

    static void StartGame()
    {
      //Intro and Instructions
      Console.WriteLine("Welcome to Exquisite Courpse. Where you can build any hybrid creature or non-hybrid creature you desire.");
      Console.WriteLine("To start, would you like us to build a creature or would you like to build your own creature?");
      Console.Write("Type YOU or ME: ");

      //User Variable
      string mode = Console.ReadLine().ToUpper();

      //Play selected mode
      PlayMode(mode);
    }

    static void StartGame(bool unknownMode)
    {
      Console.WriteLine("Let's try this again... Remember SPELLING MATTERS.");
      Console.WriteLine("To start, would you like us to build a creature or would you like to build your own creature?");
      Console.Write("Type YOU or ME: ");

      //User Variable
      string mode = Console.ReadLine().ToUpper();

      //Play selected mode
      PlayMode(mode);
    }

    static void PlayMode(string mode)
    {
      switch(mode)
      {
        case "YOU":
          Console.WriteLine("Very well, we will create a random creature! \n3 \n2 \n1...");
          RandomMode();
          break;
        case "ME":
          Console.WriteLine("You have choosen to create your own hybrid... Interesting, lets see what you're made of...");
          CustomMode();
          break;
        default:
          Console.WriteLine($"You entered: {mode}. \n That is neither one of us... Try again!");
          StartGame(true); 
          break;
      }
    }

    static void BuildACreature(string head, string body, string feet)
    {
      int headInt = TranslateToNumber(head);
      int bodyInt = TranslateToNumber(body);
      int feetInt = TranslateToNumber(feet);

      SwitchCase(headInt, bodyInt, feetInt);

      Console.WriteLine("WOW!! That creature looks incredible. I couldn't do better myself... Great Job!");
    }

    static void CustomMode()
    {
      Console.WriteLine("All right lets start by having you select the head of the creature...");
      string head = Console.ReadLine().ToLower();

      Console.WriteLine("All right lets start by having you select the body of the creature...");
      string body = Console.ReadLine().ToLower();

      Console.WriteLine("All right lets start by having you select the feet of the creature...");
      string feet = Console.ReadLine().ToLower();

      Console.WriteLine($"You chose: Head: {head} | Body: {body} | Feet: {feet} \n Is that what you would like to build a creature with?");
      Console.Write("Type YES or NO: ");

      string answer = Console.ReadLine().ToUpper();

      if(answer == "YES")
        BuildACreature(head, body, feet);
      else
      {
        Console.WriteLine("Tsk tsk tsk... SO indecisive... Lets try this again...");
        CustomMode();
      }
    }

    static void RandomMode()
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1,4);
      int body = randomNumber.Next(1,4);
      int feet = randomNumber.Next(1,4);

      SwitchCase(head, body, feet);

      Console.WriteLine("Don't you just love my creature? Isn't it amazing...");
    }

    static void SwitchCase(int head, int body, int feet)
    {
      switch(head)
      {
        case 1:
          MonsterHead();
          break;
        
        case 2:
          BugHead();
          break;

        case 3:
          GhostHead();
          break;
      }

      switch(body)
      {
        case 1:
          MonsterBody();
          break;
        
        case 2:
          BugBody();
          break;
        
        case 3:
          GhostBody();
          break;
      }

      switch(feet)
      {
        case 1:
          MonsterFeet();
          break;
        
        case 2:
          BugFeet();
          break;
        
        case 3:
          GhostFeet();
          break;
      }
    }

    static int TranslateToNumber(string creature)
    {
      string evalLowerCase = creature.ToLower();
      switch(evalLowerCase)
      {
        case "monster":
          return 1;

        case "bug": 
          return 2;

        case "ghost":
          return 3;

        default:
          return 1;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
