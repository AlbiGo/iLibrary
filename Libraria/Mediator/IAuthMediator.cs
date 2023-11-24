using Libraria.Models.DTO;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Mediator
{
    public interface IAuthMediator
    {
        public Task<IdentityResult> Register(RegisterUserDTO dTO);
        public Task<LogInResultDTO> LogIn(LoginRequestDTO dTO);
    }
}
