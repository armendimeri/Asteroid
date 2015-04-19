using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace AsteroidAPI.Controllers
{
    public class AsteroidController : ApiController
    {

        //Controller Get function to return asteroids
        public Asteroid[] GetAsteroids()
        {
            return Asteroid.GetAsteroids();
        }
   }
}