using AutoMapper;
using Futbolchi.DTOS;
using Futbolchi2.DATA.Models;

namespace Futbolchi.Configuration
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<PlayerAddDTO, Player>().ReverseMap(); 
        }
    }
}
