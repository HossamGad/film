using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
	
	public class FilmModel
	{
		[Key]
		public int FilmId { get; set; }
		public int StudioId { get; set; }

		public string Name { get; set; }
		public FilmStudioModel Filmstudio { get; set; }
		public int Price { get; set; }


	}
}
