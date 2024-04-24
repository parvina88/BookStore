using AutoMapper;
using Contract.Requests.AuthorRequests;
using Contract.Responses;
using Domain.Entities;

namespace Application.Common.Mapping
{
    public class AuthorMapProfile : Profile
    {
        public AuthorMapProfile()
        {
            CreateMap<CreateAuthorRequest, Author>();
            CreateMap<Author, SingleAuthorResponse>();
        }
    }
}
