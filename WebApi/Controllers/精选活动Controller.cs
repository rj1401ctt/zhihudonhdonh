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
    public class 精选活动Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();

        
        [HttpGet]//获取精选活动
        [Route("api/SActivities/get")]
        public DataTable GetSActivities()
        {
           return entityServices.精选活动Service.GetSActivities();
        }

        [HttpPost]//获取下拉刷新精选活动
        [Route("api/RSActivities/get")]
        public DataTable GetRSActivities([FromBody]精选活动 u)
        {
            return entityServices.精选活动Service.GetSActivities(u.Id);
        }

    }
}