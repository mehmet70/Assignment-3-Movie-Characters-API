using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Character;
using AutoMapper;
using System.Linq;

namespace Assignment3.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, CharacterCreateDTO>()
                .ReverseMap();
            CreateMap<Character, CharacterReadDTO>()
                .ForMember(cdto => cdto.Movies, opt => opt
                .MapFrom(c => c.Movies.Select(m => m.Id).ToArray()))
                .ReverseMap();
            CreateMap<Character, CharacterUpdateDTO>()
                .ReverseMap();
        }
    }
}
