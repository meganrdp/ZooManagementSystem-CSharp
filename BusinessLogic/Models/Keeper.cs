﻿using System.Collections.Generic;
using System.Linq;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models
{
  public interface IKeeper<in TAnimal> : IKeeper where TAnimal : IAnimal
  {
    void StartLookingAfter(TAnimal newAnimal);
  }

  public class Keeper<TAnimal> : IKeeper<TAnimal> where TAnimal : IAnimal
  { 
    private List<TAnimal> animals;

    public Keeper(IEnumerable<TAnimal> animals)
    {
      this.animals = new List<TAnimal>(animals);
    }

    public IEnumerable<T> GetResponsibleAnimals<T>()
    {
      return animals.OfType<T>();
    }

    public void FeedAnimal(Animal animalToFeed)
    {
      animalToFeed.Feed();
    }

    public void GroomAnimal(ICanBeGroomed animalToGroom)
    {
      animalToGroom.Groom();
    }

    public void MuckOutAnimal(ICanHaveMuckSweptOut animalToMuckOut)
    {
      animalToMuckOut.MuckOut();
    }

    public void HoldAnimal(ICanBeHeld animalToHold)
    {
      animalToHold.Hold();
    }

    public void StartLookingAfter(TAnimal newAnimal)
    {
      animals.Add(newAnimal);
    }
  }
}