using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libraria.Business.Service;
using Libraria.Models.DTO;
using Microsoft.AspNetCore.Identity;

namespace Libraria.Mediator
{
    public class AuthMediator : IAuthMediator
    {
        private readonly IAuthService _authService;

        public AuthMediator(IAuthService authService)
        {
            _authService = authService;
        }
        public async Task<IdentityResult> Register(RegisterUserDTO dTO)
        {
            try
            {
                var newUser = Mapper.BusinessMapper.MapFromDTOAccount(dTO);

                return await _authService.Register(newUser, dTO.Password);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<LogInResultDTO> LogIn(LoginRequestDTO dTO)
        {
            try
            {

                var logResult = await _authService.LogIn(dTO.UserName, dTO.Password);
                int kodi = logResult.GetType().GetProperty("KodiDaljes").GetValue(logResult,null);
                if (kodi == 1)
                {
                    var LogInResultDTO = new LogInResultDTO()
                    {
                        KodiDaljes = logResult.GetType().GetProperty("KodiDaljes").GetValue(logResult, null),
                        Pershkrim = logResult.GetType().GetProperty("Pershrkim").GetValue(logResult, null),
                        Token = logResult.GetType().GetProperty("token").GetValue(logResult, null),
                        Expiration = logResult.GetType().GetProperty("expiration").GetValue(logResult, null)

                    };
                    return LogInResultDTO;
                }
                return new LogInResultDTO()
                {
                    KodiDaljes = logResult.GetType().GetProperty("KodiDaljes").GetValue(logResult, null),
                    Pershkrim = logResult.GetType().GetProperty("Pershkrimi").GetValue(logResult, null),

                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
