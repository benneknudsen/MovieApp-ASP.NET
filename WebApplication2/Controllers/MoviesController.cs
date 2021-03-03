using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MoviesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(int id)
        {
            HomeViewModel vm = new HomeViewModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/movie/popular?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US&page=1"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    vm.PopularMovies = JsonConvert.DeserializeObject<Page>(apiResponse);
                }

                using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/movie/upcoming?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US&page=1"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    vm.UpcomingMovies = JsonConvert.DeserializeObject<Page>(apiResponse);
                }

                using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/tv/popular?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US&page=1"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    vm.PopularTV = JsonConvert.DeserializeObject<Page>(apiResponse);
                }

                using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/movie/now_playing?api_key=d636901f60c53024897a2f4f20f4eace&language=en-US&page=1region=DK"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(apiResponse);

                    vm.NowPlaying = JsonConvert.DeserializeObject<Page>(apiResponse);
                }

            }
            
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
