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
    public class 动态附件Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();

         [HttpPost]//添加动动附件
        [Route("api/movefj/{id}/add")]
        public int Addmovefj(string id, [FromBody] 动态附件 u)
        {
            
            用户 rs = entityServices.用户Service.GetByPhome(id);
            动态 dt =entityServices.动态Service.GetById(u.动态Id);
            //需要做时间验证
            //开始时间小于结束时间
            if (rs!=null && dt!=null)
            {
               
                
              entityServices.动态附件Service.NewSave(u);
                  return 1;   
            }

            return 0;
         }
    }
}