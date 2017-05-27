using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet_exam_movie.Models.Entities;

namespace aspnet_exam_movie.Models.Repositories
{
    public interface IMovieRepository
    {
        Movie Get(int id);
        IEnumerable<Movie> GetAll();
        void Update(Movie item);
        void Delete(Movie mo);
        void Save(Movie movie);
    }
}
