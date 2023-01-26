﻿using AutoMapper;
using FreeCourseServices.Catalog.Dtos;
using FreeCourseServices.Catalog.Model;

namespace FreeCourseServices.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course, CourseDto>().ReverseMap(); //course'tan coursedto nesnesi oluşturabiliriz.
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();
        }
    }
}
