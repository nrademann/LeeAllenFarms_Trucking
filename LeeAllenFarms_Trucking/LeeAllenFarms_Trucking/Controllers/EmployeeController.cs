/*using LeeAllenFarms_Trucking.Models;
using LeeAllenFarms_Trucking.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LeeAllenFarms_Trucking.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext db;
        public EmployeeController(EmployeeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> All
        /*        public IActionResult Index()
                {
                    return View();
                }
         close block here
    }
}
*/