using Microsoft.AspNetCore.Mvc;
using SolutionName.ProjectName_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolutionName.Entity;
using SolutionName.BLL;

namespace SolutionName.ProjectName_MVC.Controllers
{
    public class AnimalEngineController : Controller
    {
        public IActionResult Index()
        {

            var animalModel = new AnimalEngineModel
            {
                AnimalName = "Fox",
                AnimalWeight = 11
            };


            var animal = new AnimalDto();

            var bll = new Class1();

            bll.GetNameOfThePerson();


            var errorModel = new ErrorViewModel()
            {
                AnimalName = "Fox",
                AnimalWeight = 11
            };

            animalModel.AnimalName = errorModel.AnimalName;

            return View(animalModel);
        }

        public IActionResult SecondOfIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateAnimalWeight(string animal)
        {
            if(!string.IsNullOrEmpty(animal) && animal.Contains("Fox"))
            {

            }else
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        public IActionResult CalculateAnimalCaunt(string animal)
        {
            if (!string.IsNullOrEmpty(animal) && animal.Contains("Fox"))
            {

            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
