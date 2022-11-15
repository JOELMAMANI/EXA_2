using Exa_2.Data.Entity;
using Exa_2.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exa_2.Controllers
{
    public class IrrigationController :Controller
    {
        private readonly IRepository repository;

        public IrrigationController(IRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(this.repository.GetPlant());
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var x = this.repository.GetPlant(id.Value);
            if (x == null)
            {
                return NotFound();
            }
            return View(x);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Floors x)
        {
            if (ModelState.IsValid)
            {
                this.repository.AddPLant(x);
                await this.repository.SaveAllAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(x);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var x = this.repository.GetPlant(id.Value);
            if (x== null)
            {
                return NotFound();
            }
            return View(x);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Floors x)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.repository.UpdatePlant(x);
                    await this.repository.SaveAllAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (this.repository.plantexists(x.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));

            }
            return View(x);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var plant = this.repository.GetPlant(id.Value);
            if (id == null)
            {
                return NotFound();
            }

            return View(plant);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var plant = this.repository.GetPlant(id);
            this.repository.RemovePlant(plant);
            await this.repository.SaveAllAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
