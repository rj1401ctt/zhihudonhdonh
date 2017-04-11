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
    public class 用户Service : BaseServices<用户>
    {
        public 用户Service(IUnitOfWork _context, 用户Repository _Repository) : base(_context, _Repository) { }
        public 用户 GetById(int id)
        {
            ISpecification<用户> sp = new DirectSpecification<用户>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
        //获取手机号
        public 用户 GetByPhome(string Phome)
        {
            ISpecification<用户> sp = new DirectSpecification<用户>(x => x.手机号 == Phome);
            return base.GetByCondition(sp);
        }
        public string MD5Encrypt(string strText)//md5加密
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(strText));
            return System.Text.Encoding.Default.GetString(result);
        }
        public 用户 UserLogin(用户 result)//登录
        {
            用户 u = new 用户();
    
            u.Id = result.Id;
            u.类别 = result.类别;
            u.生日 = result.生日;
            u.地址 = result.地址;
            u.昵称 = result.昵称;
            u.手机号 = result.手机号;
            u.性别 = result.性别;
            u.头像 = result.头像;
            return u;
        }

        public 用户 GetMe(用户 result)
        {

            用户 u = new 用户(); ;
            u.Id = result.Id;
            u.生日 = result.生日;
            u.地址 = result.地址;
            u.昵称 = result.昵称;
            u.手机号 = result.手机号;
            u.头像 = result.头像;
            u.性别 = result.性别;
            u.个性签名 = result.个性签名;
            return u;
        }

        //public DataTable GetMyAnswer(人员账号 u)
        //{
        //    DataTable dt = new DataTable();
        //    var query = from n in u.用户 where n.发布时间 != null select new { 用户id = n.Id, 问题id = n.问题Id, 问题标题 = n.问题.标题, 内容 = n.内容, 发布时间 = n.发布时间 };
        //    string[] lie = new string[] { "用户id", "问题id", "问题标题", "内容", "发布时间" };
        //    for (int i = 0; i < lie.Length; i++)
        //    {
        //        dt.Columns.Add(lie[i]);
        //    }
        //    foreach (var i in query)
        //    {
        //        DataRow dr = dt.NewRow();
        //        dr["用户id"] = i.用户id;
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
