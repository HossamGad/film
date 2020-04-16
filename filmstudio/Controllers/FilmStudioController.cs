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
	public class FilmStudioController : Controller
	{
		// GET: /<controller>/
		private readonly IFilmStudioRepository _Repository;

		public FilmStudioController(IFilmStudioRepository Repository)
		{
			_Repository = Repository;
		}
		[HttpGet]
		public IEnumerable<FilmStudioModel> GetAllFilmStudioModel()
		{
			var result = _Repository.AllStudios.OrderBy(c => c.StudioId);
			return result;
		}
		[HttpGet("{Name}")]
		public FilmStudioModel GetAllFilmStudioModel(string StudioName)
		{
			var result = _Repository.GetFilmStudioModelByName(StudioName);

			return result;
		}
	}
}
