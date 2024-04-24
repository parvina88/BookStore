using Application.Services;
using AutoMapper;
using Contract.Requests.AuthorRequests;
using Contract.Requests.BookRequest;
using Contract.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IBaseService<Author> _authorService;
        private readonly IMapper _mapper;

        public AuthorController(IBaseService<Author> authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<SingleAuthorResponse> CreateAsync([FromBody] CreateAuthorRequest request)
        {
            var author = _mapper.Map<Author>(request);
            await _authorService.InsertAsync(author);

            return _mapper.Map<SingleAuthorResponse>(author);
        }
    }
}
