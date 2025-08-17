using Fiap.Games.Application.DTOs;
using Fiap.Games.Application.Implementations;
using FIAP.Games.Domain.Entities;

namespace Fiap.Games.Application.Contracts.IApplicationService
{
    public interface IUserLibraryApplicationService
    {
        Task<ValidationResultDTO<UserLibrary>> AddToLibrary(UserLibraryDTO userLibraryDTO);
        Task<IEnumerable<UserLibraryDTO>> GetByUserProfileId(Guid userProfileId);
    }
}
