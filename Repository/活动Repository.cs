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
    public class 活动Repository : BaseRepository<活动>, IRepository<活动, PageData<活动>>
    {
        public 活动Repository(IUnitOfWork _context) : base(_context) { }
    }
}
