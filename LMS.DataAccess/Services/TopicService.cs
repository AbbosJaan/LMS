using AutoMapper;
using LMS.DataAccess.Base;
using LMS.DataAccess.Entity;
using LMS.DataAccess.RequestEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Services
{
    public class TopicService : EntityBaseRepository<Topic, TopicRequest>, ITopicService
    {
        public TopicService(AppDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper) { }
    }
}
