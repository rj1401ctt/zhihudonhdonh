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
    public class 意见反馈Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();

        [HttpPost]//添加意见
        [Route("api/Opinion/{id}/add")]
        public int AddOpinion(string id, [FromBody] 意见反馈 u)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            //需要做时间验证
            //开始时间小于结束时间
           if(rs!=null)
           {
               u.用户Id = rs.Id;
               entityServices.意见反馈Service.NewSave(u);
               return 1;
           }


            return 0;
        }



    }
}