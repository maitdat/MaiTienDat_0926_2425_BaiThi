using Microsoft.AspNetCore.Mvc;

namespace MaiTienDat_0926_2425_BaiThi.Controllers
{
    public class MaiTienDatController : Controller
    {
        public IActionResult Index()
        {
            const string str= "Mai Tien Dat";
            return View(str);
        }
    }
}
