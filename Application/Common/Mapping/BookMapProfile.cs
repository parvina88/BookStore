using AutoMapper;
using Contract.Requests.BookRequest;
using Contract.Responses;
using Domain.Entities;

namespace Application.Common.Mapping
{
    public class BookMapProfile : Profile
    {
        public BookMapProfile()
        {
            CreateMap<CreateBookRequest, Book>();
            CreateMap<UpdateBookRequest, Book>();
            CreateMap<Book, SingleBookResponse>();
            CreateMap<GetAllBooksRequest, GetAllBookResponses>();
        }
    }
}
