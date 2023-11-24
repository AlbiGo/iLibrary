using Libraria.Business.Service;
using Libraria.Entity.Entities;
using Libraria.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Mediator
{
    public class LiberMediator : ILiberMediator
    {
        private readonly ILIberService _liberService;

        public LiberMediator(ILIberService service)
        {
            _liberService = service;
        }

        public List<Liber> MerrLibratELire()
        {
            return this._liberService.MerrLibratELire();
        }

        public List<Liber> MerrLibrat()
        {
            return this._liberService.MerrLibrat();
        }
        public async Task<ResponseDTO> ShtoLiber(Liber liber)
        {
            try
            {
                var result = await this._liberService.ShtoLiber(liber);
                var resDto = new ResponseDTO()
                {
                    KodiDaljes = result.GetType().GetProperty("KodiDaljes").GetValue(result, null),
                    Pershkrim = result.GetType().GetProperty("Pershrkim").GetValue(result, null)
                };
                return resDto;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
