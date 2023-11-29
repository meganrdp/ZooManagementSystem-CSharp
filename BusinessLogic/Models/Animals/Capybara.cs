using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Capybara : AnimalThatCanBeGroomed, ILargeAnimal
  {
    public Capybara(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

  }
}
