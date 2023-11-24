using DinkToPdf;
using DinkToPdf.Contracts;
using Libraria.Business.Service;
using Libraria.Entity.Entities;
using Libraria.Models.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApplicationException = Libraria.Entity.Entities.ApplicationException;

namespace Libraria.Mediator
{
    public class LibrariaMediator : ILibrariaMediator
    {
        private readonly ILexuesService _lexuesService;
        private readonly ILIbrariaService _lIbrariaService;
        private readonly ILIberService _lIberService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAccountService _accountService;
        private IConverter _converter;

        public LibrariaMediator(ILexuesService lexuesService, 
            ILIbrariaService lIbrariaService ,
            ILIberService IberService,
            IConverter converter,
            IHttpContextAccessor httpContextAccessor,
            IAccountService accountService)
        {
            _lexuesService = lexuesService;
            _lIbrariaService = lIbrariaService;
            _lIberService = IberService;
            _httpContextAccessor = httpContextAccessor;
            _accountService = accountService;
            _converter = converter;
        }
        public List<KerkeseMarrjeLibri> MerrKerkesat()
        {
            return _lIbrariaService.MerrKerkesat();
        }
        public async Task<ResponseDTO> BejKerkese(KerkeseMarrjeLibriDTO dto)
        {
            try
            {
                var loggedUserId = "B08E83E0-6947-4A45-A7DB-08D9D2D777AF";// _httpContextAccessor.HttpContext.User.Identities.FirstOrDefault().Claims.ElementAt(2).Value;
                var lexues = await _lexuesService.GjejLexues(loggedUserId);
                var kerkesePrind = new KerkesePrind()
                {
                    DataKerkese = DateTime.Now,
                    DitelindjaLexuesit = lexues.Datelindja,
                    KerkuesId = lexues.Id,
                    MbiemerLexuesi = lexues.Emri,
                    EmerLexuesi = lexues.Mbiemri,
                    NmrLibrave = dto.LiberId.Count,
                    Status = false
                };
                var kerkesePrindNew = await _lIbrariaService.ShtoKerkese(kerkesePrind);
                foreach (var l in dto.LiberId)
                {
                    var kerkese = new KerkeseMarrjeLibri()
                    {
                        LiberId = l,
                        KerkuesId = new Guid("B08E83E0-6947-4A45-A7DB-08D9D2D777AF"),
                        DataMarrjes = dto.DataMarrjes,
                        EmerLexuesi = lexues.Emri,
                        MbiemerLexuesi = lexues.Mbiemri,
                        DitelindjaLexuesit = lexues.Datelindja,
                        KerksesaPrind = kerkesePrindNew.Id,

                    };
                    var result = await _lIbrariaService.BejKerkese(kerkese);

                }

                var resDto = new ResponseDTO()
                {
                    KodiDaljes = 1,
                    Pershkrim = "Kerkesa u be me sukses"
                };
                return resDto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ResponseDTO> RefuzoKerkese(string KerkseID)
        {
            try
            {
                var result = await _lIbrariaService.RefuzoKerkese(KerkseID);
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

        public List<Lexues> MerrLexuesit()
        {
            try
            {
                return this._lexuesService.MerrLexuesit();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ResponseDTO> AprovoKerkese(string KerkseID)
        {
            try
            {
                var kerkese = _lIbrariaService.GjejKerkese(KerkseID);
                var librat = new List<Guid>();
                librat.Add(kerkese.LiberId);
                var leshoLIberDTo = new LeshoLiberDTO()
                {
                    LexuesId = new Guid("B08E83E0-6947-4A45-A7DB-08D9D2D777AF"),
                    LibratId = librat
                };
                var check = _lIbrariaService.KontrolloInventarin(kerkese.LiberId.ToString());
                if(check == false)
                {
                    throw new Entity.Entities.ApplicationException("Nuk ka informacion per kete liber");
                    
                }
                await this._lIbrariaService.AprovoKerkese(KerkseID);
                //return await this.LeshoLiber(leshoLIberDTo);
                var resDto = new ResponseDTO()
                {
                    KodiDaljes = 1,
                    Pershkrim = "Kerkesa u aprovua me sukses"
                };
                return resDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Lexues GjejLexues(string id)
        {
            try
            {
                return  _lexuesService.GJejLexues(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ResponseDTO> LeshoLiberKerkese(string kerkeseId)
        {
            try
            {
                //var loggedUserId = _httpContextAccessor.HttpContext.User.Identities.FirstOrDefault().Claims.ElementAt(3).Value;
                //var loggedUser = await _accountService.GjejPerdorues(loggedUserId);
                //var kerkesa = this._lIbrariaService.GjejKerkese(kerkeseId);
                //if(kerkesa.Status != true)
                //{
                //    throw new Entity.Entities.ApplicationException("Kjo kerkese nuk eshte aprovuar");
                //}
                //var leshoLiberObject = Mapper.BusinessMapper.DTOTOBusiness();
                //var result = await _lIbrariaService.LeshoLiber(leshoLiberObject);
                var resDto = new ResponseDTO()
                {
                    KodiDaljes = 1,
                    Pershkrim = "Librat u leshuan me sukses"
                };
                return resDto;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ResponseDTO> LeshoLiber(LeshoLiberDTO liberDTO)
        {
            try
            {
                var loggedUserId = _httpContextAccessor.HttpContext.User.Identities.FirstOrDefault().Claims.Where(p => p.Type == ClaimTypes.PrimarySid).Select(p => p.Value).FirstOrDefault();
                var loggedUser = await _accountService.GjejPerdorues(loggedUserId);
                var lexuesId = liberDTO.LexuesId;
                var countMarrjeLIbri = this._lIbrariaService.MerrLeshimet().Where(p => p.LexuesId == lexuesId && p.DataKthimit == null).ToList().Count;
                if(countMarrjeLIbri > liberDTO.LibratId.Count)
                {
                    throw new ApplicationException("Lexuesi ka mundesi te marre vetem" + (5 - countMarrjeLIbri).ToString() + "pasi ka marre " + countMarrjeLIbri + "libra.");
                }

                var leshoLiberObject = Mapper.BusinessMapper.DTOTOBusiness(liberDTO);
                leshoLiberObject.TipiLEshimit = liberDTO.TipiLeshimit;
                leshoLiberObject.AprovuesId = Guid.Parse(loggedUser.Id);
                var res = await this._lIbrariaService.LeshoLiber(leshoLiberObject);
                var resDto = new ResponseDTO()
                {
                    KodiDaljes = res,
                    Pershkrim = "Librat u leshuan me sukses"
                };
                return resDto;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ResponseDTO> ShtoLexues(ShtoLexuesDTO shtoLexuesDTO)
        {
            try
            {
                var lexues = Libraria.Mapper.BusinessMapper.LexuesDTOToEntity(shtoLexuesDTO);
                var result = await _lexuesService.ShtoLexues(lexues);
                if(result.GetType().GetProperty("KodiDaljes").GetValue(result, null) == 1)
                {
                    var idLexues = result.GetType().GetProperty("IdLexues").GetValue(result, null);
                    var pdfKontent = result.GetType().GetProperty("pddKontent").GetValue(result, null);
                    var globalSettings = new GlobalSettings
                    {
                        ColorMode = ColorMode.Color,
                        Orientation = Orientation.Portrait,
                        PaperSize = PaperKind.Executive,
                        Margins = new MarginSettings { Top = 10 },
                        DocumentTitle = lexues.Karta,
                        Out = Path.Combine(@"C:\Users\User\source\repos\Libraria\Libraria\Documents\KarteLeximi\" + Path.GetFileNameWithoutExtension(lexues.Karta) + ".pdf")
                    };
                    var objectSettings = new ObjectSettings
                    {
                        PagesCount = true,
                        HtmlContent = pdfKontent
                    };
                    var pdf = new HtmlToPdfDocument()
                    {
                        GlobalSettings = globalSettings,
                        Objects = { objectSettings }
                    };
                    _converter.Convert(pdf);
                }
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
