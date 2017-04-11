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
using System.Security.Cryptography;

namespace EntityServices
{
    public class 主题Service : BaseServices<主题>
    {
        public 主题Service(IUnitOfWork _context, 主题Repository _Repository) : base(_context, _Repository) { }
        public 主题 GetById(int id)
        {
            ISpecification<主题> sp = new DirectSpecification<主题>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
        public DataTable GetTheme()
        {
            DataTable dt = new DataTable();
            var query = from n in base.GetList()  select new {Id = n.Id,名称=n.名称,图片=n.图片  };
            string[] lie = new string[] { "Id", "名称", "图片" };
            for (int i = 0; i < lie.Length; i++)
            {
                dt.Columns.Add(lie[i]);
            }
            foreach (var i in query)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = i.Id;
                dr["名称"] = i.名称;
                dr["图片"] = i.图片;
                dt.Rows.Add(dr);
            }
            return dt;
        }




    }
}
