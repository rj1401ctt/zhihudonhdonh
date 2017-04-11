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
    public class 活动Service : BaseServices<活动>
    {
        public 活动Service(IUnitOfWork _context, 活动Repository _Repository) : base(_context, _Repository) { }
        public 活动 GetById(int id)
        {
            ISpecification<活动> sp = new DirectSpecification<活动>(x => x.Id == id);
            return base.GetByCondition(sp);
        }

        //浏览量加+1
        public void hd_Browsevolume(int id)
        {
            活动 u = GetById(id);
            if(u!=null)
            {
                u.阅读人数 = u.阅读人数 + 1;
                base.Modify(u);
            }
          
        }
        //获取活动内容
        public DataTable hd_GetActivities(int id)
        {

            hd_Browsevolume(id);//流量加+1
            DataTable dt = new DataTable();
            //n.id>id;

            var query = GetById(id);
            if(query!=null)
            {

           
            string[] lie = new string[] {"报名人数", "发布时间","结束时间","活动地址", "报名截止时间", "标题", "开始时间", "主题图片", "内容", "喜欢人数", "阅读人数", "头像", "昵称", "用户id" ,"手机号"};
            for (int i = 0; i < lie.Length; i++)
            {
                dt.Columns.Add(lie[i]);
            }   

                DataRow dr = dt.NewRow();
                dr["报名截止时间"] = query.报名截止时间;
                dr["标题"] = query.标题;
                dr["开始时间"] = query.开始时间;
                dr["主题图片"] = query.主题图片;
                dr["内容"] = query.内容;
                dr["喜欢人数"] = query.喜欢人数;
                dr["阅读人数"] = query.阅读人数;
                dr["头像"] = query.用户.头像;
                dr["昵称"] = query.用户.昵称;
                dr["用户id"] = query.用户.Id;
                dr["活动地址"] = query.活动地址;
                dr["结束时间"] = query.结束时间;
                dr["发布时间"] = query.发起时间;
                dr["手机号"] = query.用户.手机号;
                dr["报名人数"] = query.报名记录.Count;
                dt.Rows.Add(dr);
            
           
            }
            return dt;
       
        }
        //我的活动
        public string hd_GetmeActivities(int  id)
        {


            var dt = DateTime.Now;

            var query = from n in base.GetList()
                        where n.用户Id == id
                        orderby n.Id descending
                        select new
                        {
                            标题 = n.标题,
                            开始时间 = n.开始时间,
                            主题 = n.主题图片,
                            头像 = n.用户.头像,
                            手机号 = n.用户.手机号,
                            id = n.Id,
                            地址 = n.活动地址,
                            状态 = dt > n.结束时间 ? "已结束" : "进行中"
                        };
                return JsonConvert.SerializeObject(query);
           

        }


        //获取最新活动
        public string hd_GetNewActivities(string zt)
        {


            var dt = DateTime.Now;

            if (zt == "全部分类")
            {
                var query = (from n in base.GetList()
                             where n.delete != true && n.报名截止时间 >= dt
                             orderby n.Id descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 主题 = n.主题图片,
                                 头像 = n.用户.头像,
                                 手机号 = n.用户.手机号,
                                 id = n.Id,
                                 地址 = n.活动地址
                             }).Take(6);
                return JsonConvert.SerializeObject(query);
            }
            else
            {
                var query = (from n in base.GetList()
                             where n.主题.名称 == zt && n.delete != true && n.报名截止时间 >= dt
                             orderby n.Id descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 手机号 = n.用户.手机号,
                                 主题 = n.主题图片,
                                 头像 = n.用户.头像,
                                 id = n.Id,
                                 地址 = n.活动地址
                             }).Take(6);
                return JsonConvert.SerializeObject(query);
            }
            
          //  Skip()  跳过前几项
           
        }

        //获取刷新活动
        public string hd_GetNewActivities(string zt,int id)
        {


            var dt = DateTime.Now;

            if (zt == "全部分类")
            {
                var query = (from n in base.GetList()
                             where n.delete != true && n.报名截止时间 >= dt && n.Id<id
                             orderby n.Id descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 主题 = n.主题图片,
                                 手机号 = n.用户.手机号,
                                 头像 = n.用户.头像,
                                 id = n.Id,
                                 地址 = n.活动地址
                             }).Take(6);
                return JsonConvert.SerializeObject(query);
            }
            else
            {
                var query = (from n in base.GetList()
                             where n.主题.名称 == zt && n.delete != true && n.报名截止时间 >= dt && n.Id < id
                             orderby n.Id descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 主题 = n.主题图片,
                                 手机号 = n.用户.手机号,
                                 头像 = n.用户.头像,
                                 id = n.Id,
                                 地址 = n.活动地址
                             }).Take(6);
                return JsonConvert.SerializeObject(query);
            }

            //  Skip()  跳过前几项

        }

        //获取热活动
        public string hd_GetheatActivities(string zt)
        {


            var dt = DateTime.Now;
            if (zt == "全部分类")
            {
                var query = (from n in base.GetList()
                             where  n.delete != true && n.报名截止时间 >= dt
                             orderby n.喜欢人数 descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 主题 = n.主题图片,
                                 头像=n.用户.头像,
                                 id = n.Id,
                                 手机号=n.用户.手机号,
                                 地址 = n.活动地址
                             }).Take(6);
                return JsonConvert.SerializeObject(query);
            }
            else
            {
                var query = (from n in base.GetList()
                             where n.主题.名称 == zt && n.delete != true && n.报名截止时间 >= dt
                             orderby n.喜欢人数 descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 主题 = n.主题图片,
                                 手机号 = n.用户.手机号,
                                 头像 = n.用户.头像,
                                 id = n.Id,
                                 地址 = n.活动地址
                             }).Take(6);
                return JsonConvert.SerializeObject(query);

            }
           
        }


        //获取热活动
        public string hd_GetheatActivities(string zt,int count)
        {


            var dt = DateTime.Now;
            if (zt == "全部分类")
            {
                var query = (from n in base.GetList()
                             where n.delete != true && n.报名截止时间 >= dt
                             orderby n.喜欢人数 descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 主题 = n.主题图片,
                                 手机号 = n.用户.手机号,
                                 id = n.Id,
                                 地址 = n.活动地址
                             }).Skip(count*6).Take(6);
                return JsonConvert.SerializeObject(query);
            }
            else
            {
                var query = (from n in base.GetList()
                             where n.主题.名称 == zt && n.delete != true && n.报名截止时间 >= dt
                             orderby n.喜欢人数 descending
                             select new
                             {
                                 标题 = n.标题,
                                 开始时间 = n.开始时间,
                                 主题 = n.主题图片,
                                 id = n.Id,
                                 手机号 = n.用户.手机号,
                                 地址 = n.活动地址
                             }).Skip(count * 6).Take(6);
                return JsonConvert.SerializeObject(query);

            }

        }
      
    }
}
