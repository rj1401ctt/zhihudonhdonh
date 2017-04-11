using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using WZVTC.SoftDev.DDDFW.Domain.Core;
using WZVTC.SoftDev.DDDFW.Global;
using WZVTC.SoftDev.DDDFW.Repository;

namespace Repository
{
    public class 活动评论Repository : BaseRepository<活动评论>, IRepository<活动评论, PageData<活动评论>>
    {
        public 活动评论Repository(IUnitOfWork _context) : base(_context) { }
    }
}
