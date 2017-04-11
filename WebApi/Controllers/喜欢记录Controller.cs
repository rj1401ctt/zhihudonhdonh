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
    public class 喜欢记录Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();

        [HttpPost]//添加收藏
        [Route("api/like/{id}/add")]
        public int Addlike(string id, [FromBody] 喜欢记录 u)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            活动 hd = entityServices.活动Service.GetById(u.活动Id);
            if (rs.Id == hd.用户Id)
                return -1;//不能收藏自己的活动
            else if (entityServices.喜欢记录Service.GetuserId(rs.Id, u.活动Id) != null)
                return 0; //已经收藏了
            else
            {   //报名人数 和喜欢人数可能要删！！！
                DateTime dt = DateTime.Now; ;
                u.喜欢时间 = dt.Date;
                u.用户Id = rs.Id;
                u.活动Id = u.活动Id;
                hd.喜欢人数 = hd.喜欢人数 + 1;
                entityServices.活动Service.Modify(hd);//喜欢人数加一
                entityServices.喜欢记录Service.NewSave(u);
                return 1;
            }


        }
        [HttpPost]//是否已经收藏
        [Route("api/like/{id}/get")]
        public int likeget(string id, [FromBody] 喜欢记录 u)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            活动 hd = entityServices.活动Service.GetById(u.活动Id);
           if (entityServices.喜欢记录Service.GetuserId(rs.Id, u.活动Id) != null)
                return 1; //已经收藏了
           else 
            return 0;
        }

        [HttpPost]//取消收藏
        [Route("api/like/{id}/del")]
        public int likedel(string id, [FromBody] 喜欢记录 u)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            活动 hd = entityServices.活动Service.GetById(u.活动Id);
            喜欢记录 a = entityServices.喜欢记录Service.GetuserId(rs.Id, u.活动Id);
            if (a != null)//已经收藏了
            {
                entityServices.喜欢记录Service.Remove(a);//取消收藏
                hd.喜欢人数 = hd.喜欢人数 -1;
                entityServices.活动Service.Modify(hd);//喜欢人数减一
                return 1; 
            }    
            else
                return 0;
        }


        [HttpGet]//获取我的收藏
        [Route("api/like/{id}")]
        public string likesc(string id)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
           if(rs!=null)
           {
               return entityServices.喜欢记录Service.love_GetActivities(rs.Id);
           }
           return "0";
        }
    
    }
}