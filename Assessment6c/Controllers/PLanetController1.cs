using Assessment6c.DAL;
using Assessment6c.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assessment6c.Controllers
{
    public class PLanetController1 : Controller
    {
        private PlanetContext db = new PlanetContext();
        public IActionResult Index()
        {
            return View(db.Planets.ToList());
        }

        public ActionResult PlanetDetails(int? id)
        {
            if (id == null)
            {
                throw new BadHttpRequestException("No Id Provided");
            }
            Planet planet = db.Planets
                .Where(x => x.ID == id)
                .Include(i => i.Order)
                .FirstOrDefault();

            if (planet == null)
            {
                throw new BadHttpRequestException("Id not found");
            }

            return View();

            //for (int i = 0; i < planet.Order.Count; i++)
          //  {
                //  planet.Order = db.Planets.FirstOrDefault(x => x.Name == planet.Order);
                //}
                // return View(planet);
            }
        }
    }


   
