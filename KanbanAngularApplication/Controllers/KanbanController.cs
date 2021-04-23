using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using KanbanAngularApplication.Models;

namespace KanbanAngularApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KanbanController : ControllerBase
    {
        // GET: api/<KanbanController>
        [HttpGet]
        public List<KanbanTasks> Get()
        {
            List<KanbanTasks> data = KanbanTasks.GetKanbanTasks().ToList();
            return data;
        }
    }
}
