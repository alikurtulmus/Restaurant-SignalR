using AutoMapper;
using DtoLayerSR.SliderDto;
using EntityLayerSR.Entities;

namespace SignalRApi.Mapping
{
    public class SliderMapping:Profile
    {
        public SliderMapping() 
        { 
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
        }
    }
}
