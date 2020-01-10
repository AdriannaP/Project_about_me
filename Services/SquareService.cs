using AutoMapper;
using ProjectAboutMe.Models;
using ProjectAboutMe.Repository.Interfaces;
using ProjectAboutMe.Services.Interfaces;
using ProjectAboutMe.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectAboutMe.Services
{
    public class SquareService : ISquareService
    {
        private readonly ISquareRepository _squareRepository;
        private readonly IMapper _mapper;

        public SquareService(ISquareRepository squareRepository, IMapper mapper)
        {
            _squareRepository = squareRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SquareViewModel>> GetAllActiveSquareViewModelsAsync()
        {
            var squares = await _squareRepository.GetAllActiveSquaresAsync();
            IList<SquareViewModel> squareViewModels = new List<SquareViewModel>();

            foreach (Square square in squares)
            {
                squareViewModels.Add(_mapper.Map<SquareViewModel>(square));
            }
            return squareViewModels;
        }
        public async Task<SquareViewModel> GetSquareViewModelByIdAsync(int id)
        {
            var square = await _squareRepository.GetSquareByIdAsync(id);
            return _mapper.Map<SquareViewModel>(square);
        }
    }
}