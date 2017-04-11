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
    public class 关注Service : BaseServices<关注>
    {
        public 关注Service(IUnitOfWork _context, 关注Repository _Repository) : base(_context, _Repository) { }
        public 关注 GetById(int id)
        {
            ISpecification<关注> sp = new DirectSpecification<关注>(x => x.id == id);
            return base.GetByCondition(sp);
        }
        public 关注 GetByhy(int gz, int bgz)
        {
            ISpecification<关注> sp = new DirectSpecification<关注>(x => x.好友编号 == gz && bgz==x.用户Id);
            return base.GetByCondition(sp);

        }
        //获取关注列表
        public string follow_list(int id)
        {
           
            var query = from n in base.GetList() where n.好友编号== id select new { 用户头像= n.用户.头像, 用户姓名= n.用户.昵称, 个性签名 = n.用户.个性签名 };
          return  JsonConvert.SerializeObject(query);
        
        }
           


    }
}
