﻿using System;
using System.Web.Mvc;
using AutoMapper;
using Decision.AutoMapperProfiles.Extentions;
using Decision.DomainClasses.Entities.TeacherInfo;
using Decision.ViewModel.ResearchExperience;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class ResearchExperienceProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<AddResearchExperienceViewModel, ResearchExperience>()
                  .ForMember(d => d.Description, m => m.MapFrom(a => a.Description.ToPersianContent(true)))
                  .ForMember(d => d.Title, m => m.MapFrom(a => a.Title.ToPersianContent(true)))
                  .ForMember(d => d.PublishedIn, m => m.MapFrom(a => a.PublishedIn.ToPersianContent(true)))
                .IgnoreAllNonExisting();

            CreateMap<EditResearchExperienceViewModel, ResearchExperience>()
                  .ForMember(d => d.Description, m => m.MapFrom(a => a.Description.ToPersianContent(true)))
                  .ForMember(d => d.Title, m => m.MapFrom(a => a.Title.ToPersianContent(true)))
                  .ForMember(d => d.PublishedIn, m => m.MapFrom(a => a.PublishedIn.ToPersianContent(true)))
                .ForMember(d => d.LastModifiedDate, m => m.MapFrom(a => DateTime.Now)).IgnoreAllNonExisting();

            CreateMap<ResearchExperience, EditResearchExperienceViewModel>().IgnoreAllNonExisting();

            CreateMap<ResearchExperience, ResearchExperienceViewModel>()
                .ForMember(d => d.CreatorUserName, m => m.MapFrom(s => s.Creator.UserName))
                .ForMember(d => d.LastModifierUserName, m => m.MapFrom(s => s.LasModifier.UserName)).IgnoreAllNonExisting();
        }
    }
}