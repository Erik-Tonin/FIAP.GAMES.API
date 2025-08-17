using FIAP.Games.Domain.Entities;

namespace Fiap.Games.Application.DTOs
{
    public class UserLibraryDTO
    {
        public Guid? Id { get; set; }
        public Guid UserProfileId { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}
