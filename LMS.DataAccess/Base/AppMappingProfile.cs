using AutoMapper;
using LMS.DataAccess.Entity;
using LMS.DataAccess.RequestEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Base
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<CourseRequest, Course>();
        }
    }
}
