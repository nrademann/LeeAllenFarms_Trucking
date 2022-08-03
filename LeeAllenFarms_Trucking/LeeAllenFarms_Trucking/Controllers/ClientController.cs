using LeeAllenFarms_Trucking;
using LeeAllenFarms_Trucking.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeeAllenFarms_Trucking.Controllers
{
    public class ClientController : Controller
    {
        ClientDbContext db;
        public ClientController(ClientDbContext db)
        {
            this.db = db;
        }
        public IActionResult AllClient()
        {
            return View(db.Clients);
        }
        public IActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddClient(Client client)
        {
            db.Add(client);
            db.SaveChanges();
            return RedirectToAction("AllClient");
        }
/*        public IActionResult Index()
        {
            return View();
        }
 */   }
}
