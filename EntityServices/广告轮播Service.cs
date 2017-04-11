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
    public class 广告轮播Service : BaseServices<广告轮播>
    {
        public 广告轮播Service(IUnitOfWork _context, 广告轮播Repository _Repository) : base(_context, _Repository) { }
        public 广告轮播 GetById(int id)
        {
            ISpecification<广告轮播> sp = new DirectSpecification<广告轮播>(x => x.Id == id);
            return base.GetByCondition(sp);
        }


        public DataTable GetAdvert(string lb, int x)
        {
            DataTable dt = new DataTable();
            var query = (from n in base.GetList() where  n.类别== lb orderby n.Id descending select new { 活动id=n.活动编号,图片=n.图片,标题=n.广告标题 }).Take(x);
            string[] lie = new string[] { "活动id", "图片","标题" };
            for (int i = 0; i < lie.Length; i++)
            {
                dt.Columns.Add(lie[i]);
            }
            foreach (var i in query)
            {
                DataRow dr = dt.NewRow();
                dr["活动id"] = i.活动id;
                dr["图片"] = i.图片;
                dr["标题"] = i.标题;
                dt.Rows.Add(dr);
            }
            return dt;
        }


    }
}
