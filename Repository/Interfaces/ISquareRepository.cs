
using ProjectAboutMe.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAboutMe.Repository.Interfaces
{
    public interface ISquareRepository
    {
        Task<IEnumerable<Square>> GetAllActiveSquaresAsync();
        Task<Square> GetSquareByIdAsync(int id);
    }
}
