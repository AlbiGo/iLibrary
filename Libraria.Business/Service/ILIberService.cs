using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public interface ILIberService
    {
        public Task<dynamic> ShtoLiber(Liber liber);
        public Liber GjejLiber(string Id);
        public List<Liber> MerrLibrat();
        public List<Liber> MerrLibratELire();




    }
}
