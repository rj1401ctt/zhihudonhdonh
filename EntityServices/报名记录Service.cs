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


    }
}
