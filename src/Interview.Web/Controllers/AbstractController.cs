using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Interview.Web.Controllers
{
    public abstract class AbstractController : Controller
    {
        #region Read-Only Fields

        protected readonly ILogger _logger;
        protected readonly IMapper _mapper;

        #endregion

        #region Constructors

        public AbstractController(ILogger logger, IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        #endregion
    }
}
