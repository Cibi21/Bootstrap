using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace MoviesWebAPI.Controllers
{
    public class MoviesController : ApiController
    {
        // GET: Movies
        public List<string> GetMovies()
        {
            return new List<string>{ "Titanic", "Mission Impossible", "Matrix" };
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}