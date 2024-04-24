using Application.Services;
using AutoMapper;
using Contract.Requests.BookRequest;
using Contract.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBaseService<Book> _bookService;
        private readonly IMapper _mapper;

        public BookController(IBaseService<Book> bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<SingleBookResponse> CreateAsync([FromBody] CreateBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            await _bookService.InsertAsync(book);

            return _mapper.Map<SingleBookResponse>(book);
        }
    }
}
