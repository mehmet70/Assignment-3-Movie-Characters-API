using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Movie;
using AutoMapper;
using System.Linq;

namespace Assignment3.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieCreateDTO>()
                .ReverseMap();
            CreateMap<Movie, MovieReadDTO>()
                .ForMember(mdto => mdto.Characters, opt => opt
                .MapFrom(m => m.Characters.Select(c => c.Id).ToArray()))
                .ReverseMap();
            CreateMap<Movie, MovieUpdateDTO>()
                .ReverseMap();
        }
    }
}
