using DinkToPdf;
using DinkToPdf.Contracts;
using Libraria.Data.Repository;
using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public class LexuesService : ILexuesService
    {
        private readonly IRepository<Lexues> _repository;
        private IConverter _converter;

        public LexuesService(IRepository<Lexues> repository, IConverter converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public async Task<dynamic> ShtoLexues(Lexues lexues)
        {
            try
            {
              
                lexues .KarteLeximiURL = @"C:\Users\User\source\repos\Libraria\Libraria\Documents\KarteLeximi";
                var lexuesExists = _repository.GetAll().AsQueryable().Where(p => p.Emri == lexues.Emri && p.Mbiemri == lexues.Mbiemri && p.Datelindja == lexues.Datelindja).FirstOrDefault();
                if(lexuesExists != null)
                {
                    throw new Exception("Lexuesi egiziston");
                }
                var result =  await _repository.AddAsync(lexues);
               // var karteEmri = "KarteAnetaresimi" + lexues.Emri + lexues.Mbiemri + lexues.Id;
               // lexues.Karta = karteEmri;
               // var idLexues = result.Id;
               // lexues.Id = idLexues;
               // await _repository.UpdateAsync(lexues);
               //// var barcodeString = Utility.Utility.GenerateBarcode(idLexues.ToString());
               // var pdfContent = Libraria.Business.Utility.Utility.BuilString(lexues);
                return (new
                {
                    IdLexues = result.Id,
                    pddKontent = "",
                    KodiDaljes = 1,
                    Pershrkim = "Lexues u shtua me sukses"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Lexues GJejLexues(string id)
        {
            try
            {
                return this._repository.GetAll().AsQueryable().Where(p => p.Id == Guid.Parse(id)).FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Lexues> MerrLexuesit()
        {
            try
            {
                return this._repository.GetAll().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Lexues> GjejLexues(string Id)
        {
            try
            {
                return  this._repository.GetAll().AsQueryable().Where(p => p.Id == Guid.Parse(Id)).FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
