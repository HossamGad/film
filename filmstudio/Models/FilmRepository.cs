using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
	public class FilmRepository : IFilmRepository
	{
        readonly FilmStudioRepository _FilmStudioRepository = new FilmStudioRepository();
        public IEnumerable<FilmModel> AllFilms => new List<FilmModel>


            {

                new FilmModel { FilmId = 100, Name = "Into the blue", Price = 50 , Filmstudio = _FilmStudioRepository.AllStudios.ToList()[0]},

                new FilmModel { FilmId = 101, Name = "Deep blue sea", Price = 60, Filmstudio = _FilmStudioRepository.AllStudios.ToList()[1] },

                new FilmModel { FilmId = 102, Name = "Speed", Price = 70,Filmstudio = _FilmStudioRepository.AllStudios.ToList()[0]  },

                new FilmModel { FilmId = 103, Name = "Wrong turn", Price = 80,Filmstudio = _FilmStudioRepository.AllStudios.ToList()[1] },
                 
                new FilmModel { FilmId = 104, Name = "Saw", Price = 90,Filmstudio = _FilmStudioRepository.AllStudios.ToList()[2]  }

            };
       


        public FilmModel GetFilmModelById(int FilmId)
        {


            return AllFilms.FirstOrDefault(p => p.FilmId == FilmId);
        }
        public FilmModel GetFilmModelByName(string Name)
        {


            return AllFilms.FirstOrDefault(x => x.Name == Name);
        }
        public FilmModel GetFilmModelByName(string Name, int Price)
        {


            return AllFilms.Where(f => f.Name == Name).FirstOrDefault(x => x.Price == Price);
        }
    }
}
