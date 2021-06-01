

using AspNetCore_API_Mapper.DTOs;
using AspNetCore_API_Mapper.Models;
using AutoMapper;

namespace AspNetCore_API_Mapper.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Funcionario, FuncionarioDTO>()
                .ForMember(dest => dest.Sexo,
                    map => map.MapFrom(src => src.Sexo == Sexo.Masculino ? "M" : "F"))
                .ForMember(dest => dest.NomeCompleto,
                    map => map.MapFrom(src => $"{src.Nome} {src.Sobrenome}"))
                .ForMember(dest => dest.IsAtivo,
                    src => src.MapFrom(src => src.Salario > 0 ? true : false))
                .ReverseMap();

            CreateMap<Endereco, EnderecoDTO>();
        }
    }
}
