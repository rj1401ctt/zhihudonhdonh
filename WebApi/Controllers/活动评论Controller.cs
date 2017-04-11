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
using Newtonsoft.Json;

namespace WEBAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class 活动评论Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();

        [HttpPost]//添加活动评论
        [Route("api/discuss/{id}/add")]
        public string Adddiscuss(string id, [FromBody] 活动评论 u)
        {
            用户 rs = entityServices.用户Service.GetByPhome(id);
            活动 hd = entityServices.活动Service.GetById(u.活动Id);
     
         if(rs!=null && hd!=null )
            {
             DateTime dt = DateTime.Now; ;
             u.评论时间 = dt ;
             u.用户Id = rs.Id;
             entityServices.活动评论Service.NewSave(u);
             DataTable dt1 =new DataTable();
             string[] lie = new string[] { "评论时间", "用户id", "用户头像", "内容", "手机号","用户名"};
             for (int i = 0; i < lie.Length; i++)
             {
                 dt1.Columns.Add(lie[i]);
             }

             DataRow dr = dt1.NewRow();
             dr["评论时间"] = u.评论时间;
             dr["用户id"] = rs.Id;
             dr["用户头像"] = rs.头像;
             dr["内容"] = u.内容;
             dr["手机号"] = rs.手机号;
             dr["用户名"] = rs.昵称;
             dt1.Rows.Add(dr);
             return JsonConvert.SerializeObject(dt1);
        
             }
      
           

            return "0";
        }

        [HttpPost]//获取活动评论
        [Route("api/discuss/get")]
        public string Getdiscuss([FromBody] 活动评论 u)
        {
            活动 hd = entityServices.活动Service.GetById(u.活动Id);

            if ( hd != null)
            {
             
                return  entityServices.活动评论Service.Getdiscusslist(u.活动Id);

            }
            return "0";
        }
        [HttpPost]//加载活动评论
        [Route("api/discuss/get2")]
        public string Getdiscuss2([FromBody] 活动评论 u)
        {
            活动 hd = entityServices.活动Service.GetById(u.活动Id);

            if (hd != null)
            {

                return entityServices.活动评论Service.Getdiscusslist(u.活动Id,u.Id);

            }
            return "0";
        }

    }
}