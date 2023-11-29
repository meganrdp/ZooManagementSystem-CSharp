using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : Animal, ICanBeGroomed, ICanBeHeld, ISmallAnimal
  {
    private DateTime lastGroomed;
    private DateTime lastHeld;

    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

    public override void Feed()
    {
      Console.WriteLine("<Munch, munch>");
      base.Feed();
    }

    public void Groom()
    {
      lastGroomed = DateTime.Now;
    }

    public void Hold()
    {
      lastHeld = DateTime.Now;
    }

    public override string ToString()
    {
      return base.ToString() + $"; Last Groomed {lastGroomed}; Last Held {lastHeld}";
    }
  }
}
