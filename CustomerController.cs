
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreOptionsSnapshotInService
{
    public class SomeController : Controller
    {
        private readonly CustomerService customerService;

        public SomeController(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index() 
        {
            return Json(customerService.GetCustomer());
        }
    }
}
