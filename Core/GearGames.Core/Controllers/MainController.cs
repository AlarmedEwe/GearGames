using GearGames.Core.Interfaces;
using GearGames.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GearGames.Core.Controllers
{
    public abstract class MainController : ControllerBase
    {
        private readonly INotificator _notificator;
        protected bool IsValidOperation { get => !_notificator.HasNotifications(); }

        public MainController(INotificator notificator)
        {
            _notificator = notificator;
        }

        protected ActionResult CustomResponse(object? result = null, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            if (IsValidOperation)
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            var error = new
            {
                success = false,
                errors = _notificator.GetNotifications()
            };

            return statusCode switch
            {
                HttpStatusCode.Forbidden => Forbid(),
                HttpStatusCode.BadRequest => BadRequest(error),
                _ => BadRequest(error)
            };
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            throw new NotImplementedException();
        }
    }
}
