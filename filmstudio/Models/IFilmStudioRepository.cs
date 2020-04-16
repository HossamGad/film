using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
	public interface IFilmStudioRepository
	{
		IEnumerable<FilmStudioModel> AllStudios { get; }
		FilmStudioModel GetFilmStudioModelById(int StudioId);
		FilmStudioModel GetFilmStudioModelByName(string StudioName);

	}
}
