using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Interview.Models;
using Interview.Recruiter.Domain.Services;

namespace Interview.Controllers
{
    public class PullRequestController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MailService mailService;
        private readonly SmsService SmsService;

        public PullRequestController(ILogger<HomeController> logger, MailService MailService)
        {
            _logger = logger;
            mailService = MailService;
            SmsService = new SmsService();

        }


        public IActionResult Index()
        {
            mailService.Send("test@test.com", "test@test.com", "body");
            SmsService.Send("111111", "message");

            //You have return a view with 2 textox and a button
            return View();
        }


    }
}
