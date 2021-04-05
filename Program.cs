
using System;
using System.Collections.Generic;
using System.Threading;
using day1.Models;
//essentially your file system for import/ exporting

namespace day1
{
  //initialized by dotnet at compilation
  class Program
  {
    //this get run when we do dotnet run
    static void Main(string[] args)
    {

      Console.Clear();
      //   Console.WriteLine("Hello what is your name?");
      //   //   Console.Beep();
      //   //readline to take in user input

      //   string firstName = "Tim";
      //   char middleInit = 'A';
      //   string lastName = Console.ReadLine();
      //   //   System.Console.WriteLine(lastName);

      //   //string concats
      //   //       System.Console.WriteLine("Hello " + firstName + " " + middleInit + " " + lastName);

      //   //       //string interpolation
      //   //       string greeting = $@"Hello {firstName} {middleInit} {lastName}, 
      //   // How are you today good sir? 
      //   // Did you have a good easter?";
      //   //       System.Console.WriteLine(greeting);

      //   Console.WriteLine("{0} {1} {2}", firstName, middleInit, lastName);

      //   //   short smallerNum = short.MinValue;
      //   //   int myNum = 4379798;
      //   //   long largerNum = long.MaxValue;
      //   int myNum;
      //   //4 bit
      //   float num1 = 10.465343243212f;
      //   //8 bit
      //   double num2 = 10.5467586432134566575435674325675;
      //   //16 bit
      //   decimal num3 = 10.56445324543m;

      //   //explicit casting to go from double to float
      //   float num4 = (float)num2;

      //   //implicit casting from float to double is allowed
      //   double num5 = num1;
      //   double num6 = double.PositiveInfinity;
      //   System.Console.WriteLine(num6);


      //   decimal num7 = Decimal.Round(num3, 3);
      //   System.Console.WriteLine(num7);


      string[] cats = new string[3]{
          "Toby",
          "Garfield",
          "Big boy"
      };

      List<string> myCats = new List<string>(){
          "Garfield"
      };

      myCats.Add("Toby");


      //lists use count instead of length
      //   for (int i = 0; i < myCats.Count; i++)
      //   {
      //     string c = myCats[i];
      //     System.Console.WriteLine(c);
      //   }

      bool running = false;
      //generic catstore
      while (running)
      {
        //regular forloop
        // for (int i = 0; i < myCats.Count; i++)
        // {
        //   string c = myCats[i];
        //   System.Console.WriteLine(c);
        // }

        myCats.ForEach(c =>
        {
          System.Console.WriteLine(c);
        });

        System.Console.WriteLine(@"Hey,
Do you want to pet a cat? 
Y / N / Q");

        ConsoleKeyInfo userInput = System.Console.ReadKey();
        Console.Clear();
        if (userInput.Key == ConsoleKey.Y)
        {
          System.Console.WriteLine("Thanks for petting a cat");

        }
        else if (userInput.Key == ConsoleKey.N)
        {
          System.Console.WriteLine("Are you sure you don't want to pet one?");
        }
        else if (userInput.Key == ConsoleKey.Q)
        {
          System.Console.WriteLine("Thanks for stopping by.");
          running = false;
        }
        else
        {
          System.Console.WriteLine("invalid input");
        }

      }

      //catStore as a class

      Store myStore = new Store("Harrison's Cat Store", "777 Meow Lane");
      //   System.Console.WriteLine(myStore.Name);

      myStore.Cats.Add(new Cat("Garfoeld", "Gold", 9, 10, 9.99m));
      //   myStore.Cats.ForEach(c =>
      //   {
      //     System.Console.WriteLine(c.Color);
      //   });


      Console.Clear();
      string intro = @"
            , · · , 
         ,.'   ~    ' , 
   o· '     º  / )))  ', 
    '·. , , , ,/   '/   ,'·, 
          ((    /, ·', ·'  ' · , 
              ''''¢· '             ' · , 
                ;             ,·'''''      ' ,      ),  
                 ' ~|  |   |  ;           ,', . ·',' 
    Ñë§§       ((''''   '| ('' ' · ,    ,····· ´   
                       ¯¯    ¯''''¯¯¯''§Ã";
      foreach (var l in intro)
      {
        System.Console.Write(l);
        Thread.Sleep(100);
      }
      bool open = true;
      while (open)
      {
        System.Console.WriteLine($"Welcome to {myStore.Name}");
        System.Console.WriteLine(@"What would you like to do? 
(V)iew cats        
(S)tock cat
(R)emove cat
(Q)uit
");

        ConsoleKeyInfo userInput = Console.ReadKey();
        System.Console.WriteLine();
        if (userInput.Key == ConsoleKey.V)
        {
          myStore.Cats.ForEach(cat =>
          {
            System.Console.WriteLine($@"
---------------------
Name: {cat.Name}
Color: {cat.Color}
Claws: {cat.Claws}
Lives: {cat.Lives}
--------------------");
          });
        }
        else if (userInput.Key == ConsoleKey.S)
        {
          System.Console.WriteLine("Cats Name to stock : ");
          string catName = Console.ReadLine();
          System.Console.WriteLine("What is the cats color : ");
          string catColor = Console.ReadLine();
          //this would be an issue because readline returns a string and lives is an int
          //   int catLives = Console.ReadLine();
          System.Console.WriteLine("How many lives are left : ");

          string catLives = Console.ReadLine();

          if (int.TryParse(catLives, out int lives))
          {
            // System.Console.WriteLine("A cat should be made with : ");
            // System.Console.WriteLine(catName + catColor + lives);
            myStore.addCat(catName, catColor, lives);

          }
          else
          {
            System.Console.WriteLine("Give me a real number my guy");
          }

        }
        else if (userInput.Key == ConsoleKey.Q)
        {
          System.Console.WriteLine("Thanks for shopping");
          open = false;
        }
        else
        {
          System.Console.WriteLine("Invalid input");
        }
        // Console.ReadKey();
      }



      // Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
    }
  }
}
