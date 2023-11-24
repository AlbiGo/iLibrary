using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public interface IAccountService
    {
        public Task<Perdorues> GjejPerdorues(string userId);

    }
}
