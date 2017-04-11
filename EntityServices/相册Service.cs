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
    public class 相册Service : BaseServices<相册>
    {
        public 相册Service(IUnitOfWork _context, 相册Repository _Repository) : base(_context, _Repository) { }
        public 相册 GetById(int id)
        {
            ISpecification<相册> sp = new DirectSpecification<相册>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
    
 
    


    }
}
