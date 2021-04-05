
using System.Collections.Generic;

namespace day1.Models
{
  public class Store
  {

    public Store(string name, string address)
    {
      Name = name;
      Address = address;
      // Cats = new List<Cat>();
    }


    public string Name { get; set; }
    public string Address { get; set; }

    public List<Cat> Cats { get; set; } = new List<Cat>();

    public Dictionary<string, Cat> OtherCats { get; set; } = new Dictionary<string, Cat>();

    // otherCats: {
    // "garfield" : {name:"Garfiled", color: "Gold", etc...}
    // }


    public void addCat(string catName, string catColor, int catLives)
    {
      Cat catToAdd = new Cat(catName, catColor, catLives);
      Cats.Add(catToAdd);
    }

    public void addCat(string catName, string catColor)
    {
      Cat catToAdd = new Cat(catName, catColor);
      Cats.Add(catToAdd);
    }

  }
}