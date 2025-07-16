using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CofeeShopWebAPI.DataLayer;

namespace CofeeShopWebAPI.Controllers
{
    public class MenusController : ApiController
    {
        ExpressoDbContext expDBContext = new ExpressoDbContext();
        [HttpGet]
        public IHttpActionResult GetMenus()
        {
            var result = expDBContext.Menus;
            return Ok(result);
        }
    }
}