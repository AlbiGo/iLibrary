using Libraria.Data.Repository;
using Libraria.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    
    public class AccountService : IAccountService
    {
        private IRepository<Perdorues> _repository;
        private readonly UserManager<Perdorues> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountService(IRepository<Perdorues> repository,
           UserManager<Perdorues> userManager,
           IConfiguration configuration,
           RoleManager<IdentityRole> roleManager)
        {
            _repository = repository;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public  async Task<Perdorues> GjejPerdorues(string userId)
        {
            return  await this._userManager.FindByIdAsync(userId);
        }
    }
}
