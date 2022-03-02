using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Movie;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieCreateDTO>();
            CreateMap<Movie, MovieReadDTO>();
            CreateMap<Movie, MovieUpdateDTO>();
        }
    }
}
