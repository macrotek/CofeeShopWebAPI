using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CofeeShopWebAPI.DataLayer;
using CofeeShopWebAPI.Models;
using System.Net;

namespace CofeeShopWebAPI.Controllers
{
    public class ReservationsController : ApiController
    {
        ExpressoDbContext expDBContext = new ExpressoDbContext();
        

        [HttpPost]
        public IHttpActionResult Post(Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            expDBContext.Reservations.Add(reservation); //Get all data from model properties which is entered by user and add into dbset to send for database save.
            expDBContext.SaveChanges(); //It will do actual save operation
            return StatusCode(HttpStatusCode.Created);
        }
    }
}