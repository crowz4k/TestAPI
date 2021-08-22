﻿using AutoMapper;

namespace WebApplication1
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderDto>();
        }
    }
}
