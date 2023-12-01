using Libraria.Business.Business.Models;
using Libraria.Data.Database;
using Libraria.Data.Repository;
using Libraria.Entity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationException = Libraria.Entity.Entities.ApplicationException;

namespace Libraria.Business.Service
{
    public class LIbrariaService : ILIbrariaService
    {
        private readonly IRepository<Liber> _repository;
        private readonly IRepository<MarrjeLibri> _liberPerrepository;
        private readonly IRepository<StatusLibri> statusRep;
        private readonly IRepository<Inventari> _invRep;
        private readonly IRepository<KerkeseMarrjeLibri> _repository3;
        protected readonly LibrariaDbContext _librariaContext;
        private readonly IRepository<KerkesePrind> _repositoryKerkesePrind;


        private readonly IHttpContextAccessor _httpAccesor;

        public LIbrariaService(IRepository<Liber> repository, 
            IHttpContextAccessor httpAccesor, 
            IRepository<MarrjeLibri> repository1,
            IRepository<StatusLibri> repository2,
            IRepository<Inventari> invRep,
            LibrariaDbContext librariaContext,
            IRepository<KerkeseMarrjeLibri> repository3,
            IRepository<KerkesePrind> repositoryKerkesePrind
            )
        {
            _repositoryKerkesePrind = repositoryKerkesePrind;
            _repository = repository;
            _httpAccesor = httpAccesor;
            _liberPerrepository = repository1;
            statusRep = repository2;
            _invRep = invRep;
            _repository3 = repository3;
            _librariaContext = librariaContext;
        }

        public async Task<dynamic> RefuzoKerkese(string KerkseID)
        {
            try
            {
                var kerkese = this.GjejKerkese(KerkseID);
                kerkese.Status = false;
                kerkese.DataRefuzimit = DateTime.Now;
                await this._repository3.UpdateAsync(kerkese);
                return (new
                {
                    KodiDaljes = 1,
                    Pershrkim = "Kerkesa u refuzua"
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<MarrjeLibri> MerrTeGjitha()
        {
            return _liberPerrepository.GetAll().ToList();
        }

        public async Task AprovoKerkese(string KerkseID)
        {
            //Test Commit
            var kerkese = this.GjejKerkese(KerkseID);
            kerkese.Status = true;
            kerkese.DataAprovimit = DateTime.Now;
            kerkese.DataKthimit = kerkese.DataKthimit;
            await this._repository3.UpdateAsync(kerkese);
        }

        public List<KerkeseMarrjeLibri> GjitheKerkesat()
        {
            return _repository3.GetAll().ToList();
        }

        public KerkeseMarrjeLibri GjejKerkese(string id)
        {
            return this._repository3.GetAll().AsQueryable().Where(p => p.Id == Guid.Parse(id)).FirstOrDefault();
        }
        public async Task<KerkesePrind> ShtoKerkese(KerkesePrind kerkese)
        {
            try
            {
                return await _repositoryKerkesePrind.AddAsync(kerkese);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<dynamic> BejKerkese(KerkeseMarrjeLibri entity)
        {
            try
            {
               return await this._repository3.AddAsync(entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool KontrolloInventarin(string liberId)
        {
            try
            {
                var check = true;
                var invRow = _invRep.GetAll().AsQueryable().Where(p => p.LiberId == Guid.Parse(liberId)).FirstOrDefault();
                if (invRow == null)
                {
                    check = false;
                }
                return check;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<MarrjeLibri> MerrLeshimet()
        {
            try
            {
                return this._liberPerrepository.GetAll().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<KerkeseMarrjeLibri> MerrKerkesat()
        {
            return _repository3.GetAll().ToList();
        }
        public async Task<int> LeshoLiber(LeshoLiberBusiness entity)
        {
            using (var transaction = this._librariaContext.Database.BeginTransaction())
            {
                try
                {
                    foreach(var liberId in entity.LibratId)
                    {
                        //Kontrollo nqs Lexuesi ka marre 5 libra
                        var marrjeLibriTabele = this._liberPerrepository.GetAll().AsQueryable().Where(p => p.LexuesId == entity.LexuesId && p.DataKthimit == null).ToList();
                        if (marrjeLibriTabele.Count >= 5)
                        {
                            throw new ApplicationException("Lexuesi ka 5 ose me shume libra te pakthyer");
                        }
                        var liber = _repository.GetAll().AsQueryable().Where(p => p.ID == liberId).FirstOrDefault();
                        var statusDhene = statusRep.GetAll().AsQueryable().Where(p => p.Pershkrimi == "I dhene").FirstOrDefault().ID;
                        liber.Statusi = statusDhene;
                        liber.DataPerditesimit = DateTime.Now;
                        var invRow = _invRep.GetAll().AsQueryable().Where(p => p.LiberId == liberId).FirstOrDefault();
                        invRow.SasiaNeMagazine--;
                        if (invRow.SasiaNeMagazine == 0)
                        {
                            invRow.NevojePerFurnuzim = true;
                            throw new ApplicationException("Per kete liber nuk ka furnzime");

                        }
                        await _invRep.UpdateAsync(invRow);
                        await _repository.UpdateAsync(liber);
                        var marrjeLibri = new MarrjeLibri()
                        {
                            LexuesId = entity.LexuesId,
                            Aprovuesi = entity.AprovuesId,
                            LiberId = liberId,
                            TipiLeshimit = entity.TipiLEshimit.Value,
                            Status = true

                        };

                        await _liberPerrepository.AddAsync(marrjeLibri);
                       
                    }
                    await transaction.CommitAsync();
                    return 1;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
           
        }
        public async Task<dynamic> KtheLiber(string kthimLibriObjectId)
        {
            try
            {
            //    var leshimLibriObject = _liberPerrepository.GetAll().AsQueryable().Where(p => p.ID == Guid.Parse(kthimLibriObjectId)).FirstOrDefault();
            //    leshimLibriObject.DataKthimit = DateTime.Now;
            //    leshimLibriObject.Status = false;
            //    await _liberPerrepository.UpdateAsync(leshimLibriObject);
            //    var liber = _repository.GetAll().AsQueryable().Where(p => p.ID == leshimLibriObject.LiberId).FirstOrDefault();
            //    var statusKthyer = statusRep.GetAll().AsQueryable().Where(p => p.Pershkrimi == "I Ri").FirstOrDefault().ID;
            //    liber.Statusi = statusKthyer;
            //    liber.DataPerditesimit = DateTime.Now;
            //    var invRow = _invRep.GetAll().AsQueryable().Where(p => p.LiberId == leshimLibriObject.LiberId).FirstOrDefault();
            //    invRow.SasiaNeMagazine++;
            //    await _invRep.UpdateAsync(invRow);
            //    await _repository.UpdateAsync(liber);
                return (new
                {
                    KodiDaljes = 1,
                    Pershrkim = "Libri u kthye me sukses"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
