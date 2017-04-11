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
    public class 主题Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();

        
        [HttpGet]//获取活动主题
        [Route("api/theme/get")]
        public DataTable GetTheme()
        {
            // IEnumerable<主题> aaa = entityServices.主题Service.GetList();
            return entityServices.主题Service.GetTheme();
        }

    }
}