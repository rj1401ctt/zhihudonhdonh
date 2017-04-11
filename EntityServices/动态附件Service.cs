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
    public class 动态附件Service : BaseServices<动态附件>
    {
        public 动态附件Service(IUnitOfWork _context, 动态附件Repository _Repository) : base(_context, _Repository) { }
        public 动态附件 GetById(int id)
        {
            ISpecification<动态附件> sp = new DirectSpecification<动态附件>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
        public 动态附件 GetddId(int id)
        {
            ISpecification<动态附件> sp = new DirectSpecification<动态附件>(x => x.动态Id == id);
            return base.GetByCondition(sp);
        }
 
    


    }
}
