using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Capybara : Animal, ICanBeGroomed, ILargeAnimal
  {
    private DateTime lastGroomed;

    public Capybara(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

    public void Groom()
    {
      lastGroomed = DateTime.Now;
    }

    public override string ToString()
    {
      return base.ToString() + $"; Last Groomed {lastGroomed}";
    }
  }
}
