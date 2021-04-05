
using System.ComponentModel.DataAnnotations;

namespace day1.Models
{
  public class Cat
  {

    public Cat(string name, string color)
    {
      Name = name;
      Color = color;
      Lives = 9;
      Claws = 20;
      StreetCred = 0m;
    }

    public Cat(string name, string color, int lives)
    {
      Name = name;
      Color = color;
      Lives = lives;
      Claws = 20;
      StreetCred = 0m;
    }

    public Cat(string name, string color, int lives, int claws, decimal streetCred)
    {
      Color = color;
      Lives = lives;
      Claws = claws;
      StreetCred = streetCred;
      Name = name;
    }

    public string Name { get; set; }
    public int Claws { get; set; }
    public string Color { get; set; }
    public decimal StreetCred { get; set; }
    public int Lives { get; private set; }
  }
}