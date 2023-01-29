using LMS.DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace LMS.UI.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupService _service;
        public GroupController(IGroupService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var groups = await _service.GetAllGroupsAsync();
            return View(groups);
        }
    }
}
