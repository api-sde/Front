using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[Authorize]
[Route("/api")]
public class MessagesController : Controller
{
    [HttpGet]
    [Route("messages")]
    public IEnumerable<string> GetPrivateMessages()
    {
        var login = User.Claims
            .SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier)
            ?.Value;

        return new string[]
        {
            $"For {login ?? "your"} eyes only",
            "Your mission, should you choose to accept it..."
        };
    }
}
