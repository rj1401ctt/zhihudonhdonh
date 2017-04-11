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
    public class 意见反馈Repository : BaseRepository<意见反馈>, IRepository<意见反馈, PageData<意见反馈>>
    {
        public 意见反馈Repository(IUnitOfWork _context) : base(_context) { }
    }
}
