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
    public class 动态点赞记录Service : BaseServices<动态点赞记录>
    {
        public 动态点赞记录Service(IUnitOfWork _context, 动态点赞记录Repository _Repository) : base(_context, _Repository) { }
        public 动态点赞记录 GetById(int id)
        {
            ISpecification<动态点赞记录> sp = new DirectSpecification<动态点赞记录>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
    
 
    


    }
}
