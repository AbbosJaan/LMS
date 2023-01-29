using AutoMapper;
using LMS.DataAccess.Base;
using LMS.DataAccess.Entity;
using LMS.DataAccess.RequestEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Services
{
    public class GroupService : EntityBaseRepository<Group, GroupRequest>, IGroupService
    {
        private readonly AppDbContext _context;
        public GroupService(AppDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper) 
        {
            _context = appDbContext;
        }

        public async Task<IEnumerable<Group>> GetAllGroupsAsync()
        {
            var groups = await _context.Groups.Include(n => n.Students).Include(r => r.Group_Course).ThenInclude(c => c.Course).ToListAsync();
            return groups;
        }
    }
}
