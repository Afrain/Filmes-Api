using AutoMapper;
using Filmes_Api.Data;
using Filmes_Api.Data.Dtos;
using Filmes_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filmes_Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Filme> ListarFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10) 
        {
            return _context.Filmes.Skip(skip).Take(take).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmeId(int id) 
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto createFilmeDto)
        {
            var filme = _mapper.Map<Filme>(createFilmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarFilmeId), new {id = filme.Id}, filme);
        }

    }
}
