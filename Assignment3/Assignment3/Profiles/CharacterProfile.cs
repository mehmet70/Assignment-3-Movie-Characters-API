using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Character;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, CharacterCreateDTO>();
            CreateMap<Character, CharacterReadDTO>();
            CreateMap<Character, CharacterUpdateDTO>();
        }
    }
}
