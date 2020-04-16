using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using filmstudio.Models;

namespace filmstudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmModelsController : ControllerBase
    {
        private readonly FilmContext _context;

        public FilmModelsController(FilmContext context)
        {
            _context = context;
        }

        // GET: api/FilmModels
       [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmModel>>> GetAllFilms()
        {
            return await _context.AllFilms.ToListAsync();
        }

        // GET: api/FilmModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmModel>> GetFilmModel(int FilmId)
        {
            var filmModel = await _context.AllFilms.FindAsync(FilmId);

            if (filmModel == null)
            {
                return NotFound();
            }

            return filmModel;
        }

        // PUT: api/FilmModels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmModel(int id, FilmModel filmModel)
        {
            if (id != filmModel.FilmId)
            {
                return BadRequest();
            }

            _context.Entry(filmModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NoContent();
            }

            return NoContent();
        }

        // POST: api/FilmModels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<FilmModel>> PostFilmModel(FilmModel filmModel)
        {
            _context.AllFilms.Add(filmModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmModel", new { id = filmModel.FilmId }, filmModel);
        }

        // DELETE: api/FilmModels/5
       /* [HttpDelete("{id}")]
        public async Task<ActionResult<FilmModel>> DeleteFilmModel(int id)
        {
            var filmModel = await _context.Filmstudio.FindAsync(id);
            if (filmModel == null)
            {
                return NotFound();
            }

            _context.Filmstudio.Remove(filmModel);
            await _context.SaveChangesAsync();

            return filmModel;
        }

        private bool FilmModelExists(int id)
        {
            return _context.Filmstudio.Any(e => e.FilmId == id);
        }*/
    }
}
