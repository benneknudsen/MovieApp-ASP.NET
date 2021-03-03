using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace WebApplication2.Models
{
    public class MovieController : Controller
    {
        private readonly WebApplication2Context _context;

        public MovieController(WebApplication2Context context)
        {
            _context = context;
        }

        // GET: Movie
        public async Task<IActionResult> Index(int id)
        {
            MovieViewModel mv = new MovieViewModel();
            using (var httpClient = new HttpClient())
            {
                var url = string.Format("https://api.themoviedb.org/3/movie/{0}?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US", id);
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    mv.movie = JsonConvert.DeserializeObject<ApiMovieDetail>(apiResponse);
                }
                var url2 = string.Format("https://api.themoviedb.org/3/movie/{0}/watch/providers?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US", id); ;
                using (var response = await httpClient.GetAsync(url2))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    mv.watchProviders = JsonConvert.DeserializeObject<dynamic>(apiResponse);
                }
                var url3 = string.Format("https://api.themoviedb.org/3/movie/{0}/credits?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US", id); ;
                using (var response = await httpClient.GetAsync(url3))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    mv.actors = JsonConvert.DeserializeObject<dynamic>(apiResponse);
                }
                var url4 = string.Format("https://api.themoviedb.org/3/movie/{0}/videos?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US", id); ;
                using (var response = await httpClient.GetAsync(url4))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    mv.trailers = JsonConvert.DeserializeObject<dynamic>(apiResponse);
                }
                var url5 = string.Format("https://api.themoviedb.org/3/movie/{0}/recommendations?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US", id); ;
                using (var response = await httpClient.GetAsync(url5))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    mv.relatedMovies = JsonConvert.DeserializeObject<dynamic>(apiResponse);
                }
            }
            
            var movie = _context.Movie.Where(s => s.movieApiId == id).FirstOrDefault<Movie>();
            if (movie != null) { 
            var comments = _context.Comment.Where(s => s.movieId == movie.movieId).ToListAsync();
           
            mv.comments = await comments;
            }
            return View(mv);
        }

      
        [HttpPost]

        public async Task<IActionResult> saveMovie(IFormCollection formCollection, int id )

        {
            MovieViewModel mv = new MovieViewModel();
          
                SqlParameter userId = new SqlParameter("@userId", 2);
                SqlParameter movieApiId = new SqlParameter("@movieApiId", formCollection["movieApiId"].ToString());
                _context.Database.ExecuteSqlRaw(
                    "exec addMovie @userId, @movieApiId", userId, movieApiId);
            

            var comments = _context.Comment.Include(c => c.Movie.movieApiId == formCollection["movieApiId"]).Include(c => c.User);
            

            

            return RedirectToAction("Index", new { id= formCollection["movieApiId"] });
        }

        [HttpPost]
        public async Task<IActionResult> addComment(IFormCollection formCollection)
        {
            
            SqlParameter userId = new SqlParameter("@userId", 2);
            SqlParameter movieApiId = new SqlParameter("@movieApiId", formCollection["movieApiId"].ToString());
            SqlParameter comment = new SqlParameter("@comment", formCollection["comment"].ToString());
            _context.Database.ExecuteSqlRaw(
                "exec addComment @userId, @movieApiId, @comment", userId, movieApiId, comment);

            return RedirectToAction("Index", new { id = formCollection["movieApiId"] });
            
        }
        [HttpPost]
        public async Task<IActionResult> deleteComment(IFormCollection formCollection)
        {
            var commetId = Int32.Parse(formCollection["commentId"]);
            var comment = await _context.Comment.FindAsync(commetId);
            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = formCollection["movieApiId"]});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> editComment(IFormCollection formCollection)
        {

            

            SqlParameter commetId = new SqlParameter("@commentId", Int32.Parse(formCollection["commentId"]));
           
            SqlParameter comment = new SqlParameter("@comment", formCollection["comment"].ToString());
            
            _context.Database.ExecuteSqlRaw(
                 "UPDATE Comment SET content = @comment WHERE commentId = @commentId", commetId, comment);

            return RedirectToAction("Index", new { id = formCollection["movieApiId"] });

        }

    }
    
}
