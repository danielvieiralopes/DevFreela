using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase  //controller
    {
        private readonly OpeningTimeOption _option;

        public ProjectsController(IOptions<OpeningTimeOption> option, ExampleClass exampleClass)
        {
            exampleClass.Name = "Updated at ProjectsController";

            _option = option.Value;
        }
        // api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query) //action get metodo
        {
            //Buscar todos ou filtrar
            return Ok();
        }

        // api/projects/3
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            //Buscar o projeto

            //return NotFound();
            return Ok();
        }

        [HttpPost]

        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            //Cadastrar o Objeto

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            //Atualizo o Objeto

            return NoContent();
        }

        //api/projects/3 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, retorna NotFound

            //Remover
            return NoContent();

        }

        // api/projects/1/comments POST 
        [HttpPost("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentModel createComment)
        {
            //cadastrar comentarios
            return NoContent();
        }

        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            //inicializar o projeto
            return NoContent();
        }

        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            //finalizar o projeto
            return NoContent();
        }
    }
}
