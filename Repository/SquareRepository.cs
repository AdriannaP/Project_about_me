using Microsoft.EntityFrameworkCore;
using ProjectAboutMe.Models;
using ProjectAboutMe.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAboutMe.Repository
{
    public class SquareRepository : ISquareRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SquareRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Square>> GetAllActiveSquaresAsync()
        {
            return await _applicationDbContext.Squares.Where(square => square.Active).ToListAsync();
        }
        public async Task<Square> GetSquareByIdAsync(int id)
        {
            return await _applicationDbContext.Squares.FirstOrDefaultAsync(square => square.Active && square.Id == id);
        }

    }

}
