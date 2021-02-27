using System;
using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

using Interview.Web.Models;
using Interview.Web.Extensions;
using Interview.Web.Controllers;
using Interview.Recruiter.Domain.Interfaces;

namespace Interview.Controllers
{
    [Authorize()]
    [Route("test")]
    public sealed class TestController : AbstractController
    {
        #region Read-Only Fields

        private readonly ICandidateService _candidateService;

        #endregion

        #region Constructors

        public TestController(ILogger<HomeController> logger, IMapper mapper
            , ICandidateService candidateService
        )
            : base(logger, mapper)
        {
            _candidateService = candidateService ?? throw new ArgumentNullException(nameof(candidateService));
        }

        #endregion

        #region Actions

        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            var model = new CandidateViewModel();
            model.Candidates = _mapper.MapToViewModel<CandidateViewModel>(await _candidateService.GetAll());

            return View(model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = _mapper.MapToViewModel<CandidateViewModel>(await _candidateService.Get(id));
            model.Candidates = _mapper.MapToViewModel<CandidateViewModel>(await _candidateService.GetAll());

            return View("Index", model);
        }

        [HttpPost("{id}")]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _candidateService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Register(CandidateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.CandidateId == Guid.Empty)                
                    await _candidateService.Create(model.Name, model.Surname);
                else
                    await _candidateService.Update(model.CandidateId, model.Name, model.Surname);

                return RedirectToAction(nameof(Index));
            }            

            return View("Index", model);
        }

        #endregion
    }
}
