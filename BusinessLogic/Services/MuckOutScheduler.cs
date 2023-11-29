// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Zoo.BusinessLogic.Models;
// using Zoo.BusinessLogic.Models.Animals;

// namespace Zoo.BusinessLogic.Services
// {
//   public class MuckOutScheduler
//   {
//     private static MuckOutScheduler instance;

//     public static MuckOutScheduler Instance
//     {
//       get
//       {
//         if (instance == null)
//         {
//           instance = new MuckOutScheduler();
//         }

//         return instance;
//       }
//     }

//     private MuckOutScheduler()
//     {
//     }

//     public void AssignGroomingJobs(IEnumerable<IKeeper> keepers, IEnumerable<IAnimal> animals)
//     {
//       foreach (var keeper in keepers)
//       {
//         keeper.GetResponsibleAnimals<ICanHaveMuckSweptOut>().AsParallel().ForAll(keeper.MuckOutAnimal);
//       }
//     }
//   }
// }