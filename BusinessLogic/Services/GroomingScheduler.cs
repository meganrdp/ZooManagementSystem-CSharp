// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Zoo.BusinessLogic.Models;
// using Zoo.BusinessLogic.Models.Animals;

// namespace Zoo.BusinessLogic.Services
// {
//   public class GroomingScheduler
//   {
//     private static GroomingScheduler instance;

//     public static GroomingScheduler Instance
//     {
//       get
//       {
//         if (instance == null)
//         {
//           instance = new GroomingScheduler();
//         }

//         return instance;
//       }
//     }

//     private GroomingScheduler()
//     {
//     }

//     public void AssignGroomingJobs(IEnumerable<IKeeper> keepers, IEnumerable<IAnimal> animals)
//     {
//       Parallel.ForEach(keepers, keeper =>
//       {
//         foreach (var animal in keeper.GetResponsibleAnimals<Animal>())
//         {
//           if (animal.IsHungry())
//           {
//             keeper.FeedAnimal(animal);
//           }
//         }

//         foreach (var groomableAnimal in keeper.GetResponsibleAnimals<ICanBeGroomed>())
//         {
//             keeper.GroomAnimal(groomableAnimal);
//         }

//         foreach (var muckyAnimal in keeper.GetResponsibleAnimals<ICanHaveMuckSweptOut>())
//         {
//             keeper.MuckOutAnimal(muckyAnimal);
//         }
//       });
//     }
//   }
// }