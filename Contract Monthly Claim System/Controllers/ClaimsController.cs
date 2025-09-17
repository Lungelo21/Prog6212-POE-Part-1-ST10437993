using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ClaimForm()
        {
            return View();
        }
        public IActionResult ViewClaims()
        {
            return View();
        }
    }
}
