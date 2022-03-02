using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Movie;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieCreateDTO>()
                .ReverseMap();
            CreateMap<Movie, MovieReadDTO>()
                .ReverseMap();
            CreateMap<Movie, MovieUpdateDTO>()
                .ReverseMap();
        }
    }
}
