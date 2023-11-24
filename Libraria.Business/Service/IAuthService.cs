using Libraria.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public interface IAuthService
    {
        public Task<IdentityResult> Register(Perdorues user, string password);
        public Task<dynamic> LogIn(string username, string password);
    }
}
