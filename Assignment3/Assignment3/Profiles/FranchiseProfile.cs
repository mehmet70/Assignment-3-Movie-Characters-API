using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Franchise;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            CreateMap<Franchise, FranchiseCreateDTO>()
                .ReverseMap();
            CreateMap<Franchise, FranchiseReadDTO>()
                .ReverseMap();
            CreateMap<Franchise, FranchiseUpdateDTO>()
                .ReverseMap();
        }
    }
}
