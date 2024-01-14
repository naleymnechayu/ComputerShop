using ComputerShop.Interfaces;
using ComputerShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComputerShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IAllProducts _IallProducts;
        private readonly IProductCategory _Icategory;

        public HomeController(IAllProducts IAllProducts,IProductCategory IProductCategory, ILogger<HomeController> logger)
        {
            _IallProducts = IAllProducts;
            _Icategory = IProductCategory;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var products = _IallProducts.Products;
            return View(products);
        }
        [Route("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("Products")]
        public IActionResult Products()
        {
            var products = _IallProducts.Products;
            return View(products);
        }
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("product_detail")]
        public IActionResult product_detail()
        {
            var products = _IallProducts.Products;
            return View(products);
        }
        [Route("signIn")]
        public IActionResult signIn()
        {
            return View();
        }
        [Route("LogIn")]
        public IActionResult LogIn()
        {
            return View();
        }
        [Route("Cart")]
        public IActionResult Cart() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}