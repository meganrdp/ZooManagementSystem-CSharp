using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Lion : Animal, ICanHaveMuckSweptOut, ILargeAnimal
  {
    private DateTime lastMuckOut;

    public Lion(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

    public override void Feed()
    {
      Console.WriteLine("<ROAR!>");
      base.Feed();
    }

    public void MuckOut()
    {
      lastMuckOut = DateTime.Now;
    }

    public override string ToString()
    {
      return base.ToString() + $"; Last Muck-out {lastMuckOut}";
    }
  }
}
