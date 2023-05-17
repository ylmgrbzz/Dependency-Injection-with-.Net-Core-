using DependencyInjection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public void Get()
        {
            Bildirim bildirim = new Bildirim();
            bildirim.Yap(new EPostaBildirim());
            bildirim.Yap(new SmsBildirim());
        }

    }
}
