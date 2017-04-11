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
    public class 精选活动Service : BaseServices<精选活动>
    {
        public 精选活动Service(IUnitOfWork _context, 精选活动Repository _Repository) : base(_context, _Repository) { }
        public 精选活动 GetById(int id)
        {
            ISpecification<精选活动> sp = new DirectSpecification<精选活动>(x => x.Id == id);
            return base.GetByCondition(sp);
        }
        //获取加载精选活动信息
        public DataTable GetSActivities(int id)
        {
            DataTable dt = new DataTable();
        if(id!=0)
        {

       
              
            //n.id>id;
               var query = (from n in base.GetList() where n.Id < id && n.活动.delete == false orderby n.Id descending select new { 用户头像 = n.活动.用户.头像, 用户昵称 = n.活动.用户.昵称, 活动封面 = n.活动.主题图片, 开始时间 = n.活动.开始时间, 活动地址 = n.活动.活动地址, 用户id = n.活动.用户Id, 活动id = n.活动Id, 精选id = n.Id, 标题 = n.活动.标题 ,手机号=n.活动.用户.手机号}).Take(10);
                string[] lie = new string[] { "用户头像", "用户昵称", "活动封面", "开始时间", "活动地址", "用户id","活动id","精选id","标题","手机号"};
               for (int i = 0; i < lie.Length; i++)
               {
                   dt.Columns.Add(lie[i]);
               }
               foreach (var i in query)
               {
                   DataRow dr = dt.NewRow();
                   dr["用户头像"] = i.用户头像;
                   dr["用户昵称"] = i.用户昵称;
                   dr["活动封面"] = i.活动封面;
                   dr["开始时间"] = i.开始时间;
                   dr["活动地址"] = i.活动地址;
                   dr["用户id"] = i.用户id;
                   dr["活动id"] = i.活动id;
                   dr["精选id"] = i.精选id;
                   dr["标题"] = i.标题;
                   dr["手机号"] = i.手机号;
                   dt.Rows.Add(dr);
               }
               return dt;
        }
        return dt;
        }
        public DataTable GetSActivities()
        {

            DataTable dt = new DataTable();
            //n.id>id;

            var query = (from n in base.GetList() where n.活动.delete == false orderby n.Id descending select new { 用户头像 = n.活动.用户.头像, 用户昵称 = n.活动.用户.昵称, 活动封面 = n.活动.主题图片, 开始时间 = n.活动.开始时间, 活动地址 = n.活动.活动地址, 用户id = n.活动.用户Id, 活动id = n.活动Id, 精选id = n.Id, 标题 = n.活动.标题, 手机号 = n.活动.用户.手机号 }).Take(10);
            string[] lie = new string[] { "用户头像", "用户昵称", "活动封面", "开始时间", "活动地址", "用户id", "活动id", "精选id","标题","手机号"};
            for (int i = 0; i < lie.Length; i++)
            {
                dt.Columns.Add(lie[i]);
            }
            foreach (var i in query)
            {
                DataRow dr = dt.NewRow();
                dr["用户头像"] = i.用户头像;
                dr["用户昵称"] = i.用户昵称;
                dr["活动封面"] = i.活动封面;
                dr["开始时间"] = i.开始时间;
                dr["活动地址"] = i.活动地址;
                dr["用户id"] = i.用户id;
                dr["活动id"] = i.活动id;
                dr["精选id"] = i.精选id;
                dr["标题"] = i.标题;
                dr["手机号"] = i.手机号;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        //public DataTable GetMyAnswer(人员账号 u)
        //{
        //    DataTable dt = new DataTable();
        //    var query = from n in u.精选活动 where n.发布时间 != null select new { 精选活动id = n.Id, 问题id = n.问题Id, 问题标题 = n.问题.标题, 内容 = n.内容, 发布时间 = n.发布时间 };
        //    string[] lie = new string[] { "精选活动id", "问题id", "问题标题", "内容", "发布时间" };
        //    for (int i = 0; i < lie.Length; i++)
        //    {
        //        dt.Columns.Add(lie[i]);
        //    }
        //    foreach (var i in query)
        //    {
        //        DataRow dr = dt.NewRow();
        //        dr["精选活动id"] = i.精选活动id;
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
