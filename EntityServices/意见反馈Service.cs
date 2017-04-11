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
    public class 意见反馈Service : BaseServices<意见反馈>
    {
        public 意见反馈Service(IUnitOfWork _context, 意见反馈Repository _Repository) : base(_context, _Repository) { }
        public 意见反馈 GetById(int id)
        {
            ISpecification<意见反馈> sp = new DirectSpecification<意见反馈>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
    
 
    


    }
}
