using AutoMapper;
using System;

namespace FinancialManagement.Infrastructure.Models.UserModels
{
    public class AddUserRequestDto
    {

        public string Name { get; set; }
        public string Surname { get; set; }

    }

    public class AddUserRequestProfile : Profile
    {
        public AddUserRequestProfile()
        {
            CreateMap<AddUserRequestDto, User>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
        }
    }

}
