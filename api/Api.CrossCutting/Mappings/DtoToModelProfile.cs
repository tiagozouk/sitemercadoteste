using Api.Domain.Dtos;
using Api.Domain.Dtos.Produto;
using Api.Domain.Dtos.User;
using Api.Domain.Models.Produto;
using Api.Domain.Models.User;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile: Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap();
            CreateMap<UserModel, UserDtoCreate>()
                .ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>()
                .ReverseMap();
            CreateMap<ProdutoModel, ProdutoDto>()
                .ReverseMap();

            CreateMap<ProdutoModel, ProdutoDtoUpdate>()
                .ReverseMap();
        }
    }
}