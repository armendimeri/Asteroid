using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AsteroidAPI.Controllers
{


    //This controller is unused for the moment
    //This controller is unused for the moment
    //This controller is unused for the moment
    public class HazardController : ApiController
    {
       
        public Asteroid[] Get()
        {
            return Asteroid.GetAsteroidsHazard();
        } 
    }
}
