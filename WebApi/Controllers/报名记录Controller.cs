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
    public class 报名记录Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();

        [HttpPost]//报名
        [Route("api/signup/{id}/add")]
        public int Addsignup(string id, [FromBody] 报名记录 u)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            活动 hd = entityServices.活动Service.GetById(u.活动Id);
            if (rs.Id == hd.用户Id)
               return -1;//不能报名自己的活动 
            else if(entityServices.报名记录Service.GetuserId(rs.Id,u.活动Id)!=null)
            {
                //不能重复报名
                return 0;
            }
            else
            {   //报名人数 和喜欢人数可能要删！！！
                DateTime dt = DateTime.Now; ;
                u.报名时间 = dt;
                u.是否失效 = false;
                u.用户Id = rs.Id;
                hd.报名人数 = hd.报名人数 + 1;
                entityServices.活动Service.Modify(hd);//报名人数+1
                entityServices.报名记录Service.NewSave(u);
                return 1;
            }


           
        }

        [HttpPost]   //获取报名列表
        [Route("api/signup/get")]
        public string GetSignup([FromBody] 报名记录 u)
        {

            return entityServices.报名记录Service.GetSignup(u.Id);
        }
        [HttpGet]//获取我的报名凭证
        [Route("api/me_signup/{id}")]
        public string me_signup(string id)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            if (rs != null)
            {
                return entityServices.报名记录Service.hd_GetmeActivities(rs.Id);
            }
            return "0";
        }
    }
}