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

namespace EntityServices
{
    public class 动态评论Service : BaseServices<动态评论>
    {
        public 动态评论Service(IUnitOfWork _context, 动态评论Repository _Repository) : base(_context, _Repository) { }
        public 动态评论 GetById(int id)
        {
            ISpecification<动态评论> sp = new DirectSpecification<动态评论>(x => x.Id == id);
            return base.GetByCondition(sp);
        }


        //public DataTable GetMyAnswer(人员账号 u)
        //{
        //    DataTable dt = new DataTable();
        //    var query = from n in u.活动评论 where n.发布时间 != null select new { 活动评论id = n.Id, 问题id = n.问题Id, 问题标题 = n.问题.标题, 内容 = n.内容, 发布时间 = n.发布时间 };
        //    string[] lie = new string[] { "活动评论id", "问题id", "问题标题", "内容", "发布时间" };
        //    for (int i = 0; i < lie.Length; i++)
        //    {
        //        dt.Columns.Add(lie[i]);
        //    }
        //    foreach (var i in query)
        //    {
        //        DataRow dr = dt.NewRow();
        //        dr["活动评论id"] = i.活动评论id;
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
