using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.TitleDTOs;
using StoreVideoGames.Repositories;
using StoreVideoGames.Repositories.TitleRepository;

namespace StoreVideoGames.Manager.TitleM
{
    public class TitleManager : ITitleManager
    {
        private readonly ITitleRepository _repository;
        private readonly IMapper _mapper;

        public TitleManager(ITitleRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ManagerResult<Title>> AddAsync(CreateTitleDTO createTitleDTO)
        {
            var managerResult = new ManagerResult<Title>();
            try
            {
                var entity = _mapper.Map<Title>(createTitleDTO);
                await _repository.AddAsync(entity);
                return managerResult;
            }
            catch (Exception e)
            {
                managerResult.Success = false;
                managerResult.Message = e.Message;
                return managerResult;
            }
        }

        public async Task<ManagerResult<Title>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagerResult<Title>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ManagerResult<Title>> UpdateAsync(int id, CreateTitleDTO updateTitleDTO)
        {
            throw new NotImplementedException();
        }
    }
}
