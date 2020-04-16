using System;
using filmstudio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
	public interface IFilmRepository
	{
		IEnumerable<FilmModel> AllFilms { get; }
		FilmModel GetFilmModelById(int FilmId);
		FilmModel GetFilmModelByName(string Name);
		FilmModel GetFilmModelByName(string Name, int Price);
	}
}
