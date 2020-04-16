using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
	public class FilmStudioModel
	{
		[Key]
		public int StudioId { get; set; }
		public string StudioName { get; set; }

		public IEnumerable<FilmModel> AllFilms { get; }
	}
}