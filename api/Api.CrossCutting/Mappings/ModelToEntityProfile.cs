using Api.Domain.Entities;
using Api.Domain.Models.Produto;
using Api.Domain.Models.User;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile: Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>()
                .ReverseMap();

            CreateMap<ProdutoEntity, ProdutoModel>()
                .ReverseMap();
        }
    }
}