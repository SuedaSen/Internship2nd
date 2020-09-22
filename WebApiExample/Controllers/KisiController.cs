using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    public class KisiController : ApiController
    {
        [HttpGet]
        public List<KisiBilgileri> GetAllData()
        {
            var responseList = new List<KisiBilgileri>
            {
                new KisiBilgileri{
                    Ad="Serkan",
                    Soyad="Topkan",
                },
                new KisiBilgileri{
                    Ad="Süeda",
                    Soyad="Şen",
                },
                new KisiBilgileri{
                    Ad="Selcen",
                    Soyad="Işık",
                },
                new KisiBilgileri{
                    Ad="İSBAK",
                    Soyad="A.Ş",
                },
            };

            return responseList;
        }
    }
}