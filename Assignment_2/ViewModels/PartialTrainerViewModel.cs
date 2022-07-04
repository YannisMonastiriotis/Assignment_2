using Assignment_2.Models;
using System.Collections.Generic;

namespace Assignment_2.ViewModels
{
    public class PartialTrainerViewModel
    {
        public TrainerViewModel TrainerViewModel { get; set; }

        public PartialTrainerViewModel()
        {
            TrainerViewModels = new List<TrainerViewModel>();
        }

         public List<TrainerViewModel> TrainerViewModels { get; set; }

  
    }
}