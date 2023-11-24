using Libraria.Entity.Entities;
using System;
using System.Collections.Generic;
using Libraria.Models.DTO;
using System.Linq;
using System.Threading.Tasks;
using Libraria.Business.Business.Models;

namespace Libraria.Mapper
{
    public static class BusinessMapper
    {
        public static Perdorues MapFromDTOAccount(RegisterUserDTO dto)
        {
            try
            {
                var user = new Perdorues()
                {
                    Emri = dto.FirstName,
                    Mbiemri = dto.LastName,
                    Email = dto.Email,
                    EmailConfirmed = true,
                    PhoneNumber = dto.Phone,
                    FotoProfiliURl = @"C:\Users\User\source\repos\Libraria\Libraria\Documents\FotoProfili",
                    Foto = "userProfileUrl",
                    UserName = dto.FirstName + dto.LastName
                };
                return user;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static LeshoLiberBusiness DTOTOBusiness(LeshoLiberDTO dTO)
        {
            var entitity = new LeshoLiberBusiness()
            {
                LexuesId = dTO.LexuesId,
                TipiLEshimit = dTO.TipiLeshimit
            };
            var librat = (from d in dTO.LibratId
                          select d).ToList();
            entitity.LibratId = librat;
            return entitity;
        }
        public static Lexues LexuesDTOToEntity(ShtoLexuesDTO dto)
        {
            try
            {
                var lexues = new Lexues
                {
                    DataRegj = DateTime.Now,
                    Datelindja = dto.DateLindja,
                    Adresa = dto.Adresa,
                    Qyteti = dto.Qyteti,
                    Vendlindja = dto.VendLindja,
                    Atesia = dto.Atesia,
                    Memesia = dto.Memesia,
                    KodiPostar = dto.KodiPostar,
                    Universiteti = dto.Universiteti,
                    NumriId = dto.NumriId,
                    Email = dto.Email,
                    Emri = dto.Emer,
                    Mbiemri = dto.Mbiemer,
                    Foto = dto.FotoProfili,
                    FotoProfiliURl = @"C:\Users\User\source\repos\Libraria\Libraria\Documents\FotoProfili",
                    Karta = string.Empty,
                    KarteLeximiURL = string.Empty,
                    NmrId = dto.NumriId,
                    Statusi = true

                };
                return lexues;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
