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
    public class 动态评论Repository : BaseRepository<动态评论>, IRepository<动态评论, PageData<动态评论>>
    {
        public 动态评论Repository(IUnitOfWork _context) : base(_context) { }
    }
}
