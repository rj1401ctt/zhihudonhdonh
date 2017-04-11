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
    public class  活动Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();


        [HttpPost]//添加活动
        [Route("api/activity/{id}/add")]
        public int Addactivity(string id,[FromBody] 活动 u)
        {
            用户 rs=entityServices.用户Service.GetByPhome(id);
            //需要做时间验证
            //开始时间小于结束时间
            if(u.开始时间.Year>2000 && u.结束时间.Year >2000 && u.报名截止时间.Year>2000 )
            {
                if(rs!=null&& DateTime.Compare(u.开始时间,u.结束时间)<0 && DateTime.Compare(u.报名截止时间,u.结束时间)<=0 &&u.报名截止时间.Year>=DateTime.Now.Year)
              {
               
                u.喜欢人数 = 0;
                u.阅读人数 = 0;
                u.报名人数 = 0;
                DateTime dt = DateTime.Now; ;
               
                u.发起时间 = dt;
                u.用户Id = rs.Id;
                entityServices.活动Service.NewSave(u);
                
                    return 1;
                }
            }
            
         
            return 0;
        }

        [HttpPost]//获取活动详细内容
        [Route("api/hd_GetActivities/get")]
        public DataTable hd_GetActivities([FromBody]活动 u)
        {
         
            return entityServices.活动Service.hd_GetActivities(u.Id);
        }
        [HttpPost]//获取最新活动
        [Route("api/hd_GetNewActivities/get")]
        public string hd_GetNewActivities([FromBody]活动 u)
        {

            return entityServices.活动Service.hd_GetNewActivities(u.内容);
        }
        [HttpPost]//刷新最新活动
        [Route("api/hd_GetNewActivities/get2")]
        public string hd_GetNewActivities2([FromBody]活动 u)
        {

            return entityServices.活动Service.hd_GetNewActivities(u.内容,u.Id);
        }

        [HttpPost]//获取最热活动
        [Route("api/hd_GetheatActivities/get")]
        public string hd_GetheatActivities([FromBody]活动 u)
        {

            return entityServices.活动Service.hd_GetheatActivities(u.内容);
        }
        [HttpPost]//获取最热活动
        [Route("api/hd_GetheatActivities/get2")]
        public string hd_GetheatActivities2([FromBody]活动 u)
        {

            return entityServices.活动Service.hd_GetheatActivities(u.内容,u.Id);
        }


        [HttpGet]//获取我的活动
        [Route("api/hd_GetmeActivities/{id}")]
        public string hd_GetmeActivities(string id)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            if (rs != null)
            {
                return entityServices.活动Service.hd_GetmeActivities(rs.Id);
            }
            return "0";
        }
    }
}