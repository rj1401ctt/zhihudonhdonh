using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityServices;
using Model;
using System.Web.Http.Cors;
using System.Data;

namespace WEBAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class 广告轮播Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();


        [HttpGet]//获取精选广告
        [Route("api/advert/get")]
        public DataTable Getadvert()
        {
            return entityServices.广告轮播Service.GetAdvert("1",5);
        }

    }
}