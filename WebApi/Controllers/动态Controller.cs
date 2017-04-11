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
    public class 动态Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();



        [HttpPost]//添加活动
        [Route("api/move/{id}/add")]
        public int Addmove(string id, [FromBody] 动态 u)
        {
            
            用户 rs = entityServices.用户Service.GetByPhome(id);
            //需要做时间验证
            //开始时间小于结束时间
            if (rs!=null && u.内容!=null)
            {
                    u.点赞数 = 0;
                    DateTime dt = DateTime.Now; ;
                    u.发布时间 = dt;
                    u.用户Id = rs.Id;
                  
                    u.delete = false;
               
                
              entityServices.动态Service.NewSave(u);
                  return u.Id;

                
            }


            return 0;
        }
        [HttpGet]//获得我动态
        [Route("api/move/{id}/get")]
        public string MEmove(string id)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            //需要做时间验证
            //开始时间小于结束时间
            if (rs != null )
            {





                return entityServices.动态Service.Getmemove(rs.Id);


            }


            return "0";
        }
        [HttpGet]//删除
        [Route("api/move/{id}/del")]
        public int delmove(int id)
        {
            动态 rs = entityServices.动态Service.GetById(id);
            //需要做时间验证
            //开始时间小于结束时间
            if (rs != null)
            {
                动态附件 rz = entityServices.动态附件Service.GetddId(id);

                entityServices.动态附件Service.Remove(rz);

                entityServices.动态Service.Remove(rs);
                
                return 1;


            }


            return 0;
        }
        [HttpGet]//获得动动
        [Route("api/move/get")]
        public string Getmove()
        {
            

                return entityServices.动态Service.Getmove();


        }

    }
}