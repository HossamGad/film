using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
	public class FilmStudioRepository: IFilmStudioRepository
	{
        public IEnumerable<FilmStudioModel> AllStudios => new List<FilmStudioModel>


            {

                new FilmStudioModel { StudioId = 100, StudioName = "Studio 1",},

                new FilmStudioModel { StudioId = 101, StudioName = "Studio 2",  },

                new FilmStudioModel { StudioId = 102, StudioName = "Studio 3",  },

              

            };
        
        public FilmStudioModel GetFilmStudioModelById(int StudioId)
        {


            return AllStudios.FirstOrDefault(p => p.StudioId == StudioId);
        }
        public FilmStudioModel GetFilmStudioModelByName(string StudioName)
        {


            return AllStudios.FirstOrDefault(x => x.StudioName == StudioName);
        }
    }
}
