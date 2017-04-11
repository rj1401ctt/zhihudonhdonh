using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZVTC.SoftDev.DDDFW.EntityServices;
using Model;
using Repository;

namespace EntityServices
{
  public class  chidrenEntityServicesFactory: EntitiesServicesFactory
    {
      public chidrenEntityServicesFactory() : base(new chidrenContainer()) { }

        用户Service _用户Service = null;
        public 用户Service 用户Service
        {
            get
            {
                if (_用户Service == null)
                    _用户Service = new 用户Service(base._context, new 用户Repository(base._context));
                return _用户Service;
            }
        }
        管理员Service _管理员Service = null;
        public 管理员Service 管理员Service
        {
            get
            {
                if (_管理员Service == null)
                    _管理员Service = new 管理员Service(base._context, new 管理员Repository(base._context));
                return _管理员Service;
            }
        }
        关注Service _关注Service = null;
        public 关注Service 关注Service
        {
            get
            {
                if (_关注Service == null)
                    _关注Service = new 关注Service(base._context, new 关注Repository(base._context));
                return _关注Service;
            }
        }
        报名记录Service _报名记录Service = null;
        public 报名记录Service 报名记录Service
        {
            get
            {
                if (_报名记录Service == null)
                    _报名记录Service = new 报名记录Service(base._context, new 报名记录Repository(base._context));
                return _报名记录Service;
            }
        }
        广告轮播Service _广告轮播Service = null;
        public 广告轮播Service 广告轮播Service
        {
            get
            {
                if (_广告轮播Service == null)
                    _广告轮播Service = new 广告轮播Service(base._context, new 广告轮播Repository(base._context));
                return _广告轮播Service;
            }
        }
        活动Service _活动Service = null;
        public 活动Service 活动Service
        {
            get
            {
                if (_活动Service == null)
                    _活动Service = new 活动Service(base._context, new 活动Repository(base._context));
                return _活动Service;
            }
        }
        活动评论Service _活动评论Service = null;
        public 活动评论Service 活动评论Service
        {
            get
            {
                if (_活动评论Service == null)
                    _活动评论Service = new 活动评论Service(base._context, new 活动评论Repository(base._context));
                return _活动评论Service;
            }
        }
        精选活动Service _精选活动Service = null;
        public 精选活动Service 精选活动Service
        {
            get
            {
                if (_精选活动Service == null)
                    _精选活动Service = new 精选活动Service(base._context, new 精选活动Repository(base._context));
                return _精选活动Service;
            }
        }
        喜欢记录Service _喜欢记录Service = null;
        public 喜欢记录Service 喜欢记录Service
        {
            get
            {
                if (_喜欢记录Service == null)
                    _喜欢记录Service = new 喜欢记录Service(base._context, new 喜欢记录Repository(base._context));
                return _喜欢记录Service;
            }
        }
     

        相册Service _相册Service = null;
        public 相册Service 相册Service
        {
            get
            {
                if (_相册Service == null)
                    _相册Service = new 相册Service(base._context, new 相册Repository(base._context));
                return _相册Service;
            }
        }

        动态Service _动态Service = null;
        public 动态Service 动态Service
        {
            get
            {
                if (_动态Service == null)
                    _动态Service = new 动态Service(base._context, new 动态Repository(base._context));
                return _动态Service;
            }
        }

        动态附件Service _动态附件Service = null;
        public 动态附件Service 动态附件Service
        {
            get
            {
                if (_动态附件Service == null)
                    _动态附件Service = new 动态附件Service(base._context, new 动态附件Repository(base._context));
                return _动态附件Service;
            }
        }
        动态评论Service _动态评论Service = null;
        public 动态评论Service 动态评论Service
        {
            get
            {
                if (_动态评论Service == null)
                    _动态评论Service = new 动态评论Service(base._context, new 动态评论Repository(base._context));
                return _动态评论Service;
            }
        }

        动态点赞记录Service _动态点赞记录Service = null;
        public 动态点赞记录Service 动态点赞记录Service
        {
            get
            {
                if (_动态点赞记录Service == null)
                    _动态点赞记录Service = new 动态点赞记录Service(base._context, new 动态点赞记录Repository(base._context));
                return _动态点赞记录Service;
            }
        }

        意见反馈Service _意见反馈Service = null;
        public 意见反馈Service 意见反馈Service
        {
            get
            {
                if (_意见反馈Service == null)
                    _意见反馈Service = new 意见反馈Service(base._context, new 意见反馈Repository(base._context));
                return _意见反馈Service;
            }
        }

        主题Service _主题Service = null;
        public 主题Service 主题Service
        {
            get
            {
                if (_主题Service == null)
                    _主题Service = new 主题Service(base._context, new 主题Repository(base._context));
                return _主题Service;
            }
        }
    }
}
