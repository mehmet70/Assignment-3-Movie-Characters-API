using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Franchise;
using AutoMapper;
using System.Linq;

namespace Assignment3.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            CreateMap<Franchise, FranchiseCreateDTO>()
                .ReverseMap();
            CreateMap<Franchise, FranchiseReadDTO>()
                .ForMember(fdto => fdto.Movies, opt => opt
                .MapFrom(f => f.Movies.Select(m => m.Id).ToArray()))
                .ReverseMap();
            CreateMap<Franchise, FranchiseUpdateDTO>()
                .ReverseMap();
        }
    }
}
