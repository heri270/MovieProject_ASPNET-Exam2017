using System;
using System.Collections.Generic;
using System.Linq;
using aspnet_exam_movie.Models;
using aspnet_exam_movie.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_exam_movie.Controllers
{
    public class HomeController : Controller
    {

        MyDbContext db = new MyDbContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            List<Movie> movies = db.Movies.ToList();

            ViewBag.Y = movies;
            return View();
        }


        public IActionResult About()
        {
            return View();
        }

    }
}
