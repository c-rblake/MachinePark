using MachinePark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MachinePark.Services
{
    public class AuthorDataService : IAuthorDataService
    {
        private readonly HttpClient _httpClient;

        public AuthorDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
