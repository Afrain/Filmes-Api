using Microsoft.AspNetCore.Mvc;

namespace Filmes_Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FilmeController
    {
        [HttpGet]
        public string AdicionaFilme ()
        {
            return "FilmeAdicionado";
        }


    }
}
