using Libraria.Data.Repository;
using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraria.Business.Service
{
    public class LIberService : ILIberService
    {
        private readonly IRepository<Liber> _liberRepository;
        private readonly IRepository<KategoriLibri> _KatRepository;
        private readonly IRepository<StatusLibri> _statusRepository;
        private readonly IRepository<Inventari> _repInv;



        public LIberService(IRepository<Liber> liberRepository, IRepository<KategoriLibri> KatRepository, IRepository<Inventari> repInv, IRepository<StatusLibri> statusRepository)
        {
            _liberRepository = liberRepository;
            _KatRepository = KatRepository;
            _repInv = repInv;
            _statusRepository = statusRepository;
        }

        public Liber GjejLiber(string Id)
        {
            try
            {
                return _liberRepository.GetAll().Where(p => p.ID == Guid.Parse(Id)).FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<dynamic> ShtoLiber(Liber liber)
        {
            try
            {
                await this._liberRepository.AddAsync(liber);
                var liberId = liber.ID;
                var invRow = _repInv.GetAll().AsQueryable().Where(p => p.LiberId == liberId).FirstOrDefault();
                if(invRow == null)
                {
                    var Row = new Inventari()
                    {
                        LiberId = liberId,
                        Liber = liber,
                        SasiaNeMagazine = 1,
                        NevojePerFurnuzim = false
                    };
                    await _repInv.AddAsync(Row);
                }
                else
                {
                    invRow.SasiaNeMagazine++;
                    await _repInv.UpdateAsync(invRow);
                }
                return (new
                {
                    KodiDaljes = 1,
                    Pershrkim = "Libri u shtua me sukses"
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Liber> MerrLibratELire()
        {
            try
            {
                var statusFree = this._statusRepository.GetAll().AsQueryable().Where(p => p.Pershkrimi == "I Lire").FirstOrDefault().ID;
                var libratFree = this._liberRepository.GetAll().AsQueryable().Where(p => p.Statusi == statusFree).ToList();
                return libratFree;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Liber> MerrLibrat()
        {
            var librat =  this._liberRepository.GetAll().ToList();
            var LibratWithStatus = (from l in librat
                                    join s in _statusRepository.GetAll().ToList()
                                    on l.Statusi.Value equals s.ID
                                    select new Liber
                                    {
                                        Autori = l.Autori,
                                        DataPerditesimit = l.DataPerditesimit,
                                        DataRegj = l.DataRegj.Value,
                                        FotoLibbriUrl = l.FotoLibbriUrl,
                                        ID = l.ID,
                                        Status = s,
                                        Pershkrimi = l.Pershkrimi,
                                        FotoLibri = l.FotoLibri,
                                        Titulli = l.Titulli,
                                        Vendi = l.Vendi,
                                        Kategoria = l.Kategoria,
                                        Statusi = l.Statusi
                                    });
            var libratWithKate = (from l in librat
                                   join s in _KatRepository.GetAll().ToList()
                                   on l.Kategoria.Value equals s.ID
                                   select new Liber
                                   {
                                       Autori = l.Autori,
                                       DataPerditesimit = l.DataPerditesimit,
                                       DataRegj = l.DataRegj.Value,
                                       FotoLibbriUrl = l.FotoLibbriUrl,
                                       ID = l.ID,
                                       Status = l.Status,
                                       Pershkrimi = l.Pershkrimi,
                                       FotoLibri = l.FotoLibri,
                                       Titulli = l.Titulli,
                                       Vendi = l.Vendi,
                                       Kategoria = l.Kategoria,
                                       Statusi = l.Statusi,
                                       Kategori = s
                                   });
            return libratWithKate.ToList();
        }
    }
}
