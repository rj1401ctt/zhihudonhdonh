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
using Newtonsoft.Json;

namespace EntityServices
{
    public class 动态Service : BaseServices<动态>
    {
        public 动态Service(IUnitOfWork _context, 动态Repository _Repository) : base(_context, _Repository) { }
        public 动态 GetById(int id)
        {
            ISpecification<动态> sp = new DirectSpecification<动态>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
        public 动态 GetBydata(int id,DateTime fb)
        {
            ISpecification<动态> sp = new DirectSpecification<动态>(x => x.用户Id == id && x.发布时间==fb);
            return base.GetByCondition(sp);
        }
        public string Getmove()
        {

            var query = (from n in base.GetList()
                         orderby n.Id descending
                         select new
                         {
                             内容 = n.内容,
                             评论时间 = n.发布时间,
                             用户头像 = n.用户.头像,
                             用户id = n.用户Id,
                             手机号 = n.用户.手机号,
                             用户名 = n.用户.昵称,
                             id = n.Id,
                             图片=n.动态附件,
                             点赞=n.点赞数
                         }).Take(4);

            return JsonConvert.SerializeObject(query); ;
        }

        public string Getmemove(int id)
        {

            var query = (from n in base.GetList() where n.用户Id==id
                         orderby n.Id descending
                         select new
                         {
                             内容 = n.内容,
                             评论时间 = n.发布时间,
                             用户头像 = n.用户.头像,
                             用户id = n.用户Id,
                             手机号 = n.用户.手机号,
                             用户名 = n.用户.昵称,
                             id = n.Id,
                             图片 = n.动态附件,
                             点赞 = n.点赞数
                         }).Take(4);

            return JsonConvert.SerializeObject(query); ;
        }

    }
}
