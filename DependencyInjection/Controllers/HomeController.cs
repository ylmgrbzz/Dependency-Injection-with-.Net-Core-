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
            Bildirim bildirim = Creator.CreateBildirimInstance();
            bildirim.Yap();
            bildirim.Yap2();

            //Bildirim bildirim2 = new(new SmsBildirim());
            //bildirim2.Yap();
            //bildirim2.Yap2();

        }


    }
}
