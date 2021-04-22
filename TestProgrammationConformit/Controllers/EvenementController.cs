using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Data;
using TestProgrammationConformit.Models;
namespace TestProgrammationConformit.Controllers
{
    public class EvenementController : ControllerBase
    {
        private readonly  IEvenementRepo _evenemtRepo;

        public EvenementController(IEvenementRepo evenementRepo)
        {
            _evenemtRepo = evenementRepo;
        }




        [HttpGet]
        public IActionResult Get()
        {
            var evenement = _evenemtRepo.GetAllEvenement();
            if (evenement != null)
            {
                return Ok(evenement);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Create(Evenement evenement)
        {
            _evenemtRepo.CreateEvenement(evenement);
            return CreatedAtRoute(nameof(Create), new { Id = 1 }, evenement);
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var result = _evenemtRepo.GetEvenementById(id);
            if (result != null) return Ok(result);
            else return NotFound();
        }

        [HttpPut]
        public IActionResult Edit(Evenement evenement)
        {
            if (ModelState.IsValid)
            {
                _evenemtRepo.UpdateEvenement(evenement);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            _evenemtRepo.DeleteEvenement(id);
            return Ok();
        }
    }
}
