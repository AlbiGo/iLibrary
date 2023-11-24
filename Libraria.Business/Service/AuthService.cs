using Libraria.Data.Repository;
using Libraria.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public class AuthService : IAuthService
    {
        private IRepository<Perdorues> _repository;
        private readonly UserManager<Perdorues> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthService(IRepository<Perdorues> repository,
           UserManager<Perdorues> userManager,
           IConfiguration configuration,
           RoleManager<IdentityRole> roleManager)
        {
            _repository = repository;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        public async Task<IdentityResult> Register(Perdorues user, string password)
        {
            try
            {
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {

                    if (!await _roleManager.RoleExistsAsync("Menaxher"))
                        await _roleManager.CreateAsync(new IdentityRole("Menaxher"));
                    if (!await _roleManager.RoleExistsAsync("Perdorues"))
                        await _roleManager.CreateAsync(new IdentityRole("Punonjese Sporteli"));
                    if (await _roleManager.RoleExistsAsync("Punonjese Sporteli"))
                    {
                        await _userManager.AddToRoleAsync(user, "Punonjese Sporteli");
                        await _userManager.AddToRoleAsync(user, "Menaxher");

                    }

                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public ApplicationUser GetUserByUserName(string userName)
        //{
        //    var userId = _repository.GetAll().Where(p => p.UserName == userName).FirstOrDefault();
        //    return userId;
        //}
        public async Task<dynamic> LogIn(string username, string password)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(username);
                if (user != null && await _userManager.CheckPasswordAsync(user, password) && user.Statusi == true )
                {
                    var userRoles = await _userManager.GetRolesAsync(user);

                    var authClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    };

                    foreach (var userRole in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                    }
                    authClaims.Add(new Claim(ClaimTypes.PrimarySid, user.Id));
                    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                    var token = new JwtSecurityToken(
                        issuer: _configuration["JWT:ValidIssuer"],
                        audience: _configuration["JWT:ValidAudience"],
                        expires: DateTime.Now.AddDays(3),
                        claims: authClaims,
                        signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                        );

                    return (new
                    {
                        KodiDaljes = 1,
                        Pershrkim = "Autentikim Korrect",
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    });
                }
                else
                {
                    return (new
                    { 
                        KodiDaljes = 0,
                        Pershkrimi = "Perdoruesi nuk egziston ose eshte i deaktivizuar"
                    });

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
