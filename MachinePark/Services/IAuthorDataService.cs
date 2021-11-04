using MachinePark.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MachinePark.Services
{
    public interface IAuthorDataService
    {
        Task<IEnumerable<AuthorDto>> GetAllAuthors();
    }
}