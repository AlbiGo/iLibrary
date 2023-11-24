using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public interface ILexuesService
    {
        public  Task<dynamic> ShtoLexues(Lexues lexues);
        public  Task<Lexues> GjejLexues(string Id);
        public List<Lexues> MerrLexuesit();
        public Lexues GJejLexues(string id);


    }
}
