using Libraria.Entity.Entities;
using Libraria.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria.Mediator
{
    public interface ILibrariaMediator
    {
        public Task<ResponseDTO> ShtoLexues(ShtoLexuesDTO shtoLexuesDTO);
        public  Task<ResponseDTO> LeshoLiber(LeshoLiberDTO liberDTO);
        public  Task<ResponseDTO> BejKerkese(KerkeseMarrjeLibriDTO dto);
        public Task<ResponseDTO> AprovoKerkese(string KerkseID);
        public Task<ResponseDTO> LeshoLiberKerkese(string kerkeseId);
        public List<KerkeseMarrjeLibri> MerrKerkesat();
        public List<Lexues> MerrLexuesit();
        public Lexues GjejLexues(string id);





    }
}
