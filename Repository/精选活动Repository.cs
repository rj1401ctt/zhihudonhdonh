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
    public class 精选活动Repository : BaseRepository<精选活动>, IRepository<精选活动, PageData<精选活动>>
    {
        public 精选活动Repository(IUnitOfWork _context) : base(_context) { }
    }
}
