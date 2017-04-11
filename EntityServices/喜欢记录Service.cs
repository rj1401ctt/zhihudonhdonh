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
    public class 喜欢记录Service : BaseServices<喜欢记录>
    {
        public 喜欢记录Service(IUnitOfWork _context, 喜欢记录Repository _Repository) : base(_context, _Repository) { }
        public 喜欢记录 GetById(int id)
        {
            ISpecification<喜欢记录> sp = new DirectSpecification<喜欢记录>(x => x.Id == id);
            return base.GetByCondition(sp);
        }

        public 喜欢记录 GetuserId(int id,int hdid)
        {
            ISpecification<喜欢记录> sp = new DirectSpecification<喜欢记录>(x => x.用户Id == id && x.活动Id == hdid);
            return base.GetByCondition(sp);
        }
        //获取收藏活动
        public string love_GetActivities(int id)
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
                            状态 = dt > n.活动.结束时间 ? "已结束" : "进行中"
                        };
            return JsonConvert.SerializeObject(query);
            //  Skip()  跳过前几项

        }
        //public DataTable GetMyAnswer(人员账号 u)
        //{
        //    DataTable dt = new DataTable();
        //    var query = from n in u.喜欢记录 where n.发布时间 != null select new { 喜欢记录id = n.Id, 问题id = n.问题Id, 问题标题 = n.问题.标题, 内容 = n.内容, 发布时间 = n.发布时间 };
        //    string[] lie = new string[] { "喜欢记录id", "问题id", "问题标题", "内容", "发布时间" };
        //    for (int i = 0; i < lie.Length; i++)
        //    {
        //        dt.Columns.Add(lie[i]);
        //    }
        //    foreach (var i in query)
        //    {
        //        DataRow dr = dt.NewRow();
        //        dr["喜欢记录id"] = i.喜欢记录id;
        //        dr["问题id"] = i.问题id;
        //        dr["问题标题"] = i.问题标题;
        //        dr["内容"] = i.内容;
        //        dr["发布时间"] = i.发布时间;
        //        dt.Rows.Add(dr);
        //    }
        //    return dt;
        //}


    }
}
