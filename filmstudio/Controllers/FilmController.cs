using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filmstudio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace filmstudio.Controllers
{
	[Route("/api/[controller]")]
	public class FilmController : Controller
	{
		// GET: /<controller>/
		private readonly IFilmRepository _Repository;
		
		public FilmController(IFilmRepository Repository)
		{
			_Repository = Repository;
		}
		[HttpGet]
		public IEnumerable<FilmModel> GetAllFilmModel()
		{
			var result = _Repository.AllFilms.OrderBy(c => c.FilmId);
			return result;
		}
		[HttpGet("{FilmId}")]
		public FilmModel GetAllFilmModel(int FilmId)
		{
			var result = _Repository.GetFilmModelById(FilmId);

			return result;
		}
			
	}
}
