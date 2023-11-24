using Libraria.Business.Business.Models;
using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public interface ILIbrariaService
    {
        public Task<int> LeshoLiber(LeshoLiberBusiness entity);
        public Task<dynamic> BejKerkese(KerkeseMarrjeLibri entity);
        public KerkeseMarrjeLibri GjejKerkese(string id);
        public List<KerkeseMarrjeLibri> GjitheKerkesat();
        public  Task AprovoKerkese(string KerkseID);
        public Task<dynamic> RefuzoKerkese(string KerkseID);
        public bool KontrolloInventarin(string liberId);
        public List<KerkeseMarrjeLibri> MerrKerkesat();
        public Task<KerkesePrind> ShtoKerkese(KerkesePrind kerkese);
        public List<MarrjeLibri> MerrLeshimet();







    }
}
