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
    public class 关注Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();




        [HttpPost]   //添加关注
        [Route("api/follow/{id}/get")]
        public int follow(string id,[FromBody]关注 u)
        {
            关注 new1 = new 关注();
            用户 b=entityServices.用户Service.GetByPhome(id);
             if(u.用户Id==b.Id)
             {
                 //不能关注自己
                 return 0;
             }
             else
             {
                 new1.好友编号 =b.Id ;
                 new1.用户Id = u.用户Id;
                 entityServices.关注Service.NewSave(new1);
                 return 1;
             }
        }
        [HttpPost]   //判断关注
        [Route("api/pdfollow/{id}/get")]
        public int pd_follow(string id,[FromBody] 关注 u)
        {
            用户 a=entityServices.用户Service.GetByPhome(id);
            if (null != entityServices.关注Service.GetByhy(a.Id, u.用户Id))
                return 1;
            else
                return 0;
        }
        [HttpPost]   //取消关注
        [Route("api/qxfollow/{id}/get")]
        public int qx_follow(string id,[FromBody] 关注 u)
        {
            用户 a = entityServices.用户Service.GetByPhome(id);
            if (null != entityServices.关注Service.GetByhy(a.Id, u.用户Id))
            {
                entityServices.关注Service.Remove(entityServices.关注Service.GetByhy(a.Id, u.用户Id));
                return 1;
            }
            else
                return 0;
        }

        [HttpPost]   //获取用户关注列表
        [Route("api/followlist/get")]
        public string follow_list([FromBody] 关注 u)
        {
            用户 a = entityServices.用户Service.GetByPhome(u.好友编号.ToString());
            return entityServices.关注Service.follow_list(a.Id);
        }
        //public int ynfollow([FromBody] 关注 u)
        //{
        //       关注 a=entityServices.关注Service.GetById
        //}


    }
}