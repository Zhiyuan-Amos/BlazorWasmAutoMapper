using AutoMapper;

namespace BlazorWasmAutoMapper
{
    public class DummyProfile : Profile
    {
        public DummyProfile()
        {
            CreateMap<DummyOne, DummyTwo>().ReverseMap();
        }
    }
}
