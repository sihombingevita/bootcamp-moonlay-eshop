// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using Incomes.Data.Abstractions;
using Incomes.Data.Entities;
using Incomes.ViewModels.Incomes;
using Microsoft.AspNetCore.Mvc;

namespace Incomes.Controllers
{
    public class IncomesController : Barebone.Controllers.ControllerBase
    {
        private readonly IIncomeRepository _repoIncome;

        public IncomesController(IStorage storage) : base(storage)
        {
            _repoIncome = this.Storage.GetRepository<IIncomeRepository>();
        }

        public ActionResult Index()
        {
            return this.View(new IndexViewModelFactory().Create(this.Storage));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(CreateViewModel createViewModel)
        {
            // Validations
            if (this.ModelState.IsValid)
            {

                // Logic
                Income income = new CreateViewModelMapper().Map(createViewModel);

                _repoIncome.Create(income);
                this.Storage.Save();

                // Response
                return this.RedirectToAction("index");
            }

            // Response
            return this.View();
        }

        public ActionResult Delete(int id)
        {
            // Validations
            var income = _repoIncome.WithKey(id);
            if (income == null)
                return NotFound();

            // Logic
            _repoIncome.Delete(income);
            Storage.Save();

            // Response
            return RedirectToAction("Index");
        }
    }
}