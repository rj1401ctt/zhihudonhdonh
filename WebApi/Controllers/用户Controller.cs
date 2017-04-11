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
using System.Web;
using Newtonsoft.Json;

namespace WEBAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //  [RoutePrefix("user")]

    public class 用户Controller : ApiController
    {
        chidrenEntityServicesFactory entityServices = new chidrenEntityServicesFactory();


        [HttpPost] //登入
        [Route("api/user/login")]
        public 用户 Login([FromBody] 用户 u)
        {

            用户 result = entityServices.用户Service.GetByPhome(u.手机号);
            if (result == null)
            {
                u.Id = -1;
                return u;
            }
            else if (result != null && result.密码 == entityServices.用户Service.MD5Encrypt(u.密码))
            {
                return entityServices.用户Service.UserLogin(result);
            }
            else
            {
                u.Id = 0;
                return u;
            }
        }

        [HttpPost] //个人资料
        [Route("api/user/me")]
        public string me([FromBody] 用户 u)
        {
       
            var query = from n in entityServices.用户Service.GetList()
                         where n.手机号 == u.手机号
                         select new
                         {
                             昵称 = n.昵称,
                              收藏 = n.喜欢记录.Count,
                             活动 = n.活动.Count,
                             好友 = n.好友.Count,
                             生日 = n.生日,
                             个性签名 = n.个性签名,
                             地址=n.地址,
                             头像=n.头像,
                             性别=n.性别,
                             id = n.Id
                         };

            return JsonConvert.SerializeObject(query); ;
     
        }

        [HttpPost]//注册
        [Route("api/user/add")]
        public int Add([FromBody]用户 u)
        {
            用户 result = entityServices.用户Service.GetByPhome(u.手机号);
            if (result == null && u.手机号 != null && u.密码 != null && u.头像 != null)
            {
                
                u.delete = false;
                u.密码 = entityServices.用户Service.MD5Encrypt(u.密码);
                //  entityServices.用户Service.UserLogin(u);
                entityServices.用户Service.NewSave(u);
                return 1;
            }
            return 0;
        }
        [HttpPost]//修改密码
        [Route("api/user/uppwd")]
        public int uppwd([FromBody]用户 u)
        {
            用户 result = entityServices.用户Service.GetByPhome(u.手机号);
            if (result == null)
            {
                return -1;

            }
            else if (u.密码 != null)
            {
                result.密码 = entityServices.用户Service.MD5Encrypt(u.密码);
                entityServices.用户Service.Modify(result);
                return 1;
            }
            return 0;
        }
        [HttpPost]//修改资料
        [Route("api/user/upzl")]
        public int upzl([FromBody]用户 u)
        {
            用户 result = entityServices.用户Service.GetByPhome(u.手机号);
            if (result == null)
            {
                return -1;

            }
            else
            {
                result.头像=u.头像;
                result.生日=u.生日;
                result.性别=u.性别;
                result.昵称=u.昵称;
                  entityServices.用户Service.Modify(result);
                return 1;
            }
           
            return 0;
        }

        [HttpPost]//图片保存
        [Route("api/{user}/image/upload")]
        public string Post(string user)
        {
            
            System.DateTime currentTime = new System.DateTime();
                     currentTime = System.DateTime.Now; 
              string y=currentTime.Year.ToString();
              string m = currentTime.Month.ToString();
              string d = currentTime.Day.ToString();
              string h = currentTime.Hour.ToString();
              string Minute = currentTime.Minute.ToString();
              string Second = currentTime.Second.ToString();
              //指定一个int型参数作为随机种子
              long tick = DateTime.Now.Ticks;
              Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
              int iUp = 10000;
              int iDown = 1;
              user = user + "-sj-" + y + "-" + m + "-" + d + "-" + h + "-" + Minute + "-" + Second  + "-sjs-" + ran.Next(iDown, iUp).ToString();
            HttpPostedFile file = HttpContext.Current.Request.Files[0];
            string[] temp = file.FileName.Split('.');
            string strPath = "D:/qiniu/" + user + "."+temp[1];
            file.SaveAs(strPath);
            string ret = "http://ogzbtvflm.bkt.clouddn.com/" + user + "." + temp[1];
            return ret;
        }


    }
}