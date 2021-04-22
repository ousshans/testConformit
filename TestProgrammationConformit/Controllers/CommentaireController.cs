using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Data;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CommentaireController : ControllerBase
    {

        private readonly ICommentaireRepo _commentaireRepo;

        public CommentaireController(ICommentaireRepo commentaireRepo)
        {
            _commentaireRepo = commentaireRepo;
        }




        [HttpGet]
        public IActionResult Get()
        {
            var commentaires = _commentaireRepo.GetAllCommentaire();
            if (commentaires != null)
            {
                return Ok(commentaires);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Create(Commentaire commentaire)
        {
            _commentaireRepo.CreateCommentaire(commentaire);
            return CreatedAtRoute(nameof(Create), new { Id = 1 }, commentaire);
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var result =_commentaireRepo.GetCommentaireById(id);
            if (result != null) return Ok(result);
            else return NotFound();
        }

        [HttpPut]
        public IActionResult Edit(Commentaire commentaire)
        {
            if (ModelState.IsValid)
            {
                _commentaireRepo.UpdateCommentaire(commentaire);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            _commentaireRepo.DeleteCommentaire(id);
            return Ok();
        }
    }
}
