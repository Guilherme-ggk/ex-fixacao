using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPIC_.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaPrimeiraAPIC_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<UsuarioModels> Get()
        {
            List<UsuarioModels> usuarioModel = new List<UsuarioModels>();

            usuarioModel.Add(new UsuarioModels() { id = 1, nome = "Guilherme Henrique", email = "30755guilherme@gmail.com"});

            return usuarioModel;

        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioModels Get(int id) // pega
        {
            UsuarioModels usuario = new UsuarioModels() { id = 1, nome = "Guilherme Henrique", email = "30755guilherme@gmail.com" };

            return usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] UsuarioModels usuario) //FROM BODY é onde quero que seja executado a parte principal
        {
        } //Post manda requisição, posta algo

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsuarioModels usuario) //atualiza
        {

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]// deleta
        public void Delete(int id)
        {
        }
    }
}
