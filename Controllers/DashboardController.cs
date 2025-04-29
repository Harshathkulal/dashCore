using Microsoft.AspNetCore.Mvc;
using SimpleDashboardApi.Data;
using SimpleDashboardApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleDashboardApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DashboardItem>> GetItems()
        {
            return _context.DashboardItems.ToList();
        }

        [HttpPost]
        public ActionResult<DashboardItem> AddItem(DashboardItem item)
        {
            _context.DashboardItems.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetItems), new { id = item.Id }, item);
        }
    }
}
