using System.Collections.Generic;
using System.Linq;
using aspnet_exam_movie.Models;
using aspnet_exam_movie.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using aspnet_exam_movie.Models.Entities;
using aspnet_exam_movie.Models.ViewModels;

namespace aspnet_exam_movie.Controllers
{
    public class MovieController : Controller
    {
        // Loosly Coupled
        private IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;   
        }

        // Read
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Movie> movies = _movieRepository.GetAll();
            return View(movies);
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Movie mo)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Save(mo);
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
        }

        // Update
        public IActionResult Update(int id)
        {
            Movie movie =  _movieRepository.Get(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Update(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Update(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Movie movie =  _movieRepository.Get(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie mo)
        {
            _movieRepository.Delete(mo);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var movie = _movieRepository.Get(id);
            return View(movie);
        }

    }
}
