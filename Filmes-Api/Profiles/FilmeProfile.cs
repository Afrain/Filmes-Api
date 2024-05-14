using AutoMapper;
using Filmes_Api.Data.Dtos;
using Filmes_Api.Models;

namespace Filmes_Api.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
        }
    }
}
