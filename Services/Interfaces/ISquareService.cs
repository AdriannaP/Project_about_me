using ProjectAboutMe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAboutMe.Services.Interfaces
{
    public interface ISquareService
    {
        Task<IEnumerable<SquareViewModel>> GetAllActiveSquareViewModelsAsync();
        Task<SquareViewModel> GetSquareViewModelByIdAsync(int id);
    }
}
