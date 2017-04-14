using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using WZVTC.SoftDev.DDDFW.Domain.Core;
using WZVTC.SoftDev.DDDFW.EntityServices;
using WZVTC.SoftDev.DDDFW.Domain.Specification;
using System.Data;
using Newtonsoft.Json;

namespace EntityServices
{
    public class 报名记录Service : BaseServices<报名记录>
    {
        public 报名记录Service(IUnitOfWork _context, 报名记录Repository _Repository) : base(_context, _Repository) { }
        public 报名记录 GetById(int id)
        {
            ISpecification<报名记录> sp = new DirectSpecification<报名记录>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
        public 报名记录 GetuserId(int id,int hdid)
        {
            ISpecification<报名记录> sp = new DirectSpecification<报名记录>(x => x.用户Id == id && x.活动Id==hdid);
            return base.GetByCondition(sp);
        }

      
        public string GetSignup(int  id)
        {
            DataTable dt = new DataTable();
            var query = from n in base.GetList() where n.活动Id == id && n.是否失效==false select new { 用户id = n.用户Id,姓名=n.姓名, 联系=n.联系方式, 报名时间 = n.报名时间,头像=n.用户.头像 };
            return JsonConvert.SerializeObject(query);
        }
        //我的凭证
        public string hd_GetmeActivities(int id)
        {


            var dt = DateTime.Now;

            var query = from n in base.GetList()
                        where n.用户Id == id
                        orderby n.Id descending
                        select new
                        {
                            标题 = n.活动.标题,
                            开始时间 = n.活动.开始时间,
                            主题 = n.活动.主题图片,
                            头像 = n.用户.头像,
                            手机号 = n.用户.手机号,
                            id = n.活动.Id,
                            地址 = n.活动.活动地址,
                            二维码 = "活动：" + n.活动.标题 + ",联系人：" +n.姓名 + ",联系电话：" + n.联系方式,
                            状态 = dt > n.活动.结束时间 ? "已结束" : "进行中"
                           
                        };
            return JsonConvert.SerializeObject(query);


        }

    }
}
