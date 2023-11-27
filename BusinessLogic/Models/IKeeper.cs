﻿using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models
{
    public interface IKeeper
    {
        IEnumerable<T> GetResponsibleAnimals<T>();

        void FeedAnimal(Animal animalToFeed);

        void GroomAnimal(AnimalThatCanBeGroomed animalToGroom);
    }
}