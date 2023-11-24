using Libraria.Entity.Entities;
using Libraria.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Mediator
{
    public interface ILiberMediator
    {
        public Task<ResponseDTO> ShtoLiber(Liber liber);
        public List<Liber> MerrLibrat();
        public List<Liber> MerrLibratELire();

    }
}
