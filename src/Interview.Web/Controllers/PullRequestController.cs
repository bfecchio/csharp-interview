using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Interview.Web.Controllers;
using Microsoft.Extensions.Logging;

using Interview.Web.Models;
using Interview.Recruiter.Domain.Interfaces;

namespace Interview.Controllers
{
    [Route("pull-request")]
    public class PullRequestController : AbstractController
    {
        #region Read-Only Fields

        private readonly ISmsService _smsService;
        private readonly IMailService _mailService;

        #endregion

        #region Constructors

        public PullRequestController(ILogger<HomeController> logger, IMapper mapper
            , ISmsService smsService
            , IMailService mailService
        )
            : base(logger, mapper)
        {
            _smsService = smsService ?? throw new ArgumentNullException(nameof(smsService));
            _mailService = mailService ?? throw new ArgumentNullException(nameof(mailService));
        }

        #endregion

        #region Actions

        public IActionResult Index()
        {
            try
            {
                _smsService.Send("111111", "message");
                _mailService.Send("test@test.com", "test@test.com", "body");            
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            
            return View(new PullRequestViewModel());
        }

        #endregion
    }
}
