namespace AspNetCoreCURDMVC_Demo.Controllers
{
    public class Employee12Controller : Controller
    {
        EmployeeDBAccessLayer empdb = new EmployeeDBAccessLayer();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }  